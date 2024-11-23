// <copyright file="GradeCalculator.cs" company="Omar Urbano-Rendon, Justin Moos, Zimo Liu">
// Copyright (c) Omar Urbano-Rendon, Justin Moos, Zimo Liu. All rights reserved.
// </copyright>

using System;
using System.Data;
using System.Linq;

namespace GradeTrackerLogicEngine
{
    /// <summary>
    /// Class for performing grade calculation operations including final grade, GPA, highest, and lowest grades.
    /// </summary>
    public class GradeCalculator
    {
        private readonly Database database;

        /// <summary>
        /// Initializes a new instance of the <see cref="GradeCalculator"/> class.
        /// </summary>
        /// <param name="db">The database object to interact with student data.</param>
        public GradeCalculator(Database db)
        {
            this.database = db;
        }

        /// <summary>
        /// Calculates the final grade for a student based on all submitted assignments.
        /// </summary>
        /// <param name="studentUsername">The username of the student.</param>
        /// <returns>The final grade as a percentage.</returns>
        public double CalculateFinalGrade(string studentUsername)
        {
            DataTable assignments = this.database.GetAssignmentsSubmitted();

            // Filter the data for the given student
            var studentAssignments = assignments.Select($"UserName = '{studentUsername}'");

            if (studentAssignments.Length == 0)
            {
                throw new Exception("No assignments found for this student.");
            }

            double totalScore = 0;
            double totalWeight = 0;

            foreach (var assignment in studentAssignments)
            {
                // Assuming columns "Grade" and "Weight" exist in the AssignmentsSubmitted table
                double grade = Convert.ToDouble(assignment["Grade"]);
                double weight = Convert.ToDouble(assignment["Weight"]);

                totalScore += grade * weight;
                totalWeight += weight;
            }

            return totalWeight > 0 ? totalScore / totalWeight : 0;
        }

        /// <summary>
        /// Calculates the GPA for a student based on their final grades.
        /// </summary>
        /// <param name="studentUsername">The username of the student.</param>
        /// <returns>The GPA of the student.</returns>
        public double CalculateGPA(string studentUsername)
        {
            double finalGrade = this.CalculateFinalGrade(studentUsername);

            // GPA calculation assumes a 4.0 scale
            if (finalGrade >= 90)
            {
                return 4.0;
            }
            else if (finalGrade >= 80)
            {
                return 3.0;
            }
            else if (finalGrade >= 70)
            {
                return 2.0;
            }
            else if (finalGrade >= 60)
            {
                return 1.0;
            }
            else
            {
                return 0.0;
            }
        }

        /// <summary>
        /// Calculates the highest grade received by the student in any assignment.
        /// </summary>
        /// <param name="studentUsername">The username of the student.</param>
        /// <returns>The highest grade received by the student.</returns>
        public double GetHighestGrade(string studentUsername)
        {
            DataTable assignments = this.database.GetAssignmentsSubmitted();
            var studentAssignments = assignments.Select($"UserName = '{studentUsername}'");

            if (studentAssignments.Length == 0)
            {
                throw new Exception("No assignments found for this student.");
            }

            double highestGrade = studentAssignments.Max(a => Convert.ToDouble(a["Grade"]));
            return highestGrade;
        }

        /// <summary>
        /// Calculates the lowest grade received by the student in any assignment.
        /// </summary>
        /// <param name="studentUsername">The username of the student.</param>
        /// <returns>The lowest grade received by the student.</returns>
        public double GetLowestGrade(string studentUsername)
        {
            DataTable assignments = this.database.GetAssignmentsSubmitted();
            var studentAssignments = assignments.Select($"UserName = '{studentUsername}'");

            if (studentAssignments.Length == 0)
            {
                throw new Exception("No assignments found for this student.");
            }

            double lowestGrade = studentAssignments.Min(a => Convert.ToDouble(a["Grade"]));
            return lowestGrade;
        }

        /// <summary>
        /// Calculates the average grade received by the student across all assignments.
        /// </summary>
        /// <param name="studentUsername">The username of the student.</param>
        /// <returns>The average grade received by the student.</returns>
        public double GetAverageGrade(string studentUsername)
        {
            DataTable assignments = this.database.GetAssignmentsSubmitted();
            var studentAssignments = assignments.Select($"UserName = '{studentUsername}'");

            if (studentAssignments.Length == 0)
            {
                throw new Exception("No assignments found for this student.");
            }

            double totalGrade = studentAssignments.Sum(a => Convert.ToDouble(a["Grade"]));
            double count = studentAssignments.Length;

            return totalGrade / count;
        }
    }
}
