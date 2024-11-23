// <copyright file="UserTypeFactory.cs" company="Omar Urbano-Rendon, Justin Moos, Zimo Liu">
// Copyright (c) Omar Urbano-Rendon, Justin Moos, Zimo Liu. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeTrackerLogicEngine
{
    /// <summary>
    /// Static class to get the user type.
    /// </summary>
    public static class UserTypeFactory
    {
        /// <summary>
        /// The type of user is passed in the parameter and based on that type will determine what instance of a user
        /// we will create.
        /// </summary>
        /// <param name="userType">string.</param>
        /// <returns>Student, Professor or Admin.</returns>
        public static User GetUserType(string userType)
        {
            switch (userType)
            {
                case "student":
                    return new Student();
                case "professor":
                    return new Professor();
                case "admin":
                    return new Admin();
                default:
                    return null;
            }
        }
    }
}
