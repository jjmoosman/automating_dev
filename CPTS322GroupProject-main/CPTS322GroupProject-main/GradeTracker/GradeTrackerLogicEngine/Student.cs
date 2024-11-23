// <copyright file="Student.cs" company="Omar Urbano-Rendon, Justin Moos, Zimo Liu">
// Copyright (c) Omar Urbano-Rendon, Justin Moos, Zimo Liu. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTrackerLogicEngine
{
    /// <summary>
    /// Class to represent the a student with their course schedule and assignments submitted.
    /// </summary>
    public class Student : User
    {
        /// <summary>
        /// To represent the courses the student is enrolled.
        /// </summary>
        private DataTable courseSchedule = new DataTable();

        /// <summary>
        /// To represent the assignments submitted by the student.
        /// </summary>
        private DataTable assignmentSubmitted = new DataTable();

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        public Student()
            : base()
        {
        }

        /// <summary>
        /// Sets the courses that the student is enrolled.
        /// </summary>
        /// <param name="enrolledCourses">Datatable from the database class method.</param>
        public void SetSchedule(DataTable enrolledCourses)
        {
            this.courseSchedule = enrolledCourses;
        }

        /// <summary>
        /// Sets the class Datatable to the assignments submitted by the student based on the database information.
        /// </summary>
        /// <param name="mAssignmentSubmitted">Datatable from database method.</param>
        public void SetAssignmentsSubmitted(DataTable mAssignmentSubmitted)
        {
            this.assignmentSubmitted = mAssignmentSubmitted;
        }
    }
}
