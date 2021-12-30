
namespace frojack0809
{
    partial class Login_Form
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
            this.user = new Sunny.UI.UITextBox();
            this.passwd = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.loginOK = new Sunny.UI.UIButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user.FillColor = System.Drawing.Color.White;
            this.user.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.user.Location = new System.Drawing.Point(177, 124);
            this.user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user.Maximum = 2147483647D;
            this.user.Minimum = -2147483648D;
            this.user.MinimumSize = new System.Drawing.Size(1, 1);
            this.user.Name = "user";
            this.user.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.user.Size = new System.Drawing.Size(150, 29);
            this.user.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.user.TabIndex = 0;
            this.user.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwd
            // 
            this.passwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwd.FillColor = System.Drawing.Color.White;
            this.passwd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.passwd.Location = new System.Drawing.Point(177, 184);
            this.passwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwd.Maximum = 2147483647D;
            this.passwd.Minimum = -2147483648D;
            this.passwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.passwd.Name = "passwd";
            this.passwd.PasswordChar = '*';
            this.passwd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.passwd.Size = new System.Drawing.Size(150, 29);
            this.passwd.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.passwd.TabIndex = 2;
            this.passwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.Location = new System.Drawing.Point(54, 124);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 29);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "아이디";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.Location = new System.Drawing.Point(54, 184);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 29);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "비밀번호";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginOK
            // 
            this.loginOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.loginOK.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.loginOK.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.loginOK.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.loginOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.loginOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.loginOK.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.loginOK.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.loginOK.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.loginOK.Location = new System.Drawing.Point(118, 260);
            this.loginOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.loginOK.Name = "loginOK";
            this.loginOK.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.loginOK.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.loginOK.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.loginOK.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.loginOK.Size = new System.Drawing.Size(100, 35);
            this.loginOK.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.loginOK.TabIndex = 5;
            this.loginOK.Text = "확인";
            this.loginOK.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiSymbolButton1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.uiPanel1.Font = new System.Drawing.Font("엘리스 디지털배움체 OTF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.uiPanel1.Size = new System.Drawing.Size(350, 78);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiPanel1.TabIndex = 6;
            this.uiPanel1.Text = "로그인";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(226)))), ((int)(((byte)(137)))));
            this.uiSymbolButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.uiSymbolButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(137)))));
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiSymbolButton1.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiSymbolButton1.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiSymbolButton1.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.uiSymbolButton1.Location = new System.Drawing.Point(284, 22);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(151)))));
            this.uiSymbolButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(201)))), ((int)(((byte)(88)))));
            this.uiSymbolButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.uiSymbolButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(118)))), ((int)(((byte)(43)))));
            this.uiSymbolButton1.Size = new System.Drawing.Size(43, 35);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Office2010Silver;
            this.uiSymbolButton1.Symbol = 61453;
            this.uiSymbolButton1.TabIndex = 0;
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.loginOK);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox user;
        private Sunny.UI.UITextBox passwd;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton loginOK;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
    }
}