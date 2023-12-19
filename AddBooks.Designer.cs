namespace library
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            PurchaseDate = new DateTimePicker();
            btnCancel = new Button();
            btnSave = new Button();
            textQuantity = new TextBox();
            textPrice = new TextBox();
            textAuthorName = new TextBox();
            textPublication = new TextBox();
            textBookName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 93);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(500, 33);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 4;
            label8.Text = "BOOKS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(80, 33);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 3;
            label7.Text = "ADD";
            // 
            // panel2
            // 
            panel2.Location = new Point(243, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 333);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(252, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(246, 333);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.Controls.Add(PurchaseDate);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(textQuantity);
            panel3.Controls.Add(textPrice);
            panel3.Controls.Add(textAuthorName);
            panel3.Controls.Add(textPublication);
            panel3.Controls.Add(textBookName);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(243, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(441, 333);
            panel3.TabIndex = 2;
            // 
            // PurchaseDate
            // 
            PurchaseDate.Location = new Point(223, 150);
            PurchaseDate.Name = "PurchaseDate";
            PurchaseDate.Size = new Size(197, 27);
            PurchaseDate.TabIndex = 13;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(257, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(125, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "ADD";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textQuantity
            // 
            textQuantity.Location = new Point(223, 244);
            textQuantity.Name = "textQuantity";
            textQuantity.Size = new Size(197, 27);
            textQuantity.TabIndex = 10;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(223, 197);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(197, 27);
            textPrice.TabIndex = 9;
            // 
            // textAuthorName
            // 
            textAuthorName.Location = new Point(223, 67);
            textAuthorName.Name = "textAuthorName";
            textAuthorName.Size = new Size(197, 27);
            textAuthorName.TabIndex = 8;
            // 
            // textPublication
            // 
            textPublication.Location = new Point(223, 107);
            textPublication.Name = "textPublication";
            textPublication.Size = new Size(197, 27);
            textPublication.TabIndex = 7;
            // 
            // textBookName
            // 
            textBookName.Location = new Point(223, 25);
            textBookName.Name = "textBookName";
            textBookName.Size = new Size(197, 27);
            textBookName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 248);
            label6.Name = "label6";
            label6.Size = new Size(117, 19);
            label6.TabIndex = 5;
            label6.Text = "Book Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 201);
            label5.Name = "label5";
            label5.Size = new Size(93, 19);
            label5.TabIndex = 4;
            label5.Text = "Book Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 156);
            label4.Name = "label4";
            label4.Size = new Size(158, 19);
            label4.TabIndex = 3;
            label4.Text = "Book Purchase Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 71);
            label3.Name = "label3";
            label3.Size = new Size(149, 19);
            label3.TabIndex = 2;
            label3.Text = "Book Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 111);
            label2.Name = "label2";
            label2.Size = new Size(139, 19);
            label2.TabIndex = 1;
            label2.Text = "Book Publication";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(94, 19);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(675, 420);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "AddBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBooks";
            Load += AddBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button btnSave;
        private TextBox textQuantity;
        private TextBox textPrice;
        private TextBox textAuthorName;
        private TextBox textPublication;
        private TextBox textBookName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Button btnCancel;
        private DateTimePicker PurchaseDate;
    }
}