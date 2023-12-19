namespace library
{
    partial class viewstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewstudent));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnRefresh = new Button();
            textSearchEnrollnment = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            textemail = new TextBox();
            textdepartment = new TextBox();
            textcontact = new TextBox();
            textenrollnment = new TextBox();
            textsemester = new TextBox();
            textstudentname = new TextBox();
            btnupdate = new Button();
            btndelete = new Button();
            btncancel = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 115);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(524, 51);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 1;
            label1.Text = "VIEW STUDENT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(392, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(593, 129);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // textSearchEnrollnment
            // 
            textSearchEnrollnment.Location = new Point(367, 131);
            textSearchEnrollnment.Name = "textSearchEnrollnment";
            textSearchEnrollnment.Size = new Size(198, 27);
            textSearchEnrollnment.TabIndex = 2;
            textSearchEnrollnment.TextChanged += textSearchEnrollment_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(178, 135);
            label2.Name = "label2";
            label2.Size = new Size(166, 23);
            label2.TabIndex = 2;
            label2.Text = "ENROLLNMENT NO";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(860, 331);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(textemail);
            panel2.Controls.Add(textdepartment);
            panel2.Controls.Add(textcontact);
            panel2.Controls.Add(textenrollnment);
            panel2.Controls.Add(textsemester);
            panel2.Controls.Add(textstudentname);
            panel2.Controls.Add(btnupdate);
            panel2.Controls.Add(btndelete);
            panel2.Controls.Add(btncancel);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(36, 544);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 327);
            panel2.TabIndex = 4;
            // 
            // textemail
            // 
            textemail.Location = new Point(594, 156);
            textemail.Name = "textemail";
            textemail.Size = new Size(198, 27);
            textemail.TabIndex = 5;
            // 
            // textdepartment
            // 
            textdepartment.Location = new Point(184, 156);
            textdepartment.Name = "textdepartment";
            textdepartment.Size = new Size(198, 27);
            textdepartment.TabIndex = 6;
            // 
            // textcontact
            // 
            textcontact.Location = new Point(594, 91);
            textcontact.Name = "textcontact";
            textcontact.Size = new Size(198, 27);
            textcontact.TabIndex = 7;
            // 
            // textenrollnment
            // 
            textenrollnment.Location = new Point(184, 92);
            textenrollnment.Name = "textenrollnment";
            textenrollnment.Size = new Size(198, 27);
            textenrollnment.TabIndex = 8;
            // 
            // textsemester
            // 
            textsemester.Location = new Point(594, 32);
            textsemester.Name = "textsemester";
            textsemester.Size = new Size(198, 27);
            textsemester.TabIndex = 9;
            // 
            // textstudentname
            // 
            textstudentname.Location = new Point(184, 32);
            textstudentname.Name = "textstudentname";
            textstudentname.Size = new Size(198, 27);
            textstudentname.TabIndex = 10;
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnupdate.Location = new Point(255, 252);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 29);
            btnupdate.TabIndex = 5;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btndelete.Location = new Point(435, 252);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 29);
            btndelete.TabIndex = 6;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btncancel
            // 
            btncancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btncancel.Location = new Point(614, 252);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(94, 29);
            btncancel.TabIndex = 7;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(421, 160);
            label8.Name = "label8";
            label8.Size = new Size(123, 23);
            label8.TabIndex = 7;
            label8.Text = "Student Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(37, 92);
            label7.Name = "label7";
            label7.Size = new Size(136, 23);
            label7.TabIndex = 6;
            label7.Text = "Enrollnment No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(37, 160);
            label6.Name = "label6";
            label6.Size = new Size(108, 23);
            label6.TabIndex = 5;
            label6.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(421, 36);
            label5.Name = "label5";
            label5.Size = new Size(153, 23);
            label5.TabIndex = 4;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(421, 92);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 3;
            label4.Text = "Student Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 36);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 2;
            label3.Text = "Student Name";
            // 
            // viewstudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(937, 554);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(textSearchEnrollnment);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            Name = "viewstudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "viewstudent";
            Load += viewstudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnRefresh;
        private TextBox textSearchEnrollnment;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label3;
        private TextBox textemail;
        private TextBox textdepartment;
        private TextBox textcontact;
        private TextBox textenrollnment;
        private TextBox textsemester;
        private TextBox textstudentname;
        private Button btnupdate;
        private Button btndelete;
        private Button btncancel;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}