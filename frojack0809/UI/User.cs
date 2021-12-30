using frojack0809.AAdeter;
using frojack0809.DAO;
using frojack0809.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frojack0809.UI
{
    partial class User : Form
    {
        List<Customer> list;
        CustAdapter custAdt;

        public User()
        {
            InitializeComponent();
        }
        public User(CustAdapter custAdt)
        {
            InitializeComponent();
            this.custAdt = custAdt;
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string name = custName.Text;
            string age = custAge.Text;
            string tel = custTel.Text;
            string addr = custAddr.Text;
            string wnals = custWnals.Text;
            string rodnjf = usermonth.Text;
            string whdahr = kinds.Text;
           

            // DatePicker
            DateTime date = custDate.Value;
            string strDate = string.Format("{0}년 {1}월 {2}일",
                date.Year, date.Month, date.Day);

            // RadioButton
            string gender = "";
            if (custMen.Checked == true)
            {
                gender = "남";
            }
            else if (custWomen.Checked == true)
            {
                gender = "여";
            }                

            Console.WriteLine("고객명: " + name);
            Console.WriteLine("나이 :" + age);
            Console.WriteLine("전화: " + tel );
            Console.WriteLine("주소: " + addr);
            Console.WriteLine("주민 번호 :" + wnals);
            Console.WriteLine("등록 날짜: " + strDate);          
            Console.WriteLine("성별: " + gender);
            Console.WriteLine(rodnjf);
            Console.WriteLine("종목:" + whdahr);


            string[] dataArr = new string[]
            {
                name,age, tel, addr,wnals, gender,rodnjf,whdahr
            };

            string[] errMsg = new string[]
            {
                "이름 정보가 누락되었습니다.",
                "나이 가 누락되었습니다.",
                "전화번호가 누락되었습니다.",
                "주소 정보가 누락되었습니다.",
                "주민 번호가 누락되었습니다",
                "성별 정보가 누락되었습니다.",
                "개월수를 정하지 않았습니다.",
                "종목을 선택하십시요"
            };
            
            // 정보 누락 체크
            for (int i=0; i<dataArr.Length; i++)
            {
                if (dataArr[i] == "")
                {
                    MessageBox.Show(errMsg[i]);
                    // void 메쏘드에서는 메쏘드를 탈출
                    return;
                }
            }

            // 한글 이름 체크
            Regex regex = new Regex(@"^[가-힣]{2,4}$");
            Match m = regex.Match(name);
            if (m.Success == false)
            {
                MessageBox.Show("잘못된 이름 정보입니다.");
                ActiveControl = custName;
                custName.Focus();
                return;
            }


            //-----------------------------------------
            // 사용자가 입력한 정상적인 데이터를 처리
            //-----------------------------------------
            Customer cust = new Customer(name,age, tel, addr,wnals,gender);
            Wjdqh wjdqh = new Wjdqh(strDate, rodnjf, whdahr);
            custAdt.addCust(cust);
            custAdt.addwjdqh(wjdqh);
            MessageBox.Show("회원정보가 등록되었습니다.");
            

            Close();
        }
    }
}
