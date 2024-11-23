// <copyright file="EnrollToCourseForm.cs" company="Omar Urbano-Rendon, Justin Moos, Zimo Liu">
// Copyright (c) Omar Urbano-Rendon, Justin Moos, Zimo Liu. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using GradeTrackerLogicEngine;

namespace GradeTracker
{
    /// <summary>
    /// This form is to enroll a student into a course if the user selects the button.
    /// </summary>
    public partial class EnrollToCourseForm : Form
    {
        /// <summary>
        /// Saves the user selected by user.
        /// </summary>
        private string userSelected;

        /// <summary>
        /// Saves the course selected by the user.
        /// </summary>
        private string courseSelected;

        /// <summary>
        /// Database connection we need to insert data into database.
        /// </summary>
        private Database db = new Database();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrollToCourseForm"/> class.
        /// </summary>
        public EnrollToCourseForm()
        {
            this.InitializeComponent();
            this.CourseList.MouseClick += this.OnClassSelected; // subscribing to user clicking on a class
            this.SetStudentList();
            this.StudentList.MouseClick += this.OnStudentSelected; // subscribing to user clicking on a user.
            this.CourseList.Hide();
        }

        /// <summary>
        /// Public event to handle list box click.
        /// </summary>
        public event MouseEventHandler ListBoxClick;

        /// <summary>
        /// public event to handle when user clicks cancel or is done enrolling.
        /// </summary>
        public event FormClosedEventHandler EnrolledCourseClosed;

        /// <summary>
        /// In charge of filling the list box for courses.
        /// </summary>
        /// <param name="sender">list box.</param>
        /// <param name="e">event args.</param>
        private void EnrollToCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gradeTrackerDataSet5.GTLogin' table. You can move, or remove it, as needed.
            this.gTLoginTableAdapter1.Fill(this.gradeTrackerDataSet5.GTLogin);

            // TODO: This line of code loads data into the 'gradeTrackerDataSet4.GTLogin' table. You can move, or remove it, as needed.
            this.gTLoginTableAdapter.Fill(this.gradeTrackerDataSet4.GTLogin);

            // TODO: This line of code loads data into the 'gradeTrackerDataSet3.CatologOfCourses' table. You can move, or remove it, as needed.
            this.catologOfCoursesTableAdapter.Fill(this.gradeTrackerDataSet3.CatologOfCourses);
        }

        /// <summary>
        /// Once the user clicks on a class, will process this information and get the student enrolled.
        /// </summary>
        /// <param name="sender">List box selection.</param>
        /// <param name="e">click data.</param>
        private void OnClassSelected(object sender, MouseEventArgs e)
        {
            this.courseSelected = ((ListBox)sender).Text;
            try
            {
                this.EnrollSelectedStudent();
                MessageBox.Show("Successfully enrolled the student.");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to enroll student into the class.");
            }
        }

        /// <summary>
        /// When the user clicks on a student, will save name, and hide listbox, update textbox and show course list.
        /// </summary>
        /// <param name="sender">ListBox.</param>
        /// <param name="e">Click information.</param>
        private void OnStudentSelected(object sender, MouseEventArgs e)
        {
            this.userSelected = ((ListBox)sender).Text;
            this.textBox1.Text = "Please select the course to Enroll the student";
            this.StudentList.Hide();
            this.CourseList.Show();
        }

        /// <summary>
        /// This method will run a query to ensure only students are displayed in the textbox.
        /// </summary>
        private void SetStudentList()
        {
            DataTable studentsTable = this.db.GetStudents();

            // Setting the DataSource of the ListBox
            this.StudentList.DataSource = studentsTable;
            this.StudentList.DisplayMember = "Name";
            this.StudentList.ValueMember = "user_ID";
        }

        /// <summary>
        /// Method handles when user clicks the cancel button. Will close the form.
        /// </summary>
        /// <param name="sender">Button.</param>
        /// <param name="e">Button information.</param>
        private void CancelBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This is a wrapper method to call the EnrolledStudent method within the database class.
        /// </summary>
        private void EnrollSelectedStudent()
        {
            this.db.EnrollStudent(this.userSelected, this.courseSelected);
        }
    }
}
