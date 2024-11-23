namespace GradeTracker
{
    partial class EnrollToCourseForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminTopLabel = new System.Windows.Forms.Label();
            this.CourseList = new System.Windows.Forms.ListBox();
            this.catologOfCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeTrackerDataSet3 = new GradeTracker.GradeTrackerDataSet3();
            this.catologOfCoursesTableAdapter = new GradeTracker.GradeTrackerDataSet3TableAdapters.CatologOfCoursesTableAdapter();
            this.StudentList = new System.Windows.Forms.ListBox();
            this.gTLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeTrackerDataSet5 = new GradeTracker.GradeTrackerDataSet5();
            this.gradeTrackerDataSet4 = new GradeTracker.GradeTrackerDataSet4();
            this.gTLoginTableAdapter = new GradeTracker.GradeTrackerDataSet4TableAdapters.GTLoginTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gTLoginTableAdapter1 = new GradeTracker.GradeTrackerDataSet5TableAdapters.GTLoginTableAdapter();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catologOfCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerDataSet4)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1975, 97);
            this.panel1.TabIndex = 8;
            // 
            // AdminTopLabel
            // 
            this.AdminTopLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AdminTopLabel.AutoSize = true;
            this.AdminTopLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(15)))), ((int)(((byte)(45)))));
            this.AdminTopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminTopLabel.Font = new System.Drawing.Font("Arial Black", 28.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminTopLabel.Location = new System.Drawing.Point(596, -11);
            this.AdminTopLabel.Name = "AdminTopLabel";
            this.AdminTopLabel.Size = new System.Drawing.Size(769, 108);
            this.AdminTopLabel.TabIndex = 5;
            this.AdminTopLabel.Text = "Admin Dashboard";
            this.AdminTopLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CourseList
            // 
            this.CourseList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.catologOfCoursesBindingSource, "CourseNumber", true));
            this.CourseList.DataSource = this.catologOfCoursesBindingSource;
            this.CourseList.DisplayMember = "CourseName";
            this.CourseList.FormattingEnabled = true;
            this.CourseList.ItemHeight = 25;
            this.CourseList.Location = new System.Drawing.Point(606, 270);
            this.CourseList.Name = "CourseList";
            this.CourseList.Size = new System.Drawing.Size(856, 454);
            this.CourseList.TabIndex = 10;
            this.CourseList.ValueMember = "CourseNumber";
            // 
            // catologOfCoursesBindingSource
            // 
            this.catologOfCoursesBindingSource.DataMember = "CatologOfCourses";
            this.catologOfCoursesBindingSource.DataSource = this.gradeTrackerDataSet3;
            // 
            // gradeTrackerDataSet3
            // 
            this.gradeTrackerDataSet3.DataSetName = "GradeTrackerDataSet3";
            this.gradeTrackerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catologOfCoursesTableAdapter
            // 
            this.catologOfCoursesTableAdapter.ClearBeforeFill = true;
            // 
            // StudentList
            // 
            this.StudentList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gTLoginBindingSource, "user_ID", true));
            this.StudentList.FormattingEnabled = true;
            this.StudentList.ItemHeight = 25;
            this.StudentList.Location = new System.Drawing.Point(596, 231);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(829, 479);
            this.StudentList.TabIndex = 11;
            // 
            // gTLoginBindingSource
            // 
            this.gTLoginBindingSource.DataMember = "GTLogin";
            this.gTLoginBindingSource.DataSource = this.gradeTrackerDataSet5;
            // 
            // gradeTrackerDataSet5
            // 
            this.gradeTrackerDataSet5.DataSetName = "GradeTrackerDataSet5";
            this.gradeTrackerDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradeTrackerDataSet4
            // 
            this.gradeTrackerDataSet4.DataSetName = "GradeTrackerDataSet4";
            this.gradeTrackerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gTLoginTableAdapter
            // 
            this.gTLoginTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(591, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(805, 44);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Please select a Student:\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gTLoginTableAdapter1
            // 
            this.gTLoginTableAdapter1.ClearBeforeFill = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.LightCoral;
            this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogoutButton.Location = new System.Drawing.Point(1860, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(115, 97);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Cancel";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.CancelBtn);
            // 
            // EnrollToCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1975, 830);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StudentList);
            this.Controls.Add(this.CourseList);
            this.Controls.Add(this.panel1);
            this.Name = "EnrollToCourseForm";
            this.Text = "EnrollToCourseForm";
            this.Load += new System.EventHandler(this.EnrollToCourseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catologOfCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTrackerDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AdminTopLabel;
        private System.Windows.Forms.ListBox CourseList;
        private GradeTrackerDataSet3 gradeTrackerDataSet3;
        private System.Windows.Forms.BindingSource catologOfCoursesBindingSource;
        private GradeTrackerDataSet3TableAdapters.CatologOfCoursesTableAdapter catologOfCoursesTableAdapter;
        private System.Windows.Forms.ListBox StudentList;
        private GradeTrackerDataSet4 gradeTrackerDataSet4;
        private GradeTrackerDataSet4TableAdapters.GTLoginTableAdapter gTLoginTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private GradeTrackerDataSet5 gradeTrackerDataSet5;
        private System.Windows.Forms.BindingSource gTLoginBindingSource;
        private GradeTrackerDataSet5TableAdapters.GTLoginTableAdapter gTLoginTableAdapter1;
        private System.Windows.Forms.Button LogoutButton;
    }
}