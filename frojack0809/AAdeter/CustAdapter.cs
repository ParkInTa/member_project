using frojack0809.DAO;
using frojack0809.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frojack0809.AAdeter
{
    class CustAdapter
    {
        //고객정보를 저장하는 리스트
        List<Customer> list = new List<Customer>();
        List<Wjdqh> wjd = new List<Wjdqh>();
        List<PTcu> pt = new List<PTcu>();

        public void addCust(Customer cust)
        {
            list.Add(cust);
            addToDB(cust);
        }
        public void addToDB(Customer cust)
        {
            OraMgr.Instance.custDB(cust);
        }

        public void addwjdqh(Wjdqh wjdqh)
        {
            wjd.Add(wjdqh);
            addToDB(wjdqh);
        }
        public void addToDB(Wjdqh wjdqh)
        {
            OraMgr.Instance.wjdDB(wjdqh);
        }

        public void addPtcu(PTcu pTcu)
        {
            pt.Add(pTcu);
            addToDB(pTcu);
        }
        public void addToDB(PTcu pTcu)
        {
            OraMgr.Instance.ptcuDB(pTcu);
        }


        public void showCustList()
        {
            for(int i =0; i<list.Count; i++)
            {
                Console.WriteLine("이름 :" + list[i].Name );
                Console.WriteLine("나이 :" + list[i].Age);
                Console.WriteLine("전화 :" + list[i].Tel);
                Console.WriteLine("주소 :" + list[i].Addr);
                Console.WriteLine("주민번호 :" + list[i].Wnals);
                Console.WriteLine("성별 :" + list[i].Gender);


                Console.WriteLine("==================================");
            }
        }

             
        public List<Salesvo> getcustDB()
        {
            List<Salesvo> list = OraMgr.Instance.getcustVo();
            return list;
        }

        public List<Customer> getcustvi1DB(string name)
        {
            List<Customer> list = OraMgr.Instance.getcustvi1(name);
            return list;
        }

        public List<Wjdqh> getwjdqhvi1DB(string whdahr)
        {
            List<Wjdqh> list = OraMgr.Instance.getwjdqhvi1(whdahr);
            return list;
        }

        public List<PTcu> getmatagervi1DB(string name)
        {
            List<PTcu> list = OraMgr.Instance.getmatagervi1(name);
            return list;
        }
    
        public List<Salesvo> getcustchDB(string name)
        {
            List<Salesvo> list = OraMgr.Instance.getcustchVo(name);
            return list;
        }

        public List<Salesvo> getptchDB(string name)
        {
            List<Salesvo> list = OraMgr.Instance.getptchVo(name);
            return list;
        }



    }
}
