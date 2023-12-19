namespace library
{
    partial class returnbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(returnbook));
            panel1 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnsearch = new Button();
            textenrollnment = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btncancel = new Button();
            btnreturn = new Button();
            textreturndate = new DateTimePicker();
            textbookissuedate = new TextBox();
            textbookname = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnsearch);
            panel1.Controls.Add(textenrollnment);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 470);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(156, 361);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(32, 361);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnsearch
            // 
            btnsearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearch.Location = new Point(58, 234);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(155, 29);
            btnsearch.TabIndex = 3;
            btnsearch.Text = "Search Student";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // textenrollnment
            // 
            textenrollnment.Location = new Point(46, 185);
            textenrollnment.Name = "textenrollnment";
            textenrollnment.Size = new Size(184, 27);
            textenrollnment.TabIndex = 2;
            textenrollnment.TextChanged += textenrollnment_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 143);
            label1.Name = "label1";
            label1.Size = new Size(218, 28);
            label1.TabIndex = 1;
            label1.Text = "Enter Enrollnment No";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(356, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(705, 470);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(btncancel);
            panel2.Controls.Add(btnreturn);
            panel2.Controls.Add(textreturndate);
            panel2.Controls.Add(textbookissuedate);
            panel2.Controls.Add(textbookname);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(136, 528);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 324);
            panel2.TabIndex = 2;
            // 
            // btncancel
            // 
            btncancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btncancel.Location = new Point(500, 237);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(111, 42);
            btncancel.TabIndex = 7;
            btncancel.Text = "CANCEL";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btnreturn
            // 
            btnreturn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnreturn.Location = new Point(367, 237);
            btnreturn.Name = "btnreturn";
            btnreturn.Size = new Size(105, 42);
            btnreturn.TabIndex = 6;
            btnreturn.Text = "RETURN";
            btnreturn.UseVisualStyleBackColor = true;
            btnreturn.Click += btnreturn_Click;
            // 
            // textreturndate
            // 
            textreturndate.Location = new Point(352, 173);
            textreturndate.Name = "textreturndate";
            textreturndate.Size = new Size(259, 27);
            textreturndate.TabIndex = 5;
            // 
            // textbookissuedate
            // 
            textbookissuedate.Location = new Point(352, 113);
            textbookissuedate.Name = "textbookissuedate";
            textbookissuedate.Size = new Size(259, 27);
            textbookissuedate.TabIndex = 4;
            // 
            // textbookname
            // 
            textbookname.Location = new Point(352, 59);
            textbookname.Name = "textbookname";
            textbookname.Size = new Size(259, 27);
            textbookname.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(142, 175);
            label4.Name = "label4";
            label4.Size = new Size(164, 25);
            label4.TabIndex = 2;
            label4.Text = "Book Return Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(142, 115);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 1;
            label2.Text = "Book Issue Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(142, 58);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 0;
            label3.Text = "Book Name";
            // 
            // returnbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1091, 511);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "returnbook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "returnbook";
            Load += returnbook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnsearch;
        private TextBox textenrollnment;
        private Label label1;
        private Button btncancel;
        private Button btnreturn;
        private DateTimePicker textreturndate;
        private TextBox textbookissuedate;
        private TextBox textbookname;
        private Label label4;
        private Label label2;
        private Label label3;
    }
}