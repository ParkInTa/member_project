
namespace frojack0809.UI
{
    partial class Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.custListView = new System.Windows.Forms.ListView();
            this.cname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.whdahr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manager = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiButton1 = new Sunny.UI.UIButton();
            this.gogle = new Sunny.UI.UIComboBox();
            this.naver = new Sunny.UI.UITextBox();
            this.search = new Sunny.UI.UISymbolButton();
            this.listView2 = new System.Windows.Forms.ListView();
            this.dataa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rodnjf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.whdahr1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.managername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.managertel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.managergender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.managerage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.custname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custtel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custaddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custwnals = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custgender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.uiPanel1.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.uiPanel1.Size = new System.Drawing.Size(800, 61);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = "회원 정보";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // custListView
            // 
            this.custListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.custListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cname,
            this.age,
            this.gender,
            this.whdahr,
            this.manager});
            this.custListView.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custListView.HideSelection = false;
            this.custListView.Location = new System.Drawing.Point(212, 104);
            this.custListView.Name = "custListView";
            this.custListView.Size = new System.Drawing.Size(335, 97);
            this.custListView.TabIndex = 3;
            this.custListView.UseCompatibleStateImageBehavior = false;
            this.custListView.View = System.Windows.Forms.View.Details;
            this.custListView.SelectedIndexChanged += new System.EventHandler(this.custListView_SelectedIndexChanged);
            // 
            // cname
            // 
            this.cname.Text = "고객명";
            this.cname.Width = 75;
            // 
            // age
            // 
            this.age.Text = "나이";
            this.age.Width = 58;
            // 
            // gender
            // 
            this.gender.Text = "성별";
            // 
            // whdahr
            // 
            this.whdahr.Text = "종목";
            // 
            // manager
            // 
            this.manager.Text = "담당자";
            this.manager.Width = 81;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.uiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.uiButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.uiButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.uiButton1.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiButton1.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiButton1.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiButton1.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiButton1.Location = new System.Drawing.Point(331, 440);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.uiButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.uiButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.uiButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.uiButton1.Size = new System.Drawing.Size(110, 54);
            this.uiButton1.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiButton1.TabIndex = 4;
            this.uiButton1.Text = "종료";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // gogle
            // 
            this.gogle.DataSource = null;
            this.gogle.FillColor = System.Drawing.Color.White;
            this.gogle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.gogle.Items.AddRange(new object[] {
            "고객명",
            "담당자"});
            this.gogle.Location = new System.Drawing.Point(173, 69);
            this.gogle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gogle.MinimumSize = new System.Drawing.Size(63, 0);
            this.gogle.Name = "gogle";
            this.gogle.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.gogle.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.gogle.Size = new System.Drawing.Size(150, 29);
            this.gogle.Style = Sunny.UI.UIStyle.Gray;
            this.gogle.TabIndex = 5;
            this.gogle.Text = "선택하세요";
            this.gogle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // naver
            // 
            this.naver.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.naver.FillColor = System.Drawing.Color.White;
            this.naver.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.naver.Location = new System.Drawing.Point(331, 69);
            this.naver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naver.Maximum = 2147483647D;
            this.naver.Minimum = -2147483648D;
            this.naver.MinimumSize = new System.Drawing.Size(1, 1);
            this.naver.Name = "naver";
            this.naver.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.naver.Size = new System.Drawing.Size(150, 29);
            this.naver.Style = Sunny.UI.UIStyle.Gray;
            this.naver.TabIndex = 6;
            this.naver.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.search.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.search.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.search.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.search.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.search.Location = new System.Drawing.Point(497, 69);
            this.search.MinimumSize = new System.Drawing.Size(1, 1);
            this.search.Name = "search";
            this.search.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.search.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.search.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.search.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(123)))), ((int)(((byte)(129)))));
            this.search.Size = new System.Drawing.Size(118, 29);
            this.search.Style = Sunny.UI.UIStyle.Gray;
            this.search.Symbol = 61442;
            this.search.TabIndex = 67;
            this.search.Text = "검 색";
            this.search.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dataa,
            this.rodnjf,
            this.whdahr1});
            this.listView2.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(61, 339);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(321, 95);
            this.listView2.TabIndex = 70;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // dataa
            // 
            this.dataa.Text = "등록날짜";
            this.dataa.Width = 165;
            // 
            // rodnjf
            // 
            this.rodnjf.Text = "개월";
            this.rodnjf.Width = 72;
            // 
            // whdahr1
            // 
            this.whdahr1.Text = "종목";
            this.whdahr1.Width = 83;
            // 
            // listView3
            // 
            this.listView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.managername,
            this.managertel,
            this.managergender,
            this.managerage});
            this.listView3.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(397, 339);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(301, 95);
            this.listView3.TabIndex = 71;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // managername
            // 
            this.managername.Text = "담당자";
            this.managername.Width = 87;
            // 
            // managertel
            // 
            this.managertel.DisplayIndex = 3;
            this.managertel.Text = "나이";
            this.managertel.Width = 165;
            // 
            // managergender
            // 
            this.managergender.DisplayIndex = 1;
            this.managergender.Text = "전화번호";
            this.managergender.Width = 102;
            // 
            // managerage
            // 
            this.managerage.DisplayIndex = 2;
            this.managerage.Text = "성별";
            this.managerage.Width = 51;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.custname,
            this.custage,
            this.custtel,
            this.custaddr,
            this.custwnals,
            this.custgender});
            this.listView1.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(110, 218);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(523, 97);
            this.listView1.TabIndex = 72;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // custname
            // 
            this.custname.Text = "고객명";
            this.custname.Width = 75;
            // 
            // custage
            // 
            this.custage.Text = "나이";
            this.custage.Width = 58;
            // 
            // custtel
            // 
            this.custtel.Text = "전화번호";
            this.custtel.Width = 113;
            // 
            // custaddr
            // 
            this.custaddr.Text = "주소";
            this.custaddr.Width = 116;
            // 
            // custwnals
            // 
            this.custwnals.Text = "주민번호";
            this.custwnals.Width = 121;
            // 
            // custgender
            // 
            this.custgender.Text = "성별";
            this.custgender.Width = 177;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.naver);
            this.Controls.Add(this.gogle);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.custListView);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.ListView custListView;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIComboBox gogle;
        private Sunny.UI.UITextBox naver;
        private Sunny.UI.UISymbolButton search;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader rodnjf;
        private System.Windows.Forms.ColumnHeader whdahr1;
        private System.Windows.Forms.ColumnHeader dataa;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader managername;
        private System.Windows.Forms.ColumnHeader managertel;
        private System.Windows.Forms.ColumnHeader managergender;
        private System.Windows.Forms.ColumnHeader managerage;
        private System.Windows.Forms.ColumnHeader cname;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.ColumnHeader whdahr;
        private System.Windows.Forms.ColumnHeader manager;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader custname;
        private System.Windows.Forms.ColumnHeader custage;
        private System.Windows.Forms.ColumnHeader custtel;
        private System.Windows.Forms.ColumnHeader custaddr;
        private System.Windows.Forms.ColumnHeader custwnals;
        private System.Windows.Forms.ColumnHeader custgender;
    }
}