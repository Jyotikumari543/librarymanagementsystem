namespace library
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBooksToolStripMenuItem = new ToolStripMenuItem();
            deleteBooksToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            addStudentsToolStripMenuItem = new ToolStripMenuItem();
            viewStudentsInfoToolStripMenuItem = new ToolStripMenuItem();
            issueBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            completeBooksDetailToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentsToolStripMenuItem, issueBooksToolStripMenuItem, returnBooksToolStripMenuItem, completeBooksDetailToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(993, 108);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackColor = Color.OldLace;
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBooksToolStripMenuItem, deleteBooksToolStripMenuItem });
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(113, 104);
            booksToolStripMenuItem.Text = "Books";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // addNewBooksToolStripMenuItem
            // 
            addNewBooksToolStripMenuItem.Image = (Image)resources.GetObject("addNewBooksToolStripMenuItem.Image");
            addNewBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewBooksToolStripMenuItem.Name = "addNewBooksToolStripMenuItem";
            addNewBooksToolStripMenuItem.Size = new Size(271, 102);
            addNewBooksToolStripMenuItem.Text = "Add new Books";
            addNewBooksToolStripMenuItem.Click += addNewBooksToolStripMenuItem_Click;
            // 
            // deleteBooksToolStripMenuItem
            // 
            deleteBooksToolStripMenuItem.Image = (Image)resources.GetObject("deleteBooksToolStripMenuItem.Image");
            deleteBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteBooksToolStripMenuItem.Name = "deleteBooksToolStripMenuItem";
            deleteBooksToolStripMenuItem.Size = new Size(271, 102);
            deleteBooksToolStripMenuItem.Text = "View Books";
            deleteBooksToolStripMenuItem.Click += deleteBooksToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.BackColor = Color.OldLace;
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentsToolStripMenuItem, viewStudentsInfoToolStripMenuItem });
            studentsToolStripMenuItem.Image = (Image)resources.GetObject("studentsToolStripMenuItem.Image");
            studentsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(180, 104);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // addStudentsToolStripMenuItem
            // 
            addStudentsToolStripMenuItem.Image = (Image)resources.GetObject("addStudentsToolStripMenuItem.Image");
            addStudentsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addStudentsToolStripMenuItem.Name = "addStudentsToolStripMenuItem";
            addStudentsToolStripMenuItem.Size = new Size(295, 106);
            addStudentsToolStripMenuItem.Text = "Add students";
            addStudentsToolStripMenuItem.Click += addStudentsToolStripMenuItem_Click;
            // 
            // viewStudentsInfoToolStripMenuItem
            // 
            viewStudentsInfoToolStripMenuItem.Image = (Image)resources.GetObject("viewStudentsInfoToolStripMenuItem.Image");
            viewStudentsInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewStudentsInfoToolStripMenuItem.Name = "viewStudentsInfoToolStripMenuItem";
            viewStudentsInfoToolStripMenuItem.Size = new Size(295, 106);
            viewStudentsInfoToolStripMenuItem.Text = "View Students info";
            viewStudentsInfoToolStripMenuItem.Click += viewStudentsInfoToolStripMenuItem_Click;
            // 
            // issueBooksToolStripMenuItem
            // 
            issueBooksToolStripMenuItem.BackColor = Color.OldLace;
            issueBooksToolStripMenuItem.Image = (Image)resources.GetObject("issueBooksToolStripMenuItem.Image");
            issueBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            issueBooksToolStripMenuItem.Size = new Size(149, 104);
            issueBooksToolStripMenuItem.Text = "Issue Books";
            issueBooksToolStripMenuItem.Click += issueBooksToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.BackColor = Color.OldLace;
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(174, 104);
            returnBooksToolStripMenuItem.Text = "Return Books";
            returnBooksToolStripMenuItem.Click += returnBooksToolStripMenuItem_Click;
            // 
            // completeBooksDetailToolStripMenuItem
            // 
            completeBooksDetailToolStripMenuItem.BackColor = Color.OldLace;
            completeBooksDetailToolStripMenuItem.Image = (Image)resources.GetObject("completeBooksDetailToolStripMenuItem.Image");
            completeBooksDetailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeBooksDetailToolStripMenuItem.Name = "completeBooksDetailToolStripMenuItem";
            completeBooksDetailToolStripMenuItem.Size = new Size(274, 104);
            completeBooksDetailToolStripMenuItem.Text = "Complete books detail";
            completeBooksDetailToolStripMenuItem.Click += completeBooksDetailToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.OldLace;
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(97, 104);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(993, 683);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBooksToolStripMenuItem;
        private ToolStripMenuItem deleteBooksToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem addStudentsToolStripMenuItem;
        private ToolStripMenuItem viewStudentsInfoToolStripMenuItem;
        private ToolStripMenuItem issueBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem completeBooksDetailToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}