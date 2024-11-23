namespace GradeTracker
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.AdminTopLabel = new System.Windows.Forms.Label();
            this.ManageUsersBtn = new System.Windows.Forms.Button();
            this.ManageCoursesBtn = new System.Windows.Forms.Button();
            this.gTLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeTrackerDataSet = new GradeTracker.GradeTrackerDataSet();
            this.gTLoginTableAdapter = new GradeTracker.GradeTrackerDataSetTableAdapters.GTLoginTableAdapter();
            this.DoneEditingBtn = new System.Windows.Forms.Button();
            this.gTLoginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gradeTrackerDataSet1 = new GradeTracker.GradeTrackerDataSet1();
            this.gTLoginBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gTLoginTableAdapter1 = new GradeTracker.GradeTrackerDataSet1TableAdapters.GTLoginTableAdapter();
            this.gradeTrackerDataSet2 = new GradeTracker.GradeTrackerDataSet2();
            this.gTLoginBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gTLoginTableAdapter2 = new GradeTracker.GradeTrackerDataSet2TableAdapters.GTLoginTableAdapter();
            this.DataGridAllUsers = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isArchivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseGridview = new System.Windows.Forms.DataGridView();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorIDAssignedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catologOfCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeTrackerCoursesDataSet = new GradeTracker.GradeTrackerCoursesDataSet();
            this.catologOfCoursesTableAdapter = new GradeTracker.GradeTrackerCoursesDataSetTableAdapters.CatologOfCoursesTableAdapter();
            this.Enrollbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gTLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTLoginBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTLoginBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTLoginBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAllUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catologOfCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerCoursesDataSet)).BeginInit();

            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.AdminTopLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";

            this.panel1.Size = new System.Drawing.Size(1943, 97);
            this.panel1.TabIndex = 7;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.LightCoral;
            this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogoutButton.Location = new System.Drawing.Point(1828, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(115, 97);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 

            // AdminTopLabel
            // 
            this.AdminTopLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AdminTopLabel.AutoSize = true;
            this.AdminTopLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.AdminTopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminTopLabel.Font = new System.Drawing.Font("Arial Black", 28.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.AdminTopLabel.Location = new System.Drawing.Point(580, -11);

            this.AdminTopLabel.Name = "AdminTopLabel";
            this.AdminTopLabel.Size = new System.Drawing.Size(769, 108);
            this.AdminTopLabel.TabIndex = 5;
            this.AdminTopLabel.Text = "Admin Dashboard";
            this.AdminTopLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 

            // ManageUsersBtn
            // 
            this.ManageUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUsersBtn.Location = new System.Drawing.Point(85, 244);

            this.ManageUsersBtn.Name = "ManageUsersBtn";
            this.ManageUsersBtn.Size = new System.Drawing.Size(393, 224);
            this.ManageUsersBtn.TabIndex = 8;
            this.ManageUsersBtn.Text = "Manage Users";
            this.ManageUsersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageUsersBtn.UseVisualStyleBackColor = true;
            this.ManageUsersBtn.Click += new System.EventHandler(this.ManageUsersBtn_Click);
            // 
            // ManageCoursesBtn
            // 
            this.ManageCoursesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.ManageCoursesBtn.Location = new System.Drawing.Point(594, 244);

            this.ManageCoursesBtn.Name = "ManageCoursesBtn";
            this.ManageCoursesBtn.Size = new System.Drawing.Size(463, 224);
            this.ManageCoursesBtn.TabIndex = 9;
            this.ManageCoursesBtn.Text = "Manage Courses";
            this.ManageCoursesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageCoursesBtn.UseVisualStyleBackColor = true;
            this.ManageCoursesBtn.Click += new System.EventHandler(this.ManageCoursesBtn_Click);
            //
            // gTLoginBindingSource
            // 
            this.gTLoginBindingSource.DataMember = "GTLogin";
            this.gTLoginBindingSource.DataSource = this.gradeTrackerDataSet;
            // 
            // gradeTrackerDataSet
            // 
            this.gradeTrackerDataSet.DataSetName = "GradeTrackerDataSet";
            this.gradeTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gTLoginTableAdapter
            // 
            this.gTLoginTableAdapter.ClearBeforeFill = true;
            // 
            // DoneEditingBtn
            // 
            this.DoneEditingBtn.BackColor = System.Drawing.Color.LightCoral;
            this.DoneEditingBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DoneEditingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneEditingBtn.Location = new System.Drawing.Point(0, 686);
            this.DoneEditingBtn.Name = "DoneEditingBtn";
            this.DoneEditingBtn.Size = new System.Drawing.Size(1943, 73);
            this.DoneEditingBtn.TabIndex = 12;
            this.DoneEditingBtn.Text = "Done Editing";
            this.DoneEditingBtn.UseVisualStyleBackColor = false;
            this.DoneEditingBtn.Click += new System.EventHandler(this.DoneEditingBtn_Click);
            // 
            // gTLoginBindingSource1
            // 
            this.gTLoginBindingSource1.DataMember = "GTLogin";
            this.gTLoginBindingSource1.DataSource = this.gradeTrackerDataSet;
            // 
            // gradeTrackerDataSet1
            // 
            this.gradeTrackerDataSet1.DataSetName = "GradeTrackerDataSet1";
            this.gradeTrackerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gTLoginBindingSource2
            // 
            this.gTLoginBindingSource2.DataMember = "GTLogin";
            this.gTLoginBindingSource2.DataSource = this.gradeTrackerDataSet1;
            // 
            // gTLoginTableAdapter1
            // 
            this.gTLoginTableAdapter1.ClearBeforeFill = true;
            // 
            // gradeTrackerDataSet2
            // 
            this.gradeTrackerDataSet2.DataSetName = "GradeTrackerDataSet2";
            this.gradeTrackerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gTLoginBindingSource3
            // 
            this.gTLoginBindingSource3.DataMember = "GTLogin";
            this.gTLoginBindingSource3.DataSource = this.gradeTrackerDataSet2;
            // 
            // gTLoginTableAdapter2
            // 
            this.gTLoginTableAdapter2.ClearBeforeFill = true;
            // 
            // DataGridAllUsers
            // 
            this.DataGridAllUsers.AllowUserToOrderColumns = true;
            this.DataGridAllUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridAllUsers.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAllUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.isArchivedDataGridViewCheckBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.DataGridAllUsers.DataSource = this.gTLoginBindingSource3;
            this.DataGridAllUsers.Location = new System.Drawing.Point(0, 89);
            this.DataGridAllUsers.Name = "DataGridAllUsers";
            this.DataGridAllUsers.RowHeadersWidth = 82;
            this.DataGridAllUsers.RowTemplate.Height = 33;
            this.DataGridAllUsers.Size = new System.Drawing.Size(1943, 605);
            this.DataGridAllUsers.TabIndex = 13;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "user_ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "user_ID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "userType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "userType";
            this.userTypeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // isArchivedDataGridViewCheckBoxColumn
            // 
            this.isArchivedDataGridViewCheckBoxColumn.DataPropertyName = "isArchived";
            this.isArchivedDataGridViewCheckBoxColumn.HeaderText = "isArchived";
            this.isArchivedDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.isArchivedDataGridViewCheckBoxColumn.Name = "isArchivedDataGridViewCheckBoxColumn";
            this.isArchivedDataGridViewCheckBoxColumn.Width = 200;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // CourseGridview
            // 
            this.CourseGridview.AllowUserToOrderColumns = true;
            this.CourseGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseGridview.AutoGenerateColumns = false;
            this.CourseGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseNameDataGridViewTextBoxColumn,
            this.prefixDataGridViewTextBoxColumn,
            this.courseNumberDataGridViewTextBoxColumn,
            this.professorIDAssignedDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn});
            this.CourseGridview.DataSource = this.catologOfCoursesBindingSource;
            this.CourseGridview.Location = new System.Drawing.Point(0, 89);
            this.CourseGridview.Name = "CourseGridview";
            this.CourseGridview.RowHeadersWidth = 82;
            this.CourseGridview.RowTemplate.Height = 33;
            this.CourseGridview.Size = new System.Drawing.Size(1713, 605);
            this.CourseGridview.TabIndex = 14;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // prefixDataGridViewTextBoxColumn
            // 
            this.prefixDataGridViewTextBoxColumn.DataPropertyName = "Prefix";
            this.prefixDataGridViewTextBoxColumn.HeaderText = "Prefix";
            this.prefixDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.prefixDataGridViewTextBoxColumn.Name = "prefixDataGridViewTextBoxColumn";
            this.prefixDataGridViewTextBoxColumn.Width = 200;
            // 
            // courseNumberDataGridViewTextBoxColumn
            // 
            this.courseNumberDataGridViewTextBoxColumn.DataPropertyName = "CourseNumber";
            this.courseNumberDataGridViewTextBoxColumn.HeaderText = "CourseNumber";
            this.courseNumberDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.courseNumberDataGridViewTextBoxColumn.Name = "courseNumberDataGridViewTextBoxColumn";
            this.courseNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // professorIDAssignedDataGridViewTextBoxColumn
            // 
            this.professorIDAssignedDataGridViewTextBoxColumn.DataPropertyName = "ProfessorIDAssigned";
            this.professorIDAssignedDataGridViewTextBoxColumn.HeaderText = "ProfessorIDAssigned";
            this.professorIDAssignedDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.professorIDAssignedDataGridViewTextBoxColumn.Name = "professorIDAssignedDataGridViewTextBoxColumn";
            this.professorIDAssignedDataGridViewTextBoxColumn.Width = 200;
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Term";
            this.termDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.Width = 200;
            // 
            // catologOfCoursesBindingSource
            // 
            this.catologOfCoursesBindingSource.DataMember = "CatologOfCourses";
            this.catologOfCoursesBindingSource.DataSource = this.gradeTrackerCoursesDataSet;
            // 
            // gradeTrackerCoursesDataSet
            // 
            this.gradeTrackerCoursesDataSet.DataSetName = "GradeTrackerCoursesDataSet";
            this.gradeTrackerCoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catologOfCoursesTableAdapter
            // 
            this.catologOfCoursesTableAdapter.ClearBeforeFill = true;
            // 
            // Enrollbtn
            // 
            this.Enrollbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enrollbtn.Location = new System.Drawing.Point(1199, 244);
            this.Enrollbtn.Name = "Enrollbtn";
            this.Enrollbtn.Size = new System.Drawing.Size(463, 224);
            this.Enrollbtn.TabIndex = 15;
            this.Enrollbtn.Text = "Enroll Student into a Class";
            this.Enrollbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Enrollbtn.UseVisualStyleBackColor = true;
            this.Enrollbtn.Click += new System.EventHandler(this.EnrollStudentBtn);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1943, 759);
            this.Controls.Add(this.DoneEditingBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CourseGridview);
            this.Controls.Add(this.DataGridAllUsers);
            this.Controls.Add(this.Enrollbtn);
            this.Controls.Add(this.ManageCoursesBtn);
            this.Controls.Add(this.ManageUsersBtn);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gTLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTLoginBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTLoginBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTLoginBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAllUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catologOfCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerCoursesDataSet)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AdminTopLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ManageUsersBtn;
        private System.Windows.Forms.Button ManageCoursesBtn;
        private GradeTrackerDataSet gradeTrackerDataSet;
        private System.Windows.Forms.BindingSource gTLoginBindingSource;
        private GradeTrackerDataSetTableAdapters.GTLoginTableAdapter gTLoginTableAdapter;
        private System.Windows.Forms.Button DoneEditingBtn;
        private System.Windows.Forms.BindingSource gTLoginBindingSource1;
        private GradeTrackerDataSet1 gradeTrackerDataSet1;
        private System.Windows.Forms.BindingSource gTLoginBindingSource2;
        private GradeTrackerDataSet1TableAdapters.GTLoginTableAdapter gTLoginTableAdapter1;
        private GradeTrackerDataSet2 gradeTrackerDataSet2;
        private System.Windows.Forms.BindingSource gTLoginBindingSource3;
        private GradeTrackerDataSet2TableAdapters.GTLoginTableAdapter gTLoginTableAdapter2;
        private System.Windows.Forms.DataGridView DataGridAllUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isArchivedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView CourseGridview;
        private GradeTrackerCoursesDataSet gradeTrackerCoursesDataSet;
        private System.Windows.Forms.BindingSource catologOfCoursesBindingSource;
        private GradeTrackerCoursesDataSetTableAdapters.CatologOfCoursesTableAdapter catologOfCoursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorIDAssignedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Enrollbtn;

    }
}