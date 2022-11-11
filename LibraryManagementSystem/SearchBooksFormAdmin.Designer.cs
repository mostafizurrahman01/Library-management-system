
namespace LibraryManagementSystem
{
    partial class SearchBooksFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBooksFormAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSearchBooks = new System.Windows.Forms.DataGridView();
            this.lblBookNameSearchBooksForm = new System.Windows.Forms.Label();
            this.lblBookAuthorNameSearchBooksForm = new System.Windows.Forms.Label();
            this.lblBookPublicationSearchBooksForm = new System.Windows.Forms.Label();
            this.lblBookPurchasedDateSearchBooksForm = new System.Windows.Forms.Label();
            this.lblBookPriceSearchBooksForm = new System.Windows.Forms.Label();
            this.lblBookQuantitySearchBooksForm = new System.Windows.Forms.Label();
            this.txtBookNameSearchBooksForm = new System.Windows.Forms.TextBox();
            this.txtBookAuthorNameSearchBooksForm = new System.Windows.Forms.TextBox();
            this.txtBookPublicationSearchBooksForm = new System.Windows.Forms.TextBox();
            this.txtBookPriceSearchBooksForm = new System.Windows.Forms.TextBox();
            this.txtBookQuantitySearchBooksForm = new System.Windows.Forms.TextBox();
            this.dtpBookPurchasedDateSearchBooksForm = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateSearchBooksForm = new System.Windows.Forms.Button();
            this.btnDeleteSearchBooksForm = new System.Windows.Forms.Button();
            this.btnCancelSearchBooksForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshSearchBook = new System.Windows.Forms.Button();
            this.txtBookNameTopSearchBook = new System.Windows.Forms.TextBox();
            this.lblBookNameTopSearchBooks = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBooks)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 129);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(575, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(428, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSearchBooks
            // 
            this.dgvSearchBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchBooks.Location = new System.Drawing.Point(24, 206);
            this.dgvSearchBooks.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSearchBooks.Name = "dgvSearchBooks";
            this.dgvSearchBooks.RowHeadersWidth = 51;
            this.dgvSearchBooks.Size = new System.Drawing.Size(1261, 383);
            this.dgvSearchBooks.TabIndex = 4;
            this.dgvSearchBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblBookNameSearchBooksForm
            // 
            this.lblBookNameSearchBooksForm.AutoSize = true;
            this.lblBookNameSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookNameSearchBooksForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNameSearchBooksForm.Location = new System.Drawing.Point(69, 60);
            this.lblBookNameSearchBooksForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookNameSearchBooksForm.Name = "lblBookNameSearchBooksForm";
            this.lblBookNameSearchBooksForm.Size = new System.Drawing.Size(114, 25);
            this.lblBookNameSearchBooksForm.TabIndex = 0;
            this.lblBookNameSearchBooksForm.Text = "Book Name";
            // 
            // lblBookAuthorNameSearchBooksForm
            // 
            this.lblBookAuthorNameSearchBooksForm.AutoSize = true;
            this.lblBookAuthorNameSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookAuthorNameSearchBooksForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthorNameSearchBooksForm.Location = new System.Drawing.Point(69, 123);
            this.lblBookAuthorNameSearchBooksForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookAuthorNameSearchBooksForm.Name = "lblBookAuthorNameSearchBooksForm";
            this.lblBookAuthorNameSearchBooksForm.Size = new System.Drawing.Size(177, 25);
            this.lblBookAuthorNameSearchBooksForm.TabIndex = 1;
            this.lblBookAuthorNameSearchBooksForm.Text = "Book Author Name";
            // 
            // lblBookPublicationSearchBooksForm
            // 
            this.lblBookPublicationSearchBooksForm.AutoSize = true;
            this.lblBookPublicationSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookPublicationSearchBooksForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPublicationSearchBooksForm.Location = new System.Drawing.Point(69, 182);
            this.lblBookPublicationSearchBooksForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookPublicationSearchBooksForm.Name = "lblBookPublicationSearchBooksForm";
            this.lblBookPublicationSearchBooksForm.Size = new System.Drawing.Size(157, 25);
            this.lblBookPublicationSearchBooksForm.TabIndex = 2;
            this.lblBookPublicationSearchBooksForm.Text = "Book Publication";
            // 
            // lblBookPurchasedDateSearchBooksForm
            // 
            this.lblBookPurchasedDateSearchBooksForm.AutoSize = true;
            this.lblBookPurchasedDateSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookPurchasedDateSearchBooksForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPurchasedDateSearchBooksForm.Location = new System.Drawing.Point(651, 60);
            this.lblBookPurchasedDateSearchBooksForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookPurchasedDateSearchBooksForm.Name = "lblBookPurchasedDateSearchBooksForm";
            this.lblBookPurchasedDateSearchBooksForm.Size = new System.Drawing.Size(202, 25);
            this.lblBookPurchasedDateSearchBooksForm.TabIndex = 3;
            this.lblBookPurchasedDateSearchBooksForm.Text = "Book Purchased Date";
            // 
            // lblBookPriceSearchBooksForm
            // 
            this.lblBookPriceSearchBooksForm.AutoSize = true;
            this.lblBookPriceSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookPriceSearchBooksForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPriceSearchBooksForm.Location = new System.Drawing.Point(651, 123);
            this.lblBookPriceSearchBooksForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookPriceSearchBooksForm.Name = "lblBookPriceSearchBooksForm";
            this.lblBookPriceSearchBooksForm.Size = new System.Drawing.Size(106, 25);
            this.lblBookPriceSearchBooksForm.TabIndex = 4;
            this.lblBookPriceSearchBooksForm.Text = "Book Price";
            // 
            // lblBookQuantitySearchBooksForm
            // 
            this.lblBookQuantitySearchBooksForm.AutoSize = true;
            this.lblBookQuantitySearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookQuantitySearchBooksForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookQuantitySearchBooksForm.Location = new System.Drawing.Point(651, 182);
            this.lblBookQuantitySearchBooksForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookQuantitySearchBooksForm.Name = "lblBookQuantitySearchBooksForm";
            this.lblBookQuantitySearchBooksForm.Size = new System.Drawing.Size(135, 25);
            this.lblBookQuantitySearchBooksForm.TabIndex = 5;
            this.lblBookQuantitySearchBooksForm.Text = "Book Quantity";
            // 
            // txtBookNameSearchBooksForm
            // 
            this.txtBookNameSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookNameSearchBooksForm.Location = new System.Drawing.Point(303, 60);
            this.txtBookNameSearchBooksForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookNameSearchBooksForm.Multiline = true;
            this.txtBookNameSearchBooksForm.Name = "txtBookNameSearchBooksForm";
            this.txtBookNameSearchBooksForm.Size = new System.Drawing.Size(239, 24);
            this.txtBookNameSearchBooksForm.TabIndex = 6;
            // 
            // txtBookAuthorNameSearchBooksForm
            // 
            this.txtBookAuthorNameSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookAuthorNameSearchBooksForm.Location = new System.Drawing.Point(303, 123);
            this.txtBookAuthorNameSearchBooksForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookAuthorNameSearchBooksForm.Multiline = true;
            this.txtBookAuthorNameSearchBooksForm.Name = "txtBookAuthorNameSearchBooksForm";
            this.txtBookAuthorNameSearchBooksForm.Size = new System.Drawing.Size(239, 24);
            this.txtBookAuthorNameSearchBooksForm.TabIndex = 7;
            // 
            // txtBookPublicationSearchBooksForm
            // 
            this.txtBookPublicationSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookPublicationSearchBooksForm.Location = new System.Drawing.Point(303, 182);
            this.txtBookPublicationSearchBooksForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookPublicationSearchBooksForm.Multiline = true;
            this.txtBookPublicationSearchBooksForm.Name = "txtBookPublicationSearchBooksForm";
            this.txtBookPublicationSearchBooksForm.Size = new System.Drawing.Size(239, 24);
            this.txtBookPublicationSearchBooksForm.TabIndex = 8;
            // 
            // txtBookPriceSearchBooksForm
            // 
            this.txtBookPriceSearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookPriceSearchBooksForm.Location = new System.Drawing.Point(929, 126);
            this.txtBookPriceSearchBooksForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookPriceSearchBooksForm.Multiline = true;
            this.txtBookPriceSearchBooksForm.Name = "txtBookPriceSearchBooksForm";
            this.txtBookPriceSearchBooksForm.Size = new System.Drawing.Size(239, 24);
            this.txtBookPriceSearchBooksForm.TabIndex = 9;
            // 
            // txtBookQuantitySearchBooksForm
            // 
            this.txtBookQuantitySearchBooksForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookQuantitySearchBooksForm.Location = new System.Drawing.Point(929, 185);
            this.txtBookQuantitySearchBooksForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookQuantitySearchBooksForm.Multiline = true;
            this.txtBookQuantitySearchBooksForm.Name = "txtBookQuantitySearchBooksForm";
            this.txtBookQuantitySearchBooksForm.Size = new System.Drawing.Size(239, 24);
            this.txtBookQuantitySearchBooksForm.TabIndex = 10;
            // 
            // dtpBookPurchasedDateSearchBooksForm
            // 
            this.dtpBookPurchasedDateSearchBooksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBookPurchasedDateSearchBooksForm.Location = new System.Drawing.Point(929, 59);
            this.dtpBookPurchasedDateSearchBooksForm.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBookPurchasedDateSearchBooksForm.Name = "dtpBookPurchasedDateSearchBooksForm";
            this.dtpBookPurchasedDateSearchBooksForm.Size = new System.Drawing.Size(239, 22);
            this.dtpBookPurchasedDateSearchBooksForm.TabIndex = 11;
            // 
            // btnUpdateSearchBooksForm
            // 
            this.btnUpdateSearchBooksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSearchBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateSearchBooksForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSearchBooksForm.Location = new System.Drawing.Point(739, 263);
            this.btnUpdateSearchBooksForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateSearchBooksForm.Name = "btnUpdateSearchBooksForm";
            this.btnUpdateSearchBooksForm.Size = new System.Drawing.Size(100, 28);
            this.btnUpdateSearchBooksForm.TabIndex = 12;
            this.btnUpdateSearchBooksForm.Text = "Update";
            this.btnUpdateSearchBooksForm.UseVisualStyleBackColor = true;
            this.btnUpdateSearchBooksForm.Click += new System.EventHandler(this.btnUpdateSearchBooksForm_Click);
            // 
            // btnDeleteSearchBooksForm
            // 
            this.btnDeleteSearchBooksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSearchBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteSearchBooksForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSearchBooksForm.Location = new System.Drawing.Point(901, 263);
            this.btnDeleteSearchBooksForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSearchBooksForm.Name = "btnDeleteSearchBooksForm";
            this.btnDeleteSearchBooksForm.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteSearchBooksForm.TabIndex = 13;
            this.btnDeleteSearchBooksForm.Text = "Delete";
            this.btnDeleteSearchBooksForm.UseVisualStyleBackColor = true;
            this.btnDeleteSearchBooksForm.Click += new System.EventHandler(this.btnDeleteSearchBooksForm_Click);
            // 
            // btnCancelSearchBooksForm
            // 
            this.btnCancelSearchBooksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSearchBooksForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelSearchBooksForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSearchBooksForm.Location = new System.Drawing.Point(1069, 263);
            this.btnCancelSearchBooksForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelSearchBooksForm.Name = "btnCancelSearchBooksForm";
            this.btnCancelSearchBooksForm.Size = new System.Drawing.Size(100, 28);
            this.btnCancelSearchBooksForm.TabIndex = 14;
            this.btnCancelSearchBooksForm.Text = "Cancel";
            this.btnCancelSearchBooksForm.UseVisualStyleBackColor = true;
            this.btnCancelSearchBooksForm.Click += new System.EventHandler(this.btnCancelSearchBooksForm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnCancelSearchBooksForm);
            this.panel2.Controls.Add(this.btnDeleteSearchBooksForm);
            this.panel2.Controls.Add(this.btnUpdateSearchBooksForm);
            this.panel2.Controls.Add(this.dtpBookPurchasedDateSearchBooksForm);
            this.panel2.Controls.Add(this.txtBookQuantitySearchBooksForm);
            this.panel2.Controls.Add(this.txtBookPriceSearchBooksForm);
            this.panel2.Controls.Add(this.txtBookPublicationSearchBooksForm);
            this.panel2.Controls.Add(this.txtBookAuthorNameSearchBooksForm);
            this.panel2.Controls.Add(this.txtBookNameSearchBooksForm);
            this.panel2.Controls.Add(this.lblBookQuantitySearchBooksForm);
            this.panel2.Controls.Add(this.lblBookPriceSearchBooksForm);
            this.panel2.Controls.Add(this.lblBookPurchasedDateSearchBooksForm);
            this.panel2.Controls.Add(this.lblBookPublicationSearchBooksForm);
            this.panel2.Controls.Add(this.lblBookAuthorNameSearchBooksForm);
            this.panel2.Controls.Add(this.lblBookNameSearchBooksForm);
            this.panel2.Location = new System.Drawing.Point(24, 610);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 325);
            this.panel2.TabIndex = 5;
            // 
            // btnRefreshSearchBook
            // 
            this.btnRefreshSearchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSearchBook.Location = new System.Drawing.Point(763, 154);
            this.btnRefreshSearchBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshSearchBook.Name = "btnRefreshSearchBook";
            this.btnRefreshSearchBook.Size = new System.Drawing.Size(101, 28);
            this.btnRefreshSearchBook.TabIndex = 8;
            this.btnRefreshSearchBook.Text = "Refresh";
            this.btnRefreshSearchBook.UseVisualStyleBackColor = true;
            this.btnRefreshSearchBook.Click += new System.EventHandler(this.btnRefreshSearchBook_Click);
            // 
            // txtBookNameTopSearchBook
            // 
            this.txtBookNameTopSearchBook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookNameTopSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookNameTopSearchBook.Location = new System.Drawing.Point(541, 158);
            this.txtBookNameTopSearchBook.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookNameTopSearchBook.Multiline = true;
            this.txtBookNameTopSearchBook.Name = "txtBookNameTopSearchBook";
            this.txtBookNameTopSearchBook.Size = new System.Drawing.Size(199, 24);
            this.txtBookNameTopSearchBook.TabIndex = 7;
            this.txtBookNameTopSearchBook.TextChanged += new System.EventHandler(this.txtBookNameTopSearchBook_TextChanged);
            // 
            // lblBookNameTopSearchBooks
            // 
            this.lblBookNameTopSearchBooks.AutoSize = true;
            this.lblBookNameTopSearchBooks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBookNameTopSearchBooks.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNameTopSearchBooks.Location = new System.Drawing.Point(399, 158);
            this.lblBookNameTopSearchBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookNameTopSearchBooks.Name = "lblBookNameTopSearchBooks";
            this.lblBookNameTopSearchBooks.Size = new System.Drawing.Size(129, 29);
            this.lblBookNameTopSearchBooks.TabIndex = 6;
            this.lblBookNameTopSearchBooks.Text = "Book Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1222, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchBooksFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1294, 596);
            this.Controls.Add(this.btnRefreshSearchBook);
            this.Controls.Add(this.txtBookNameTopSearchBook);
            this.Controls.Add(this.lblBookNameTopSearchBooks);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvSearchBooks);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchBooksFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBooksForm";
            this.Load += new System.EventHandler(this.SearchBooksForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBooks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSearchBooks;
        private System.Windows.Forms.Label lblBookNameSearchBooksForm;
        private System.Windows.Forms.Label lblBookAuthorNameSearchBooksForm;
        private System.Windows.Forms.Label lblBookPublicationSearchBooksForm;
        private System.Windows.Forms.Label lblBookPurchasedDateSearchBooksForm;
        private System.Windows.Forms.Label lblBookPriceSearchBooksForm;
        private System.Windows.Forms.Label lblBookQuantitySearchBooksForm;
        private System.Windows.Forms.TextBox txtBookNameSearchBooksForm;
        private System.Windows.Forms.TextBox txtBookAuthorNameSearchBooksForm;
        private System.Windows.Forms.TextBox txtBookPublicationSearchBooksForm;
        private System.Windows.Forms.TextBox txtBookPriceSearchBooksForm;
        private System.Windows.Forms.TextBox txtBookQuantitySearchBooksForm;
        private System.Windows.Forms.DateTimePicker dtpBookPurchasedDateSearchBooksForm;
        private System.Windows.Forms.Button btnUpdateSearchBooksForm;
        private System.Windows.Forms.Button btnDeleteSearchBooksForm;
        private System.Windows.Forms.Button btnCancelSearchBooksForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefreshSearchBook;
        private System.Windows.Forms.TextBox txtBookNameTopSearchBook;
        private System.Windows.Forms.Label lblBookNameTopSearchBooks;
        private System.Windows.Forms.Button button1;
    }
}