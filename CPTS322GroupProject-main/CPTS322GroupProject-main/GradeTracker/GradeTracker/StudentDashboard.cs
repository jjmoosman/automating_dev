// <copyright file="StudentDashboard.cs" company="Omar Urbano-Rendon, Justin Moos, Zimo Liu">
// Copyright (c) Omar Urbano-Rendon, Justin Moos, Zimo Liu. All rights reserved.
// </copyright>

using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;



namespace GradeTracker
{
    public partial class StudentDashboard : Form
    {
        private Database db = new Database();
        private GradeCalculator gradeCalculator;

        /// <summary>
        /// Initializes a new instance of the <see cref="StudentDashboard"/> class.
        /// </summary>
        /// <param name="student">User.</param>
        public StudentDashboard(User student)
        {

            InitializeComponent();
            this.dataGridView1.DataSource = db.GetEnrolledCourses(student.UserId);
            gradeCalculator = new GradeCalculator(db);  // Initialize the GradeCalculator with the database

        }

        private void LogoutBtn(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void ViewCoursesBtn(object sender, EventArgs e)
        {

            // View Courses logic (if needed)

        }

        private void GradeCalcBtn(object sender, EventArgs e)
        {

            // Prompt the user to input their username for grade calculation
            string username = Microsoft.VisualBasic.Interaction.InputBox("Enter your username to calculate grade:", "Grade Calculator", "", -1, -1);

            if (!string.IsNullOrEmpty(username))
            {
                try
                {
                    // Calculate the final grade, GPA, etc.
                    double finalGrade = gradeCalculator.CalculateFinalGrade(username);
                    double gpa = gradeCalculator.CalculateGPA(username);
                    double highestGrade = gradeCalculator.GetHighestGrade(username);
                    double lowestGrade = gradeCalculator.GetLowestGrade(username);
                    double averageGrade = gradeCalculator.GetAverageGrade(username);

                    // Display the result in a MessageBox or use a label on the form
                    string resultMessage = $"Final Grade: {finalGrade:F2}%\n" +
                                           $"GPA: {gpa:F2}\n" +
                                           $"Highest Grade: {highestGrade:F2}\n" +
                                           $"Lowest Grade: {lowestGrade:F2}\n" +
                                           $"Average Grade: {averageGrade:F2}";

                    MessageBox.Show(resultMessage, "Grade Calculation Result");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Grade Calculation Error");
                }
            }
            else
            {
                MessageBox.Show("Username cannot be empty!", "Input Error");
            }

        }
    }
}
