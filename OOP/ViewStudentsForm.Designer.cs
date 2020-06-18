namespace OOP
{
    partial class ViewStudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentsForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvViewStudents = new System.Windows.Forms.DataGridView();
            this.panelUpdateStudents = new System.Windows.Forms.Panel();
            this.tbStudentNameUpdate = new System.Windows.Forms.TextBox();
            this.cbGenderUpdate = new System.Windows.Forms.ComboBox();
            this.tbStudentClassUpdate = new System.Windows.Forms.TextBox();
            this.dtpBirthdateUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSearchStudents = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnX = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).BeginInit();
            this.panelUpdateStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvViewStudents
            // 
            this.dgvViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStudents.Location = new System.Drawing.Point(12, 213);
            this.dgvViewStudents.Name = "dgvViewStudents";
            this.dgvViewStudents.Size = new System.Drawing.Size(876, 303);
            this.dgvViewStudents.TabIndex = 1;
            this.dgvViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewStudents_CellClick);
            // 
            // panelUpdateStudents
            // 
            this.panelUpdateStudents.BackColor = System.Drawing.Color.Aqua;
            this.panelUpdateStudents.Controls.Add(this.tbStudentNameUpdate);
            this.panelUpdateStudents.Controls.Add(this.cbGenderUpdate);
            this.panelUpdateStudents.Controls.Add(this.tbStudentClassUpdate);
            this.panelUpdateStudents.Controls.Add(this.dtpBirthdateUpdate);
            this.panelUpdateStudents.Controls.Add(this.btnCancel);
            this.panelUpdateStudents.Controls.Add(this.btnDelete);
            this.panelUpdateStudents.Controls.Add(this.btnUpdate);
            this.panelUpdateStudents.Controls.Add(this.label4);
            this.panelUpdateStudents.Controls.Add(this.label3);
            this.panelUpdateStudents.Controls.Add(this.label2);
            this.panelUpdateStudents.Controls.Add(this.label1);
            this.panelUpdateStudents.Location = new System.Drawing.Point(13, 568);
            this.panelUpdateStudents.Name = "panelUpdateStudents";
            this.panelUpdateStudents.Size = new System.Drawing.Size(875, 285);
            this.panelUpdateStudents.TabIndex = 2;
            // 
            // tbStudentNameUpdate
            // 
            this.tbStudentNameUpdate.Location = new System.Drawing.Point(197, 44);
            this.tbStudentNameUpdate.Name = "tbStudentNameUpdate";
            this.tbStudentNameUpdate.Size = new System.Drawing.Size(205, 20);
            this.tbStudentNameUpdate.TabIndex = 26;
            // 
            // cbGenderUpdate
            // 
            this.cbGenderUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenderUpdate.FormattingEnabled = true;
            this.cbGenderUpdate.Location = new System.Drawing.Point(605, 43);
            this.cbGenderUpdate.Name = "cbGenderUpdate";
            this.cbGenderUpdate.Size = new System.Drawing.Size(205, 21);
            this.cbGenderUpdate.TabIndex = 25;
            // 
            // tbStudentClassUpdate
            // 
            this.tbStudentClassUpdate.Location = new System.Drawing.Point(605, 117);
            this.tbStudentClassUpdate.Name = "tbStudentClassUpdate";
            this.tbStudentClassUpdate.Size = new System.Drawing.Size(205, 20);
            this.tbStudentClassUpdate.TabIndex = 24;
            // 
            // dtpBirthdateUpdate
            // 
            this.dtpBirthdateUpdate.Location = new System.Drawing.Point(199, 118);
            this.dtpBirthdateUpdate.Name = "dtpBirthdateUpdate";
            this.dtpBirthdateUpdate.Size = new System.Drawing.Size(205, 20);
            this.dtpBirthdateUpdate.TabIndex = 23;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(626, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 46);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Chartreuse;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(388, 203);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 46);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Chartreuse;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.Location = new System.Drawing.Point(152, 203);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 46);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(446, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Student Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(446, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Student Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Student Birthdate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Student Name ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(198, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Student Name:";
            // 
            // tbSearchStudents
            // 
            this.tbSearchStudents.Location = new System.Drawing.Point(342, 169);
            this.tbSearchStudents.Name = "tbSearchStudents";
            this.tbSearchStudents.Size = new System.Drawing.Size(219, 20);
            this.tbSearchStudents.TabIndex = 8;
            this.tbSearchStudents.TextChanged += new System.EventHandler(this.tbSearchStudents_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRefresh.Location = new System.Drawing.Point(578, 162);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 27);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(318, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btnX
            // 
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnX.ForeColor = System.Drawing.Color.Red;
            this.btnX.Location = new System.Drawing.Point(869, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(31, 32);
            this.btnX.TabIndex = 14;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(499, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "View Students";
            // 
            // ViewStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(900, 864);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbSearchStudents);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelUpdateStudents);
            this.Controls.Add(this.dgvViewStudents);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStudentsForm";
            this.Load += new System.EventHandler(this.ViewStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).EndInit();
            this.panelUpdateStudents.ResumeLayout(false);
            this.panelUpdateStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvViewStudents;
        private System.Windows.Forms.Panel panelUpdateStudents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSearchStudents;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStudentClassUpdate;
        private System.Windows.Forms.DateTimePicker dtpBirthdateUpdate;
        private System.Windows.Forms.ComboBox cbGenderUpdate;
        private System.Windows.Forms.TextBox tbStudentNameUpdate;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label5;
    }
}