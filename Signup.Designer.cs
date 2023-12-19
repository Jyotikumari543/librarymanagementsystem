namespace library
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            btnsignup = new Button();
            label1 = new Label();
            textemail = new TextBox();
            textconfirmpassword = new TextBox();
            textpassword = new TextBox();
            textname = new TextBox();
            Password = new Label();
            Email = new Label();
            Username = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnsignup);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textemail);
            panel1.Controls.Add(textconfirmpassword);
            panel1.Controls.Add(textpassword);
            panel1.Controls.Add(textname);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(Username);
            panel1.Location = new Point(263, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 388);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(354, 340);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 10;
            label3.Text = "Login";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(179, 343);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 9;
            label2.Text = "Already have an account? \r\n";
            // 
            // btnsignup
            // 
            btnsignup.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnsignup.Location = new Point(188, 271);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(110, 36);
            btnsignup.TabIndex = 8;
            btnsignup.Text = "Signup";
            btnsignup.UseVisualStyleBackColor = true;
            btnsignup.Click += btnsignup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 218);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 7;
            label1.Text = "Confirm Password";
            // 
            // textemail
            // 
            textemail.Location = new Point(226, 111);
            textemail.Name = "textemail";
            textemail.PlaceholderText = "Enter Email";
            textemail.Size = new Size(218, 27);
            textemail.TabIndex = 6;
            // 
            // textconfirmpassword
            // 
            textconfirmpassword.Location = new Point(226, 214);
            textconfirmpassword.Name = "textconfirmpassword";
            textconfirmpassword.PasswordChar = '*';
            textconfirmpassword.PlaceholderText = "Enter Confirm Password";
            textconfirmpassword.Size = new Size(218, 27);
            textconfirmpassword.TabIndex = 5;
            // 
            // textpassword
            // 
            textpassword.Location = new Point(226, 160);
            textpassword.Name = "textpassword";
            textpassword.PasswordChar = '*';
            textpassword.PlaceholderText = "Enter Password";
            textpassword.Size = new Size(218, 27);
            textpassword.TabIndex = 4;
            // 
            // textname
            // 
            textname.Location = new Point(226, 63);
            textname.Name = "textname";
            textname.PlaceholderText = "Enter Username";
            textname.Size = new Size(218, 27);
            textname.TabIndex = 3;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Password.Location = new Point(52, 160);
            Password.Name = "Password";
            Password.Size = new Size(85, 23);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Email.Location = new Point(52, 111);
            Email.Name = "Email";
            Email.Size = new Size(54, 23);
            Email.TabIndex = 1;
            Email.Text = "Email";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Username.Location = new Point(52, 64);
            Username.Name = "Username";
            Username.Size = new Size(89, 23);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(962, 618);
            Controls.Add(panel1);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Password;
        private Label Email;
        private Label Username;
        private Button btnsignup;
        private Label label1;
        private TextBox textemail;
        private TextBox textconfirmpassword;
        private TextBox textpassword;
        private TextBox textname;
        private Label label3;
        private Label label2;
    }
}