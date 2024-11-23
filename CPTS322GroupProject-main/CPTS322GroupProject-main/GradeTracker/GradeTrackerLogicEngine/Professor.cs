// <copyright file="Professor.cs" company="Omar Urbano-Rendon, Justin Moos, Zimo Liu">
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
    /// The professor class is a user that will have class roster of the classes they are teaching.
    /// </summary>
    public class Professor : User
    {
        /// <summary>
        /// To represent the class roster of the professor.
        /// </summary>
        private DataTable classRoster = new DataTable();

        // Need to create an assignemnt list that professor created.

        /// <summary>
        /// Initializes a new instance of the <see cref="Professor"/> class.
        /// </summary>
        public Professor()
            : base()
        {
        }

        /// <summary>
        /// This method gathers a datatable of all the students that are enrolled in the professors class/es.
        /// </summary>
        /// <param name="mClassRoster">Datatable from database method.</param>
        public void SetClassRoster(DataTable mClassRoster)
        {
            this.classRoster = mClassRoster;
        }
    }
}
