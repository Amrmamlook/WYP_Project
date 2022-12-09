
namespace personal_acountant
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn = new Krypton.Toolkit.KryptonButton();
            this.textpassword = new Krypton.Toolkit.KryptonTextBox();
            this.password = new Krypton.Toolkit.KryptonLabel();
            this.creataccountt = new Krypton.Toolkit.KryptonLinkLabel();
            this.kryptonLinkLabel1 = new Krypton.Toolkit.KryptonLinkLabel();
            this.email = new Krypton.Toolkit.KryptonLabel();
            this.textemail = new Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(524, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 48);
            this.label1.TabIndex = 37;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::personal_acountant.Properties.Resources.Untitled_2;
            this.pictureBox1.Location = new System.Drawing.Point(51, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 172);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(121)))), ((int)(((byte)(225)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(132, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 48);
            this.label3.TabIndex = 35;
            this.label3.Text = "W Y B";
            // 
            // btn
            // 
            this.btn.CornerRoundingRadius = 20F;
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.Location = new System.Drawing.Point(548, 325);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(158, 59);
            this.btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(121)))), ((int)(((byte)(225)))));
            this.btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(121)))), ((int)(((byte)(225)))));
            this.btn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn.StateCommon.Border.Rounding = 20F;
            this.btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn.TabIndex = 34;
            this.btn.Values.Text = "Log in";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(570, 234);
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '●';
            this.textpassword.Size = new System.Drawing.Size(187, 37);
            this.textpassword.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textpassword.StateActive.Border.Rounding = 15F;
            this.textpassword.TabIndex = 33;
            this.textpassword.UseSystemPasswordChar = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(449, 239);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(107, 28);
            this.password.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.password.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.password.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password.TabIndex = 32;
            this.password.Values.Text = "Password";
            // 
            // creataccountt
            // 
            this.creataccountt.Location = new System.Drawing.Point(647, 414);
            this.creataccountt.Name = "creataccountt";
            this.creataccountt.Size = new System.Drawing.Size(141, 24);
            this.creataccountt.TabIndex = 31;
            this.creataccountt.Values.Text = "Creat new account.";
            this.creataccountt.LinkClicked += new System.EventHandler(this.creataccountt_LinkClicked);
            // 
            // kryptonLinkLabel1
            // 
            this.kryptonLinkLabel1.Location = new System.Drawing.Point(425, 414);
            this.kryptonLinkLabel1.Name = "kryptonLinkLabel1";
            this.kryptonLinkLabel1.Size = new System.Drawing.Size(168, 24);
            this.kryptonLinkLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Black;
            this.kryptonLinkLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.Black;
            this.kryptonLinkLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLinkLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLinkLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLinkLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonLinkLabel1.TabIndex = 30;
            this.kryptonLinkLabel1.Values.Text = "Forgot your password?";
            this.kryptonLinkLabel1.LinkClicked += new System.EventHandler(this.kryptonLinkLabel1_LinkClicked);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(449, 136);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(67, 28);
            this.email.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.email.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.email.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email.TabIndex = 29;
            this.email.Values.Text = "Email";
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(570, 127);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(187, 37);
            this.textemail.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textemail.StateActive.Border.Rounding = 15F;
            this.textemail.TabIndex = 28;
            this.textemail.Text = "\r\n ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(121)))), ((int)(((byte)(225)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(26, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 187);
            this.label2.TabIndex = 27;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(121)))), ((int)(((byte)(225)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(407, 466);
            this.splitter1.TabIndex = 26;
            this.splitter1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.creataccountt);
            this.Controls.Add(this.kryptonLinkLabel1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitter1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.HelpButton = true;
            this.Name = "login";
            this.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.StateActive.Back.Color2 = System.Drawing.Color.White;
            this.StateActive.Border.Color1 = System.Drawing.Color.White;
            this.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Border.Rounding = 15;
            this.StateActive.Header.Back.Color1 = System.Drawing.Color.White;
            this.StateActive.Header.Back.Color2 = System.Drawing.Color.White;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonButton btn;
        private Krypton.Toolkit.KryptonTextBox textpassword;
        private Krypton.Toolkit.KryptonLabel password;
        private Krypton.Toolkit.KryptonLinkLabel creataccountt;
        private Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel1;
        private Krypton.Toolkit.KryptonLabel email;
        private Krypton.Toolkit.KryptonTextBox textemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
    }
}

