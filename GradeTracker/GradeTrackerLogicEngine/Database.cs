// <copyright file="Database.cs" company="Omar Urbano-Rendon, Justin Moos, Zimo Liu">
// Copyright (c) Omar Urbano-Rendon, Justin Moos, Zimo Liu. All rights reserved.
// </copyright>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTrackerLogicEngine
{
    /// <summary>
    /// Class contains all database connection and all operations to retrieve information from the database.
    /// </summary>
    public class Database
    {
        /// <summary>
        /// Table to use when calling the methods below. Will save the last table from the last method used.
        /// </summary>
        private DataTable dbTable = new DataTable();

        /// <summary>
        /// sql connection.
        /// </summary>
        private SqlConnection db = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Database"/> class.
        /// </summary>
        public Database()
        {
            this.InitializeDatabase();
        }

        /// <summary>
        /// This method will get users that can login from the database table.
        /// </summary>
        /// <returns>DataTable.</returns>
        public DataTable GetLoginUsers()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.GTLogin", this.db))
            {
                // Fill the DataTable with the result from the database
                adapter.Fill(this.dbTable);
            }

            return this.dbTable;
        }

        /// <summary>
        /// Gets the datatable of assignments submitted by the student id passed in the parameter.
        /// </summary>
        /// <param name="studentID">student id.</param>
        /// <returns>Datatable.</returns>
        public DataTable GetAssignmentsSubmitted(int studentID)
        {
            string query = @"
                SELECT * FROM dbo.AssignmentsSubmitted
                WHERE 
                    AssignmentsSubmitted.SubmittedBy = @studentID;
            ";

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand(query, this.db);
                adapter.SelectCommand.Parameters.AddWithValue("@studentID", studentID);

                this.dbTable = new DataTable();
                adapter.Fill(this.dbTable);

                return this.dbTable;
            }
        }

        /// <summary>
        /// This method gets the enrolled courses of the student based on the id passed in the parameter.
        /// </summary>
        /// <param name="studentID">int student id.</param>
        /// <returns>datatable of enrolled courses.</returns>
        public DataTable GetEnrolledCourses(int studentID)
        {
            string query = @"
                SELECT * FROM dbo.StdntEnrolledCourses
                WHERE 
                    StdntEnrolledCourses.EnrolledStudent = @StudentID;
            ";

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand(query, this.db);
                adapter.SelectCommand.Parameters.AddWithValue("@StudentID", studentID);

                this.dbTable = new DataTable();
                adapter.Fill(this.dbTable);

                return this.dbTable;
            }
        }

        /// <summary>
        /// This method will get the courses that the professor is in charge of teaching.
        /// </summary>
        /// <param name="professorID">Professor ID.</param>
        /// <returns>DataTable.</returns>
        public DataTable GetAssignedCourses(int professorID)
        {
            string query = @"
                SELECT * FROM dbo.StdntEnrolledCourses
                WHERE 
                    StdntEnrolledCourses.Professor = @professorID;
            ";

            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand(query, this.db);
                adapter.SelectCommand.Parameters.AddWithValue("@professorID", professorID);

                this.dbTable = new DataTable();
                adapter.Fill(this.dbTable);

                return this.dbTable;
            }
        }

        /// <summary>
        /// This method will get user information based on the username passed in the parameter.
        /// </summary>
        /// <param name="username">string.</param>
        /// <returns>DataTable.</returns>
        public DataRow GetUserInformation(string username)
        {
            var userList = this.GetLoginUsers().AsEnumerable().ToList();

            DataRow userInfo = null;

            foreach (var user in userList)
            {
                if (user.ItemArray.Contains(username))
                {
                    userInfo = user;
                }
            }

            return userInfo;
        }

        /// <summary>
        /// This method will authenticate if the user has an account to access the program based on the username and
        /// password provided.
        /// </summary>
        /// <param name="mUsername">string username.</param>
        /// <param name="mPassword">string password.</param>
        /// <returns>true or false.</returns>
        public bool VerifyLogin(string mUsername, string mPassword)
        {
            var loginList = this.GetLoginUsers().AsEnumerable().ToList();

            foreach (var user in loginList)
            {
                if (user.ItemArray.Contains(mUsername) && user.ItemArray.Contains(mPassword))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// This method will get the assignments submitted by all the students.
        /// </summary>
        /// <returns>DataTable.</returns>
        public DataTable GetAssignmentsSubmitted()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.AssignmentsSubmitted", this.db))
            {
                // Fill the DataTable with the result from the database
                adapter.Fill(this.dbTable);
            }

            return this.dbTable;
        }

        /// <summary>
        /// This method will get all students enrolled in the courses.
        /// </summary>
        /// <returns>DataTable.</returns>
        public DataTable GetEnrolledCourses()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.StdnEnrolledCourses", this.db))
            {
                // Fill the DataTable with the result from the database
                adapter.Fill(this.dbTable);
            }

            return this.dbTable;
        }

        /// <summary>
        /// This method will only return users that are type student.
        /// </summary>
        /// <returns>Datatable.</returns>
        public DataTable GetStudents()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dbo.GTLogin WHERE userType = 'student'", this.db))
            {
                // Fill the DataTable with the result from the database
                adapter.Fill(this.dbTable);
            }

            return this.dbTable;
        }

        /// <summary>
        /// This method will enroll the student to the specified course in the parameter. It wills search for values
        /// required for the stdntEnrolledCourses table, and insert the data into the table.
        /// </summary>
        /// <param name="name">Name of student.</param>
        /// <param name="className">Course Name.</param>
        /// <exception cref="Exception">If value is not found.</exception>
        public void EnrollStudent(string name, string className)
        {
            string selectQuery = "SELECT * FROM dbo.GTLogin WHERE Name = @name";
            int studentID;
            string prefix;
            int professorID;
            int courseNumber;
            int fKID;

            // Retrieving StudentID
            using (SqlCommand selectCommand = new SqlCommand(selectQuery, this.db))
            {
                selectCommand.Parameters.AddWithValue("@name", name);

                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        studentID = (int)reader["user_ID"];
                    }
                    else
                    {
                        throw new Exception("Student not found.");
                    }
                }
            }

            // Retrieving Course Details
            selectQuery = "SELECT * FROM dbo.CatologOfCourses WHERE CourseName = @className";
            using (SqlCommand selectCommand = new SqlCommand(selectQuery, this.db))
            {
                selectCommand.Parameters.AddWithValue("@className", className);

                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        prefix = (string)reader["Prefix"];
                        professorID = (int)reader["ProfessorIDAssigned"];
                        courseNumber = (int)reader["CourseNumber"];
                        fKID = (int)reader["ID"];
                    }
                    else
                    {
                        throw new Exception("Course not found.");
                    }
                }
            }

            // Inserting Student to Course
            string insertQuery = @"
                INSERT INTO dbo.StdntEnrolledCourses 
                (FKID, LetterGrade, TotalPoints, CurrentPoints, EnrolledStudent, Prefix, CourseNumber, Professor) 
                VALUES 
                (@fKID, @letterGrade, @totalPoints, @currentPoints, @studentID, @prefix, @courseNumber, @professorID)";

            using (SqlCommand insertCommand = new SqlCommand(insertQuery, this.db))
            {
                insertCommand.Parameters.AddWithValue("@fKID", fKID);
                insertCommand.Parameters.AddWithValue("@letterGrade", "N/A"); // Default grade
                insertCommand.Parameters.AddWithValue("@totalPoints", 0);
                insertCommand.Parameters.AddWithValue("@currentPoints", 0);
                insertCommand.Parameters.AddWithValue("@studentID", studentID);
                insertCommand.Parameters.AddWithValue("@prefix", prefix);
                insertCommand.Parameters.AddWithValue("@courseNumber", courseNumber);
                insertCommand.Parameters.AddWithValue("@professorID", professorID);

                insertCommand.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Method to initialize our SQL database connection that stores user information.
        /// </summary>
        private void InitializeDatabase()
        {
            string connectionString = "Server=DESKTOP-ARHJATI\\DBGRADETRACKER;Database=GradeTracker;User Id=userGT;Password=CPTS322;";

            this.db = new SqlConnection(connectionString);

            try
            {
                this.db.Open();
                Console.WriteLine("Database connection initialized successfully!");
            }
            catch (SqlException)
            {
                Console.WriteLine("Database connection failed");
            }
        }
    }
}
