// <copyright file="AdminDashboard.cs" company="Omar Urbano-Rendon, Justin Moos, Zimo Liu">
// Copyright (c) Omar Urbano-Rendon, Justin Moos, Zimo Liu. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GradeTrackerLogicEngine;

namespace GradeTracker
{
    /// <summary>
    /// This class will handle the UI of an Admin user.
    /// </summary>
    public partial class AdminDashboard : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminDashboard"/> class.
        /// </summary>
        public AdminDashboard()
        {
            this.InitializeComponent();
            this.DataGridAllUsers.Hide();
            this.CourseGridview.Hide();
            this.DoneEditingBtn.Hide();
        }

        /// <summary>
        /// Public event that outside classes can subscribe to.
        /// </summary>
        public event FormClosedEventHandler AdminClosed;

        /// <summary>
        /// When user clicks on Manage users button.
        /// </summary>
        /// <param name="sender">button.</param>
        /// <param name="e">what button.</param>
        private void ManageUsersBtn_Click(object sender, EventArgs e)
        {
            this.ManageCoursesBtn.Hide();
            //this.ManageCoursesBtn.Hide();
            this.ManageUsersBtn.Hide();
            this.Enrollbtn.Hide();

            this.DataGridAllUsers.Show();
            this.DoneEditingBtn.Text = "Done Editing Users";
            this.DoneEditingBtn.Show();
        }

        /// <summary>
        /// This method will handle when the user clicks on Manage Courses button.
        /// </summary>
        /// <param name="sender">Button.</param>
        /// <param name="e">Button information.</param>
        private void ManageCoursesBtn_Click(object sender, EventArgs e)
        {
            this.ManageCoursesBtn.Hide();
            //this.ManageCoursesBtn.Hide();
            this.ManageUsersBtn.Hide();
            this.Enrollbtn.Hide();

            this.CourseGridview.Show();
            this.DoneEditingBtn.Text = "Done Editing Courses";
            this.DoneEditingBtn.Show();
        }

        /// <summary>
        /// When the user clicks on the log out button.
        /// </summary>
        /// <param name="sender">form.</param>
        /// <param name="e">button.</param>
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.OnFormClosed(this, new FormClosedEventArgs(CloseReason.FormOwnerClosing));
        }

        /// <summary>
        /// This method is helper method which will let subscribers know the form closed.
        /// </summary>
        /// <param name="sender">admindashboard.</param>
        /// <param name="e">reason for closing.</param>
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            this.AdminClosed.Invoke(this, e);
        }

        /// <summary>
        /// This method is in charge of loading our gridview object to display the proper data. In this case,
        /// All users and all courses.
        /// </summary>
        /// <param name="sender">gridview.</param>
        /// <param name="e">event args.</param>
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gradeTrackerCoursesDataSet.CatologOfCourses' table. You can move, or remove it, as needed.
            this.catologOfCoursesTableAdapter.Fill(this.gradeTrackerCoursesDataSet.CatologOfCourses);

            // TODO: This line of code loads data into the 'gradeTrackerDataSet2.GTLogin' table. You can move, or remove it, as needed.
            this.gTLoginTableAdapter2.Fill(this.gradeTrackerDataSet2.GTLogin);
            //// TODO: This line of code loads data into the 'gradeTrackerDataSet1.GTLogin' table. You can move, or remove it, as needed.

            // this.gTLoginTableAdapter1.Fill(this.gradeTrackerDataSet1.GTLogin);
            //// TODO: This line of code loads data into the 'gradeTrackerDataSet.GTLogin' table. You can move, or remove it, as needed.
            // this.gTLoginTableAdapter.Fill(this.gradeTrackerDataSet.GTLogin);
        }

        /// <summary>
        /// This method will handle when the user clicks on the done editing button. Will do certain UI updates depending
        /// on the text of the button, which helps keep track of what is being done.
        /// </summary>
        /// <param name="sender">Button.</param>
        /// <param name="e">button information.</param>
        private void DoneEditingBtn_Click(object sender, EventArgs e)
        {
            if (this.DoneEditingBtn.Text == "Done Editing Users")
            {
                this.gTLoginBindingSource.EndEdit();
                this.DataGridAllUsers.Hide();
                this.DoneEditingBtn.Hide();
                this.ManageCoursesBtn.Show();
                this.Enrollbtn.Show();
                this.ManageUsersBtn.Show();
                //this.ManageCoursesBtn.Show();
                this.gTLoginBindingSource.DataSource = this.gradeTrackerDataSet2;
                var conString = "Server=DESKTOP-ARHJATI\\DBGRADETRACKER;Database=GradeTracker;User Id=userGT;Password=CPTS322;";

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM GTLogin", connection);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                    // Update the database with changes from the DataTable
                    adapter.Update(this.gradeTrackerDataSet2.Tables["GTLogin"]);
                }
            }
            else if (this.DoneEditingBtn.Text == "Done Editing Courses")
            {
                this.catologOfCoursesBindingSource.EndEdit();
                this.CourseGridview.Hide();
                this.DoneEditingBtn.Hide();
                this.ManageCoursesBtn.Show();
                this.ManageUsersBtn.Show();
                this.Enrollbtn.Show();
                //this.ManageCoursesBtn.Show();
                this.catologOfCoursesBindingSource.DataSource = this.gradeTrackerCoursesDataSet;
                var conString = "Server=DESKTOP-ARHJATI\\DBGRADETRACKER;Database=GradeTracker;User Id=userGT;Password=CPTS322;";

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CatologOfCourses", connection);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                    // Update the database with changes from the DataTable
                    adapter.Update(this.gradeTrackerCoursesDataSet.Tables["CatologOfCourses"]);
                }
            }
        }

        /// <summary>
        /// This method handles when a user clicks on Enroll Student Button. Will open a new form and subscribe to
        /// the event when the form is closed.
        /// </summary>
        /// <param name="sender">Button.</param>
        /// <param name="e">Button information.</param>
        private void EnrollStudentBtn(object sender, EventArgs e)
        {
            this.Hide();
            EnrollToCourseForm frm = new EnrollToCourseForm();
            frm.FormClosed += this.OnEnrollFormClosed;
            frm.Show();
        }

        /// <summary>
        /// Will be invoked when Enroll Course Form is closed.
        /// </summary>
        /// <param name="sender">EnrolledCourse Form.</param>
        /// <param name="e">CloseReason.</param>
        private void OnEnrollFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();

        }
    }
}
