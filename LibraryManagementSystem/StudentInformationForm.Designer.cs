
namespace LibraryManagementSystem
{
    partial class StudentInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInformationForm));
            this.dgvStudentInformation = new System.Windows.Forms.DataGridView();
            this.btnRefreshStudentInformation = new System.Windows.Forms.Button();
            this.txtIdTopStudentInformation = new System.Windows.Forms.TextBox();
            this.lblIdTopStudentInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtStudentMobileNumberStudentInformationForm = new System.Windows.Forms.TextBox();
            this.txtStudentSemesterStudentInformationForm = new System.Windows.Forms.TextBox();
            this.txtStudentDepartmentStudentInformationForm = new System.Windows.Forms.TextBox();
            this.txtStudentEmailStudentInformationForm = new System.Windows.Forms.TextBox();
            this.txtStudentIdStudentInformationForm = new System.Windows.Forms.TextBox();
            this.txtStudentNameStudentInformationForm = new System.Windows.Forms.TextBox();
            this.lblStudentMobileNumberStudentInformationForm = new System.Windows.Forms.Label();
            this.lblStudentSemesterStudentInformationForm = new System.Windows.Forms.Label();
            this.lblStudentDepartmentStudentInformationForm = new System.Windows.Forms.Label();
            this.lblStudentEmailStudentInformationForm = new System.Windows.Forms.Label();
            this.lblStudentIdStudentInformationForm = new System.Windows.Forms.Label();
            this.lblStudentNameStudentInformationForm = new System.Windows.Forms.Label();
            this.btnCancelStudentInformationForm = new System.Windows.Forms.Button();
            this.btnDeleteStudentInformationForm = new System.Windows.Forms.Button();
            this.btnUpdateStudentInformationForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInformation)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudentInformation
            // 
            this.dgvStudentInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInformation.Location = new System.Drawing.Point(27, 181);
            this.dgvStudentInformation.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudentInformation.Name = "dgvStudentInformation";
            this.dgvStudentInformation.RowHeadersWidth = 51;
            this.dgvStudentInformation.Size = new System.Drawing.Size(1261, 383);
            this.dgvStudentInformation.TabIndex = 9;
            this.dgvStudentInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnRefreshStudentInformation
            // 
            this.btnRefreshStudentInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshStudentInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshStudentInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshStudentInformation.Location = new System.Drawing.Point(756, 140);
            this.btnRefreshStudentInformation.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshStudentInformation.Name = "btnRefreshStudentInformation";
            this.btnRefreshStudentInformation.Size = new System.Drawing.Size(101, 28);
            this.btnRefreshStudentInformation.TabIndex = 8;
            this.btnRefreshStudentInformation.Text = "Refresh";
            this.btnRefreshStudentInformation.UseVisualStyleBackColor = true;
            this.btnRefreshStudentInformation.Click += new System.EventHandler(this.btnRefreshStudentInformation_Click);
            // 
            // txtIdTopStudentInformation
            // 
            this.txtIdTopStudentInformation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdTopStudentInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTopStudentInformation.Location = new System.Drawing.Point(535, 144);
            this.txtIdTopStudentInformation.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdTopStudentInformation.Multiline = true;
            this.txtIdTopStudentInformation.Name = "txtIdTopStudentInformation";
            this.txtIdTopStudentInformation.Size = new System.Drawing.Size(199, 24);
            this.txtIdTopStudentInformation.TabIndex = 7;
            this.txtIdTopStudentInformation.TextChanged += new System.EventHandler(this.txtIdTopStudentInformation_TextChanged);
            // 
            // lblIdTopStudentInfo
            // 
            this.lblIdTopStudentInfo.AutoSize = true;
            this.lblIdTopStudentInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblIdTopStudentInfo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTopStudentInfo.Location = new System.Drawing.Point(476, 144);
            this.lblIdTopStudentInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdTopStudentInfo.Name = "lblIdTopStudentInfo";
            this.lblIdTopStudentInfo.Size = new System.Drawing.Size(32, 29);
            this.lblIdTopStudentInfo.TabIndex = 6;
            this.lblIdTopStudentInfo.Text = "Id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 139);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(428, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.txtStudentMobileNumberStudentInformationForm);
            this.panel2.Controls.Add(this.txtStudentSemesterStudentInformationForm);
            this.panel2.Controls.Add(this.txtStudentDepartmentStudentInformationForm);
            this.panel2.Controls.Add(this.txtStudentEmailStudentInformationForm);
            this.panel2.Controls.Add(this.txtStudentIdStudentInformationForm);
            this.panel2.Controls.Add(this.txtStudentNameStudentInformationForm);
            this.panel2.Controls.Add(this.lblStudentMobileNumberStudentInformationForm);
            this.panel2.Controls.Add(this.lblStudentSemesterStudentInformationForm);
            this.panel2.Controls.Add(this.lblStudentDepartmentStudentInformationForm);
            this.panel2.Controls.Add(this.lblStudentEmailStudentInformationForm);
            this.panel2.Controls.Add(this.lblStudentIdStudentInformationForm);
            this.panel2.Controls.Add(this.lblStudentNameStudentInformationForm);
            this.panel2.Controls.Add(this.btnCancelStudentInformationForm);
            this.panel2.Controls.Add(this.btnDeleteStudentInformationForm);
            this.panel2.Controls.Add(this.btnUpdateStudentInformationForm);
            this.panel2.Location = new System.Drawing.Point(27, 591);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 327);
            this.panel2.TabIndex = 10;
            // 
            // txtStudentMobileNumberStudentInformationForm
            // 
            this.txtStudentMobileNumberStudentInformationForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentMobileNumberStudentInformationForm.Location = new System.Drawing.Point(875, 176);
            this.txtStudentMobileNumberStudentInformationForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentMobileNumberStudentInformationForm.Multiline = true;
            this.txtStudentMobileNumberStudentInformationForm.Name = "txtStudentMobileNumberStudentInformationForm";
            this.txtStudentMobileNumberStudentInformationForm.Size = new System.Drawing.Size(255, 24);
            this.txtStudentMobileNumberStudentInformationForm.TabIndex = 41;
            // 
            // txtStudentSemesterStudentInformationForm
            // 
            this.txtStudentSemesterStudentInformationForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentSemesterStudentInformationForm.Location = new System.Drawing.Point(875, 117);
            this.txtStudentSemesterStudentInformationForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentSemesterStudentInformationForm.Multiline = true;
            this.txtStudentSemesterStudentInformationForm.Name = "txtStudentSemesterStudentInformationForm";
            this.txtStudentSemesterStudentInformationForm.Size = new System.Drawing.Size(255, 24);
            this.txtStudentSemesterStudentInformationForm.TabIndex = 40;
            // 
            // txtStudentDepartmentStudentInformationForm
            // 
            this.txtStudentDepartmentStudentInformationForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentDepartmentStudentInformationForm.Location = new System.Drawing.Point(875, 54);
            this.txtStudentDepartmentStudentInformationForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentDepartmentStudentInformationForm.Multiline = true;
            this.txtStudentDepartmentStudentInformationForm.Name = "txtStudentDepartmentStudentInformationForm";
            this.txtStudentDepartmentStudentInformationForm.Size = new System.Drawing.Size(255, 24);
            this.txtStudentDepartmentStudentInformationForm.TabIndex = 39;
            // 
            // txtStudentEmailStudentInformationForm
            // 
            this.txtStudentEmailStudentInformationForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentEmailStudentInformationForm.Location = new System.Drawing.Point(283, 178);
            this.txtStudentEmailStudentInformationForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentEmailStudentInformationForm.Multiline = true;
            this.txtStudentEmailStudentInformationForm.Name = "txtStudentEmailStudentInformationForm";
            this.txtStudentEmailStudentInformationForm.Size = new System.Drawing.Size(255, 24);
            this.txtStudentEmailStudentInformationForm.TabIndex = 38;
            // 
            // txtStudentIdStudentInformationForm
            // 
            this.txtStudentIdStudentInformationForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentIdStudentInformationForm.Location = new System.Drawing.Point(283, 117);
            this.txtStudentIdStudentInformationForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentIdStudentInformationForm.Multiline = true;
            this.txtStudentIdStudentInformationForm.Name = "txtStudentIdStudentInformationForm";
            this.txtStudentIdStudentInformationForm.Size = new System.Drawing.Size(255, 24);
            this.txtStudentIdStudentInformationForm.TabIndex = 37;
            // 
            // txtStudentNameStudentInformationForm
            // 
            this.txtStudentNameStudentInformationForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentNameStudentInformationForm.Location = new System.Drawing.Point(283, 52);
            this.txtStudentNameStudentInformationForm.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentNameStudentInformationForm.Multiline = true;
            this.txtStudentNameStudentInformationForm.Name = "txtStudentNameStudentInformationForm";
            this.txtStudentNameStudentInformationForm.Size = new System.Drawing.Size(255, 24);
            this.txtStudentNameStudentInformationForm.TabIndex = 36;
            // 
            // lblStudentMobileNumberStudentInformationForm
            // 
            this.lblStudentMobileNumberStudentInformationForm.AutoSize = true;
            this.lblStudentMobileNumberStudentInformationForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentMobileNumberStudentInformationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentMobileNumberStudentInformationForm.Location = new System.Drawing.Point(632, 176);
            this.lblStudentMobileNumberStudentInformationForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentMobileNumberStudentInformationForm.Name = "lblStudentMobileNumberStudentInformationForm";
            this.lblStudentMobileNumberStudentInformationForm.Size = new System.Drawing.Size(217, 25);
            this.lblStudentMobileNumberStudentInformationForm.TabIndex = 35;
            this.lblStudentMobileNumberStudentInformationForm.Text = "Student Mobile Number";
            // 
            // lblStudentSemesterStudentInformationForm
            // 
            this.lblStudentSemesterStudentInformationForm.AutoSize = true;
            this.lblStudentSemesterStudentInformationForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentSemesterStudentInformationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSemesterStudentInformationForm.Location = new System.Drawing.Point(632, 117);
            this.lblStudentSemesterStudentInformationForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentSemesterStudentInformationForm.Name = "lblStudentSemesterStudentInformationForm";
            this.lblStudentSemesterStudentInformationForm.Size = new System.Drawing.Size(169, 25);
            this.lblStudentSemesterStudentInformationForm.TabIndex = 34;
            this.lblStudentSemesterStudentInformationForm.Text = "Student Semester";
            // 
            // lblStudentDepartmentStudentInformationForm
            // 
            this.lblStudentDepartmentStudentInformationForm.AutoSize = true;
            this.lblStudentDepartmentStudentInformationForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentDepartmentStudentInformationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDepartmentStudentInformationForm.Location = new System.Drawing.Point(632, 54);
            this.lblStudentDepartmentStudentInformationForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentDepartmentStudentInformationForm.Name = "lblStudentDepartmentStudentInformationForm";
            this.lblStudentDepartmentStudentInformationForm.Size = new System.Drawing.Size(186, 25);
            this.lblStudentDepartmentStudentInformationForm.TabIndex = 33;
            this.lblStudentDepartmentStudentInformationForm.Text = "Student Department";
            // 
            // lblStudentEmailStudentInformationForm
            // 
            this.lblStudentEmailStudentInformationForm.AutoSize = true;
            this.lblStudentEmailStudentInformationForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentEmailStudentInformationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentEmailStudentInformationForm.Location = new System.Drawing.Point(125, 176);
            this.lblStudentEmailStudentInformationForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentEmailStudentInformationForm.Name = "lblStudentEmailStudentInformationForm";
            this.lblStudentEmailStudentInformationForm.Size = new System.Drawing.Size(133, 25);
            this.lblStudentEmailStudentInformationForm.TabIndex = 32;
            this.lblStudentEmailStudentInformationForm.Text = "Student Email";
            // 
            // lblStudentIdStudentInformationForm
            // 
            this.lblStudentIdStudentInformationForm.AutoSize = true;
            this.lblStudentIdStudentInformationForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentIdStudentInformationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentIdStudentInformationForm.Location = new System.Drawing.Point(125, 117);
            this.lblStudentIdStudentInformationForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentIdStudentInformationForm.Name = "lblStudentIdStudentInformationForm";
            this.lblStudentIdStudentInformationForm.Size = new System.Drawing.Size(101, 25);
            this.lblStudentIdStudentInformationForm.TabIndex = 31;
            this.lblStudentIdStudentInformationForm.Text = "Student Id";
            // 
            // lblStudentNameStudentInformationForm
            // 
            this.lblStudentNameStudentInformationForm.AutoSize = true;
            this.lblStudentNameStudentInformationForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblStudentNameStudentInformationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNameStudentInformationForm.Location = new System.Drawing.Point(125, 52);
            this.lblStudentNameStudentInformationForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentNameStudentInformationForm.Name = "lblStudentNameStudentInformationForm";
            this.lblStudentNameStudentInformationForm.Size = new System.Drawing.Size(137, 25);
            this.lblStudentNameStudentInformationForm.TabIndex = 30;
            this.lblStudentNameStudentInformationForm.Text = "Student Name";
            // 
            // btnCancelStudentInformationForm
            // 
            this.btnCancelStudentInformationForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelStudentInformationForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelStudentInformationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelStudentInformationForm.Location = new System.Drawing.Point(1068, 252);
            this.btnCancelStudentInformationForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelStudentInformationForm.Name = "btnCancelStudentInformationForm";
            this.btnCancelStudentInformationForm.Size = new System.Drawing.Size(100, 28);
            this.btnCancelStudentInformationForm.TabIndex = 29;
            this.btnCancelStudentInformationForm.Text = "Cancel";
            this.btnCancelStudentInformationForm.UseVisualStyleBackColor = true;
            this.btnCancelStudentInformationForm.Click += new System.EventHandler(this.btnCancelStudentInformationForm_Click);
            // 
            // btnDeleteStudentInformationForm
            // 
            this.btnDeleteStudentInformationForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStudentInformationForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteStudentInformationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudentInformationForm.Location = new System.Drawing.Point(900, 252);
            this.btnDeleteStudentInformationForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteStudentInformationForm.Name = "btnDeleteStudentInformationForm";
            this.btnDeleteStudentInformationForm.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteStudentInformationForm.TabIndex = 28;
            this.btnDeleteStudentInformationForm.Text = "Delete";
            this.btnDeleteStudentInformationForm.UseVisualStyleBackColor = true;
            this.btnDeleteStudentInformationForm.Click += new System.EventHandler(this.btnDeleteStudentInformationForm_Click);
            // 
            // btnUpdateStudentInformationForm
            // 
            this.btnUpdateStudentInformationForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStudentInformationForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateStudentInformationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudentInformationForm.Location = new System.Drawing.Point(737, 252);
            this.btnUpdateStudentInformationForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateStudentInformationForm.Name = "btnUpdateStudentInformationForm";
            this.btnUpdateStudentInformationForm.Size = new System.Drawing.Size(100, 28);
            this.btnUpdateStudentInformationForm.TabIndex = 27;
            this.btnUpdateStudentInformationForm.Text = "Update";
            this.btnUpdateStudentInformationForm.UseVisualStyleBackColor = true;
            this.btnUpdateStudentInformationForm.Click += new System.EventHandler(this.btnUpdateStudentInformationForm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1219, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1294, 572);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvStudentInformation);
            this.Controls.Add(this.btnRefreshStudentInformation);
            this.Controls.Add(this.txtIdTopStudentInformation);
            this.Controls.Add(this.lblIdTopStudentInfo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentInformationForm";
            this.Load += new System.EventHandler(this.StudentInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInformation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentInformation;
        private System.Windows.Forms.Button btnRefreshStudentInformation;
        private System.Windows.Forms.TextBox txtIdTopStudentInformation;
        private System.Windows.Forms.Label lblIdTopStudentInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelStudentInformationForm;
        private System.Windows.Forms.Button btnDeleteStudentInformationForm;
        private System.Windows.Forms.Button btnUpdateStudentInformationForm;
        private System.Windows.Forms.Label lblStudentEmailStudentInformationForm;
        private System.Windows.Forms.Label lblStudentIdStudentInformationForm;
        private System.Windows.Forms.Label lblStudentNameStudentInformationForm;
        private System.Windows.Forms.Label lblStudentMobileNumberStudentInformationForm;
        private System.Windows.Forms.Label lblStudentSemesterStudentInformationForm;
        private System.Windows.Forms.Label lblStudentDepartmentStudentInformationForm;
        private System.Windows.Forms.TextBox txtStudentEmailStudentInformationForm;
        private System.Windows.Forms.TextBox txtStudentIdStudentInformationForm;
        private System.Windows.Forms.TextBox txtStudentNameStudentInformationForm;
        private System.Windows.Forms.TextBox txtStudentMobileNumberStudentInformationForm;
        private System.Windows.Forms.TextBox txtStudentSemesterStudentInformationForm;
        private System.Windows.Forms.TextBox txtStudentDepartmentStudentInformationForm;
        private System.Windows.Forms.Button button1;
    }
}