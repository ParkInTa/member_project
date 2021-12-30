using frojack0809.AAdeter;
using frojack0809.DAO;
using frojack0809.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frojack0809
{
    public partial class Form1 :Form
    {
        //고객 정보를 저장하는 리스트
        CustAdapter custAdt = new CustAdapter();
        public Form1()
        {
            InitializeComponent();
        }
        //종료
        private void uiSymbolButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            User user = new User(custAdt);
            user.ShowDialog();
        }

        //최소화
        private void MainClick_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void sales_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales(custAdt);
            sales.ShowDialog();
        }

        private void help_Click(object sender, EventArgs e)
        {
            HelpPP helppp = new HelpPP(custAdt);
            helppp.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //OraMgr.Instance.connectDB();
        }
    }
}
