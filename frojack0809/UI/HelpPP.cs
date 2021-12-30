using frojack0809.AAdeter;
using frojack0809.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frojack0809.UI
{
    partial class HelpPP : Form
    {
        CustAdapter custAdapter;
        public HelpPP()
        {
            InitializeComponent();
        }

        public HelpPP(CustAdapter custAdapter)
        {
            InitializeComponent();
            this.custAdapter = custAdapter;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            string name = ptName.Text;
            string age = ptAge.Text;
            string tel = ptTel.Text;

            string gender = "";
            if (ptMen.Checked == true)
            {
                gender = "남";
            }
            else if (ptWomen.Checked == true)
            {
                gender = "여";
            }
            PTcu pTcu = new PTcu(name, age, tel, gender);
            custAdapter.addPtcu(pTcu);
            MessageBox.Show("담당자가 등록되었습니다.");

        }
    }
}
