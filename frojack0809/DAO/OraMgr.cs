using frojack0809.MODEL;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frojack0809.DAO
{
    class OraMgr
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleCommand cmd;
        static OraMgr instance;

        public static OraMgr Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OraMgr();
                }
                return instance;
            }
        }

        // 생성자
        public OraMgr()
        {
            Console.WriteLine("오라클 객체 생성");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
        }

        // 소멸자
        ~OraMgr()
        {
            closeDB();
            Console.WriteLine("오라클 객체 소멸");
        }

        public void connectDB()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 오류: " + e.Message);
                Environment.Exit(0);
            }
        }

        public void closeDB()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 접속 해제");
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제 오류: " + e.Message);
            }
        }

        public void custTable()
        {
            try
            {
                string sql = "create table cust_0906 (" +
                     "num number  NOT NULL," +
                     "name varchar(10) NOT NULL," +
                     "age  varchar(20) NOT NULL," +
                     "tel  varchar(50) NOT NULL," +
                     "addr  varchar(20) NOT NULL," +
                     "wnals  varchar(20) NOT NULL," +
                     "gender varchar(20) NOT NULL," +
                     "emdfhr  DATE NOT NULL,"+
                     "PRIMARY KEY(num))";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string seq = "create sequence seq_num " +
                    "increment by 1 start with 1000";
                cmd.CommandText = seq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 생성 오류: " + e.Message);
            }
        }

        public void dropTable()
        {
            try
            {
                string sql = "drop table cust_0906";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string seq = "drop sequence seq_num";
                cmd.CommandText = seq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블(시퀀스) 삭제 오류: "
                    + e.Message);
            }
            
        }
        public void custDB(Customer cust)
        {
            try
            {
                string sql = string.Format("insert into cust_0906 values (" +
                    "'{0}','{1}','{2}','{3}','{4}','{5}',cust_0906_seq.nextval ) ",
                    cust.Name, cust.Age, cust.Tel,
                    cust.Addr, cust.Wnals, cust.Gender);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }

        }

        public void ptcuDB(PTcu ptcu)
        {
            try
            {
                string sql = string.Format("insert  all " +
                    " into pt_0906 values (" +
                    " '{0}' ,'{1}' ,'{2}' ,'{3}',pt_0906_seq.nextval) ",
                    ptcu.Name, ptcu.Age, ptcu.Tel,ptcu.Gender);
                sql += string.Format("into sales_0906 values (" +
                    " sales_0906_seq.nextval, sales_0906_seq.currval, sales_0906_seq.currval, sales_0906_seq.currval )"
                    );
                sql += "select * from dual";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("PT 데이터 추가 오류: " + e.Message);
            }

        }
        public void wjdDB(Wjdqh wjdqh)
        {
            try
            {
                string sql = string.Format("insert  " +
                    "into jungbo_0906 values(" +
                    "'{0}' ,'{1}' ,'{2}', jungbo_0906_seq.nextval ) ",
                    wjdqh.Data, wjdqh.Rodnjf, wjdqh.Whdahr);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("접수 데이터 추가 오류: " + e.Message);
            }

        }

        public List<Salesvo> getcustVo()
        {
            string sql = "select cu.name as 고객명, " +
                " cu.age as 나이, " +
                "cu.gender as 성별, wj.whdahr as 종목, " +
                "pt.name as 담당자 " +
                "from cust_0906 cu, pt_0906 pt, jungbo_0906 wj, sales_0906 sa " +
                "where sa.coid = pt.coid and sa.cid = cu.cuid and sa.wjid = wj.wjid ";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 1;
            List<Salesvo> list = new List<Salesvo>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {

                    Salesvo saVo = new Salesvo(
                        rd["고객명"].ToString(),
                        rd["나이"].ToString(),
                        rd["성별"].ToString(),
                        rd["종목"].ToString(),
                        rd["담당자"].ToString());
                    list.Add(saVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다 111.");
            }
            rd.Close();
            return list;
        }


        public string loging(string passwd)
        {
            string check = string.Empty;
            string sql = string.Format("select count(*) as ret, " +
                "decode(count(*), 1, '성공', 0, '실패' , 'None') as 결과 " +
                "from id_0907 where id = 'tim03207' and " +
                "func_decrypt(pwd) = '{0}' ", passwd);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    check = rd["결과"].ToString();
                    Console.WriteLine("암호 확인 :" + check);
                }
            }
            else
            {
                Console.WriteLine("암호가 존재하지 않습니다");
            }
            rd.Close();
            return check;
        }

        public List<Customer> getcustvi1(string name)
        {
             string sql = string.Format("select * from cust_0906 where name ='{0}' ", name);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 1;
            List<Customer> list = new List<Customer>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {

                    Customer saVo = new Customer(
                        rd["name"].ToString(),
                        rd["age"].ToString(),
                        rd["tel"].ToString(),
                        rd["addr"].ToString(),
                        rd["wnals"].ToString(),
                        rd["gender"].ToString(),
                        rd["cuid"].ToString());
                    list.Add(saVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다 222.");
            }
            rd.Close();
            return list;
        }

        public List<Wjdqh> getwjdqhvi1(string whdahr)
        {
            string sql = string.Format("select * from jungbo_0906 where whdahr ='{0}' ", whdahr);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 1;
            List<Wjdqh> list = new List<Wjdqh>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {

                    Wjdqh saVo = new Wjdqh(
                        rd["jdate"].ToString(),
                        rd["rodnjf"].ToString(),
                        rd["whdahr"].ToString(),
                        rd["wjid"].ToString());
                    list.Add(saVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다 333.");
            }
            rd.Close();
            return list;
        }

        public List<PTcu> getmatagervi1(string name)
        {
            string sql = string.Format("select * from pt_0906 where name ='{0}' ", name);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 1;
            List<PTcu> list = new List<PTcu>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {

                    PTcu saVo = new PTcu(
                        rd["name"].ToString(),
                        rd["age"].ToString(),
                        rd["tel"].ToString(),
                        rd["gender"].ToString(),
                        rd["coid"].ToString());
                    list.Add(saVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다 4444.");
            }
            rd.Close();
            return list;
        }

        public List<Salesvo> getcustchVo(string name)
        {
            string sql = string.Format("select cu.name as 고객명, " +
                " cu.age as 나이, " +
                "cu.gender as 성별, wj.whdahr as 종목, " +
                "pt.name as 담당자 " +
                "from cust_0906 cu, pt_0906 pt, jungbo_0906 wj, sales_0906 sa " +
                "where sa.coid = pt.coid and sa.cid = cu.cuid and sa.wjid = wj.wjid and cu.name = '{0}' ",name);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 1;
            List<Salesvo> list = new List<Salesvo>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {

                    Salesvo saVo = new Salesvo(
                        rd["고객명"].ToString(),
                        rd["나이"].ToString(),
                        rd["성별"].ToString(),
                        rd["종목"].ToString(),
                        rd["담당자"].ToString());
                    list.Add(saVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다 111.");
            }
            rd.Close();
            return list;
        }

        public List<Salesvo> getptchVo(string name)
        {
            string sql = string.Format("select cu.name as 고객명, " +
                " cu.age as 나이, " +
                "cu.gender as 성별, wj.whdahr as 종목, " +
                "pt.name as 담당자 " +
                "from cust_0906 cu, pt_0906 pt, jungbo_0906 wj, sales_0906 sa " +
                "where sa.coid = pt.coid and sa.cid = cu.cuid and sa.wjid = wj.wjid and cu.name = '{0}' ", name);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            int count = 1;
            List<Salesvo> list = new List<Salesvo>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {

                    Salesvo saVo = new Salesvo(
                        rd["고객명"].ToString(),
                        rd["나이"].ToString(),
                        rd["성별"].ToString(),
                        rd["종목"].ToString(),
                        rd["담당자"].ToString());
                    list.Add(saVo);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다 111.");
            }
            rd.Close();
            return list;
        }

    }
}
