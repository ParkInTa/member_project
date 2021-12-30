using frojack0809.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frojack0809
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            OraMgr.Instance.connectDB();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (OraMgr.Instance.loging(passwd.Text) == "성공")
            {
            MessageBox.Show("로그인 성공");         
            Form1 form1 = new Form1();
            form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
