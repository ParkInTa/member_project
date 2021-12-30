
namespace frojack0809
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.help = new Sunny.UI.UISymbolButton();
            this.sales = new Sunny.UI.UISymbolButton();
            this.addCustomer = new Sunny.UI.UISymbolButton();
            this.MainClick = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 295);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainExit);
            this.panel1.Controls.Add(this.help);
            this.panel1.Controls.Add(this.sales);
            this.panel1.Controls.Add(this.addCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 360);
            this.panel1.TabIndex = 9;
            // 
            // mainExit
            // 
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.mainExit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.mainExit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.mainExit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.mainExit.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mainExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.mainExit.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.mainExit.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.mainExit.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.mainExit.Location = new System.Drawing.Point(0, 270);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.mainExit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.mainExit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.mainExit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.mainExit.Size = new System.Drawing.Size(366, 90);
            this.mainExit.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.mainExit.Symbol = 61532;
            this.mainExit.SymbolSize = 45;
            this.mainExit.TabIndex = 3;
            this.mainExit.Text = "프로그램 종료";
            this.mainExit.Click += new System.EventHandler(this.uiSymbolButton4_Click);
            // 
            // help
            // 
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.Dock = System.Windows.Forms.DockStyle.Top;
            this.help.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.help.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.help.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.help.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.help.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.help.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.help.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.help.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.help.Location = new System.Drawing.Point(0, 180);
            this.help.MinimumSize = new System.Drawing.Size(1, 1);
            this.help.Name = "help";
            this.help.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.help.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.help.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.help.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.help.Size = new System.Drawing.Size(366, 90);
            this.help.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.help.Symbol = 62108;
            this.help.SymbolSize = 45;
            this.help.TabIndex = 2;
            this.help.Text = "담당자 등록";
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // sales
            // 
            this.sales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sales.Dock = System.Windows.Forms.DockStyle.Top;
            this.sales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.sales.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.sales.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sales.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.sales.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sales.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sales.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sales.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sales.Location = new System.Drawing.Point(0, 90);
            this.sales.MinimumSize = new System.Drawing.Size(1, 1);
            this.sales.Name = "sales";
            this.sales.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.sales.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.sales.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sales.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.sales.Size = new System.Drawing.Size(366, 90);
            this.sales.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.sales.Symbol = 62142;
            this.sales.SymbolSize = 45;
            this.sales.TabIndex = 1;
            this.sales.Text = "회원 정보 관리";
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.addCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.addCustomer.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.addCustomer.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.addCustomer.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.addCustomer.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.addCustomer.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.addCustomer.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.addCustomer.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.addCustomer.Location = new System.Drawing.Point(0, 0);
            this.addCustomer.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.addCustomer.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.addCustomer.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.addCustomer.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.addCustomer.Size = new System.Drawing.Size(366, 90);
            this.addCustomer.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.addCustomer.Symbol = 62004;
            this.addCustomer.SymbolSize = 45;
            this.addCustomer.TabIndex = 0;
            this.addCustomer.Text = "신규 회원 등록";
            this.addCustomer.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // MainClick
            // 
            this.MainClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainClick.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.MainClick.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.MainClick.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.MainClick.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.MainClick.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.MainClick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.MainClick.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.MainClick.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.MainClick.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.MainClick.Location = new System.Drawing.Point(287, 12);
            this.MainClick.MinimumSize = new System.Drawing.Size(1, 1);
            this.MainClick.Name = "MainClick";
            this.MainClick.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.MainClick.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.MainClick.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.MainClick.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.MainClick.Size = new System.Drawing.Size(67, 35);
            this.MainClick.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.MainClick.Symbol = 61544;
            this.MainClick.TabIndex = 10;
            this.MainClick.Click += new System.EventHandler(this.MainClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(366, 661);
            this.ControlBox = false;
            this.Controls.Add(this.MainClick);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "헬스 회원 등록 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UISymbolButton help;
        private Sunny.UI.UISymbolButton sales;
        private Sunny.UI.UISymbolButton addCustomer;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolButton MainClick;
    }
}

