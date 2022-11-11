
namespace LibraryManagementSystem
{
    partial class AdminPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLibrarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLibrarianInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.librarianToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.issueBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1191, 58);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.AutoSize = false;
            this.booksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBooksToolStripMenuItem,
            this.searchBooksToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(122, 54);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addBooksToolStripMenuItem
            // 
            this.addBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addBooksToolStripMenuItem.Image")));
            this.addBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            this.addBooksToolStripMenuItem.Size = new System.Drawing.Size(254, 56);
            this.addBooksToolStripMenuItem.Text = "Add Books";
            this.addBooksToolStripMenuItem.Click += new System.EventHandler(this.addBooksToolStripMenuItem_Click);
            // 
            // searchBooksToolStripMenuItem
            // 
            this.searchBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchBooksToolStripMenuItem.Image")));
            this.searchBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchBooksToolStripMenuItem.Name = "searchBooksToolStripMenuItem";
            this.searchBooksToolStripMenuItem.Size = new System.Drawing.Size(254, 56);
            this.searchBooksToolStripMenuItem.Text = "Search Books";
            this.searchBooksToolStripMenuItem.Click += new System.EventHandler(this.searchBooksToolStripMenuItem_Click);
            // 
            // librarianToolStripMenuItem
            // 
            this.librarianToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.librarianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLibrarianToolStripMenuItem,
            this.viewLibrarianInformationToolStripMenuItem});
            this.librarianToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librarianToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("librarianToolStripMenuItem.Image")));
            this.librarianToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.librarianToolStripMenuItem.Name = "librarianToolStripMenuItem";
            this.librarianToolStripMenuItem.Size = new System.Drawing.Size(135, 54);
            this.librarianToolStripMenuItem.Text = "Librarian";
            // 
            // addLibrarianToolStripMenuItem
            // 
            this.addLibrarianToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addLibrarianToolStripMenuItem.Image")));
            this.addLibrarianToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addLibrarianToolStripMenuItem.Name = "addLibrarianToolStripMenuItem";
            this.addLibrarianToolStripMenuItem.Size = new System.Drawing.Size(309, 56);
            this.addLibrarianToolStripMenuItem.Text = "Add/Remove Librarian";
            this.addLibrarianToolStripMenuItem.Click += new System.EventHandler(this.addLibrarianToolStripMenuItem_Click);
            // 
            // viewLibrarianInformationToolStripMenuItem
            // 
            this.viewLibrarianInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewLibrarianInformationToolStripMenuItem.Image")));
            this.viewLibrarianInformationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewLibrarianInformationToolStripMenuItem.Name = "viewLibrarianInformationToolStripMenuItem";
            this.viewLibrarianInformationToolStripMenuItem.Size = new System.Drawing.Size(309, 56);
            this.viewLibrarianInformationToolStripMenuItem.Text = "View Librarian Information";
            this.viewLibrarianInformationToolStripMenuItem.Click += new System.EventHandler(this.viewLibrarianInformationToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.studentInformationToolStripMenuItem});
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentToolStripMenuItem.Image")));
            this.studentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(129, 54);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addStudentToolStripMenuItem.Image")));
            this.addStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(265, 56);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // studentInformationToolStripMenuItem
            // 
            this.studentInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentInformationToolStripMenuItem.Image")));
            this.studentInformationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentInformationToolStripMenuItem.Name = "studentInformationToolStripMenuItem";
            this.studentInformationToolStripMenuItem.Size = new System.Drawing.Size(265, 56);
            this.studentInformationToolStripMenuItem.Text = "Student Information";
            this.studentInformationToolStripMenuItem.Click += new System.EventHandler(this.studentInformationToolStripMenuItem_Click);
            // 
            // issueBooksToolStripMenuItem
            // 
            this.issueBooksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.issueBooksToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueBooksToolStripMenuItem.Image")));
            this.issueBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            this.issueBooksToolStripMenuItem.Size = new System.Drawing.Size(155, 54);
            this.issueBooksToolStripMenuItem.Text = "Issue Books";
            this.issueBooksToolStripMenuItem.Click += new System.EventHandler(this.issueBooksToolStripMenuItem_Click);
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.returnBooksToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnBooksToolStripMenuItem.Image")));
            this.returnBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(167, 54);
            this.returnBooksToolStripMenuItem.Text = "Return Books";
            this.returnBooksToolStripMenuItem.Click += new System.EventHandler(this.returnBooksToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leaveApplicationToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(126, 54);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // leaveApplicationToolStripMenuItem
            // 
            this.leaveApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("leaveApplicationToolStripMenuItem.Image")));
            this.leaveApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.leaveApplicationToolStripMenuItem.Name = "leaveApplicationToolStripMenuItem";
            this.leaveApplicationToolStripMenuItem.Size = new System.Drawing.Size(241, 56);
            this.leaveApplicationToolStripMenuItem.Text = "Leave Application";
            this.leaveApplicationToolStripMenuItem.Click += new System.EventHandler(this.leaveApplicationToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAdminToolStripMenuItem});
            this.adminToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminToolStripMenuItem.Image")));
            this.adminToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(117, 54);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // addAdminToolStripMenuItem
            // 
            this.addAdminToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addAdminToolStripMenuItem.Image")));
            this.addAdminToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            this.addAdminToolStripMenuItem.Size = new System.Drawing.Size(258, 56);
            this.addAdminToolStripMenuItem.Text = "Add/Remove Admin";
            this.addAdminToolStripMenuItem.Click += new System.EventHandler(this.addAdminToolStripMenuItem_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 633);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPage";
            this.Text = "Admin Page Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLibrarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLibrarianInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
    }
}