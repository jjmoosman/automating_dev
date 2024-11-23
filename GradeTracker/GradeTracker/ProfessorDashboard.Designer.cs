namespace GradeTracker
{
    partial class ProfessorDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.AdminTopLabel = new System.Windows.Forms.Label();
            this.ManageCoursesBtn = new System.Windows.Forms.Button();
            this.ManageUsersBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1945, 96);
            this.panel1.TabIndex = 8;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.LightCoral;
            this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogoutButton.Location = new System.Drawing.Point(1829, 0);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(116, 96);
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
            this.AdminTopLabel.Location = new System.Drawing.Point(580, -12);
            this.AdminTopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminTopLabel.Name = "AdminTopLabel";
            this.AdminTopLabel.Size = new System.Drawing.Size(902, 108);
            this.AdminTopLabel.TabIndex = 5;
            this.AdminTopLabel.Text = "Professor Dashboard";
            this.AdminTopLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManageCoursesBtn
            // 
            this.ManageCoursesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCoursesBtn.Location = new System.Drawing.Point(246, 567);
            this.ManageCoursesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManageCoursesBtn.Name = "ManageCoursesBtn";
            this.ManageCoursesBtn.Size = new System.Drawing.Size(496, 223);
            this.ManageCoursesBtn.TabIndex = 11;
            this.ManageCoursesBtn.Text = "Manage Courses";
            this.ManageCoursesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageCoursesBtn.UseVisualStyleBackColor = true;
            this.ManageCoursesBtn.Click += new System.EventHandler(this.ManageCoursesBtn_Click);
            // 
            // ManageUsersBtn
            // 
            this.ManageUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUsersBtn.Location = new System.Drawing.Point(246, 242);
            this.ManageUsersBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManageUsersBtn.Name = "ManageUsersBtn";
            this.ManageUsersBtn.Size = new System.Drawing.Size(496, 223);
            this.ManageUsersBtn.TabIndex = 10;
            this.ManageUsersBtn.Text = "Manage Students";
            this.ManageUsersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageUsersBtn.UseVisualStyleBackColor = true;
            this.ManageUsersBtn.Click += new System.EventHandler(this.ManageUsersBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(976, 283);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1024, 479);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // ProfessorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1945, 828);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ManageCoursesBtn);
            this.Controls.Add(this.ManageUsersBtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ProfessorDashboard";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label AdminTopLabel;
        private System.Windows.Forms.Button ManageCoursesBtn;
        private System.Windows.Forms.Button ManageUsersBtn;
        private System.Windows.Forms.ListBox listBox1;
    }
}