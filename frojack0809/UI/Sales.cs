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

    partial class Sales : Form
    {
        List<Customer> list;
        CustAdapter CustAdapter;
        
        public Sales()
        {
            InitializeComponent();
        }
        public Sales(List<Customer>list)
        {
            InitializeComponent();
            this.list = list;
            initListView2();
        }
        public Sales(CustAdapter custAdapter)
        {
            InitializeComponent();
            this.CustAdapter = custAdapter;
        }


        void initListView2()
        {
            List<Salesvo> list = CustAdapter.getcustDB();

            for (int i = 0; i < list.Count; i++)
            {
                custListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        list[i].Custname,
                        list[i].Custage,
                        list[i].Custgender,
                        list[i].Wjdwhd,
                        list[i].Manager

                    })) ;
            }
        }


        private void Sales_Load(object sender, EventArgs e)
        {
            custListView.Items.Clear();
            initListView2();
        }

        private void custListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();

            if (custListView.SelectedItems.Count != 0)
            {
                int n = custListView.SelectedItems[0].Index;
                Console.WriteLine("n :" + n);
                string name = custListView.Items[n].SubItems[0].Text;
                string age = custListView.Items[n].SubItems[1].Text;
                string gender = custListView.Items[n].SubItems[2].Text;


                string name_search = custListView.FocusedItem.SubItems[0].Text;
                List<Customer> cuList = CustAdapter.getcustvi1DB(name_search);

                string[] lst = new string[]
                {
                    cuList[0].Name,
                    cuList[0].Age,
                    cuList[0].Tel,
                    cuList[0].Addr,
                    cuList[0].Wnals,
                    cuList[0].Gender
                };
                listView1.Items.Add(new ListViewItem(lst));

                //
                string cname_search = custListView.FocusedItem.SubItems[3].Text;

                List<Wjdqh> carList = CustAdapter.getwjdqhvi1DB(cname_search);
                string[] cst = new string[]
                {
                    carList[0].Data,
                    carList[0].Rodnjf,
                    carList[0].Whdahr
                };
                listView2.Items.Add(new ListViewItem(cst));
                //
                string pname_search = custListView.FocusedItem.SubItems[4].Text;

                List<PTcu> ptList = CustAdapter.getmatagervi1DB(pname_search);
                string[] pst = new string[]
                {
                    ptList[0].Name,
                    ptList[0].Age,
                    ptList[0].Tel,
                    ptList[0].Gender
                };
                listView3.Items.Add(new ListViewItem(pst));



            }

        }
       

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string name = naver.Text;
            string choice = gogle.Text;
            custListView.Items.Clear();
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            
            if(choice == "고객명")
            {
                List<Salesvo> list = CustAdapter.getcustchDB(name);
                for(int i = 0; i<list.Count; i++)
                {
                    custListView.Items.Add(new ListViewItem(new string[]
                    {
                        list[i].Custname,
                        list[i].Custage,
                        list[i].Custgender,
                        list[i].Wjdwhd,
                        list[i].Manager
                    }));
                }
            }
            else if(choice == "담당자")
            {
                List<Salesvo> list = CustAdapter.getptchDB(name);
                for (int i = 0; i < list.Count; i++)
                {
                    custListView.Items.Add(new ListViewItem(new string[]
                    {
                        list[i].Custname,
                        list[i].Custage,
                        list[i].Custgender,
                        list[i].Wjdwhd,
                        list[i].Manager
                    }));
                }
            }
        }
    }
}
