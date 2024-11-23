// <copyright file="LoginForm.cs" company="Omar Urbano-Rendon, Justin Moos, Zimo Liu">
// Copyright (c) Omar Urbano-Rendon, Justin Moos, Zimo Liu. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
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
    /// Class is in charge of our Login UI.
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Database connection.
        /// </summary>
        private Database mDB;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        public LoginForm()
        {
            this.InitializeComponent();
            this.mDB = new Database();
        }

        /// <summary>
        /// This method is invoked when the user clicks on the "Login" button and will verify the login information.
        /// Will also gather the information of the user to be used throughout the program.
        /// </summary>
        /// <param name="sender">object involved.</param>
        /// <param name="e">When login button clicked.</param>
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (this.UserName.Text != string.Empty && this.Password.Text != string.Empty)
            {
                if (this.mDB.VerifyLogin(this.UserName.Text, this.Password.Text))
                {
                    var userInfo = this.mDB.GetUserInformation(this.UserName.Text);
                    User user = UserTypeFactory.GetUserType(userInfo[4].ToString().Trim());
                    user.SetUserInfo(userInfo.ItemArray);
                    if ((bool)userInfo.ItemArray[5] != true) // Checking to see if user is archived.
                    {
                        if (user is Student student)
                        {
                            student.SetSchedule(this.mDB.GetEnrolledCourses(student.UserId));
                            student.SetAssignmentsSubmitted(this.mDB.GetAssignmentsSubmitted(student.UserId));
                            StudentDashboard studentDashboard = new StudentDashboard(user);
                            studentDashboard.Show();
                            this.Hide();
                        }
                        else if (user is Professor professor)
                        {
                            professor.SetClassRoster(this.mDB.GetAssignedCourses(professor.UserId));
                            ProfessorDashboard professorDashboard = new ProfessorDashboard();
                            this.Hide();
                            professorDashboard.Show();
                        }
                        else if (user is Admin admin)
                        {
                            AdminDashboard adminDashboard = new AdminDashboard();

                            // Subscribing to event form closing.
                            adminDashboard.AdminClosed += this.UnHideLoginForm;
                            adminDashboard.Show();

                            // clearing textboxes
                            this.Hide();
                            this.UserName.Text = string.Empty;
                            this.Password.Text = string.Empty;
                        }
                    }
                    else if (user is Admin admin)
                    {
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                        this.Hide();
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Invalid credentials, please contact Admin at 555-555-5555");
                }
            }
        }

        /// <summary>
        /// This method allows us to reshow the login form if the user logs out of another form.
        /// </summary>
        /// <param name="sender">Dashboard.</param>
        /// <param name="e">ReasonClosing.</param>
        private void UnHideLoginForm(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
