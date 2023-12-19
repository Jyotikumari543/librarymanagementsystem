namespace library
{
    partial class issuebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issuebook));
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnRefresh = new Button();
            btnExit = new Button();
            btnSearch = new Button();
            textSearchEnrollnment = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            comboBoxBook = new ComboBox();
            label10 = new Label();
            dateissue = new DateTimePicker();
            label9 = new Label();
            btnIssue = new Button();
            textemail = new TextBox();
            textcontact = new TextBox();
            textsemester = new TextBox();
            textdepartment = new TextBox();
            textstudentname = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 99);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(437, 46);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 4;
            label4.Text = "ISSUE BOOKS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(332, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(textSearchEnrollnment);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(12, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 434);
            panel2.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(20, 309);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 39);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(182, 309);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 39);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(68, 215);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(167, 38);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search student";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textSearchEnrollnment
            // 
            textSearchEnrollnment.Location = new Point(36, 166);
            textSearchEnrollnment.Name = "textSearchEnrollnment";
            textSearchEnrollnment.Size = new Size(240, 27);
            textSearchEnrollnment.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 126);
            label2.Name = "label2";
            label2.Size = new Size(218, 28);
            label2.TabIndex = 3;
            label2.Text = "Enter Enrollnemnt No";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(82, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.Location = new Point(325, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(534, 383);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(comboBoxBook);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(dateissue);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(btnIssue);
            panel5.Controls.Add(textemail);
            panel5.Controls.Add(textcontact);
            panel5.Controls.Add(textsemester);
            panel5.Controls.Add(textdepartment);
            panel5.Controls.Add(textstudentname);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(318, 132);
            panel5.Name = "panel5";
            panel5.Size = new Size(517, 431);
            panel5.TabIndex = 2;
            // 
            // comboBoxBook
            // 
            comboBoxBook.FormattingEnabled = true;
            comboBoxBook.Location = new Point(208, 245);
            comboBoxBook.Name = "comboBoxBook";
            comboBoxBook.Size = new Size(240, 28);
            comboBoxBook.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Firebrick;
            label10.Location = new Point(58, 375);
            label10.Name = "label10";
            label10.Size = new Size(456, 56);
            label10.TabIndex = 5;
            label10.Text = "Maximum 3 Books Can be ISSUED to 1 Student\r\n\r\n";
            // 
            // dateissue
            // 
            dateissue.Location = new Point(208, 286);
            dateissue.Name = "dateissue";
            dateissue.Size = new Size(240, 27);
            dateissue.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 290);
            label9.Name = "label9";
            label9.Size = new Size(137, 23);
            label9.TabIndex = 11;
            label9.Text = "Book Issue Date";
            // 
            // btnIssue
            // 
            btnIssue.BackColor = SystemColors.HotTrack;
            btnIssue.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIssue.Location = new Point(337, 331);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(129, 41);
            btnIssue.TabIndex = 8;
            btnIssue.Text = "Issue Book";
            btnIssue.UseVisualStyleBackColor = false;
            btnIssue.Click += btnIssue_Click;
            // 
            // textemail
            // 
            textemail.Location = new Point(208, 202);
            textemail.Name = "textemail";
            textemail.ReadOnly = true;
            textemail.Size = new Size(240, 27);
            textemail.TabIndex = 6;
            // 
            // textcontact
            // 
            textcontact.Location = new Point(208, 156);
            textcontact.Name = "textcontact";
            textcontact.ReadOnly = true;
            textcontact.Size = new Size(240, 27);
            textcontact.TabIndex = 7;
            // 
            // textsemester
            // 
            textsemester.Location = new Point(208, 107);
            textsemester.Name = "textsemester";
            textsemester.ReadOnly = true;
            textsemester.Size = new Size(240, 27);
            textsemester.TabIndex = 8;
            // 
            // textdepartment
            // 
            textdepartment.Location = new Point(208, 62);
            textdepartment.Name = "textdepartment";
            textdepartment.ReadOnly = true;
            textdepartment.Size = new Size(240, 27);
            textdepartment.TabIndex = 9;
            // 
            // textstudentname
            // 
            textstudentname.Location = new Point(208, 19);
            textstudentname.Name = "textstudentname";
            textstudentname.ReadOnly = true;
            textstudentname.Size = new Size(240, 27);
            textstudentname.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(0, 62);
            label8.Name = "label8";
            label8.Size = new Size(108, 23);
            label8.TabIndex = 10;
            label8.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(0, 107);
            label7.Name = "label7";
            label7.Size = new Size(153, 23);
            label7.TabIndex = 9;
            label7.Text = "Student Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 156);
            label6.Name = "label6";
            label6.Size = new Size(141, 23);
            label6.TabIndex = 8;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 202);
            label5.Name = "label5";
            label5.Size = new Size(123, 23);
            label5.TabIndex = 7;
            label5.Text = "Student Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 246);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 5;
            label3.Text = "Book Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 19);
            label1.Name = "label1";
            label1.Size = new Size(126, 23);
            label1.TabIndex = 4;
            label1.Text = "Student Name\r\n";
            // 
            // issuebook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(847, 575);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "issuebook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "issuebook";
            Load += issuebook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Button btnRefresh;
        private Button btnExit;
        private Button btnSearch;
        private TextBox textSearchEnrollnment;
        private Button btnIssue;
        private TextBox textemail;
        private TextBox textcontact;
        private TextBox textsemester;
        private TextBox textdepartment;
        private TextBox textstudentname;
        private Label label10;
        private DateTimePicker dateissue;
        private Label label9;
        private ComboBox comboBoxBook;
    }
}