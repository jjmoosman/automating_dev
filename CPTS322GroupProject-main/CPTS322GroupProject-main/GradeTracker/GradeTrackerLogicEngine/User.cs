// <copyright file="User.cs" company="Omar Urbano-Rendon, Justin Moos, Zimo Liu">
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
    /// User class to hold fields, properties, and methods that child classes will have in common.
    /// </summary>
    public abstract class User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
            this.Name = this.Email = this.Password = this.UserName = string.Empty;
            this.UserId = -1;
        }

        /// <summary>
        /// Gets or sets Name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Email of the user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Username for login.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets ID number of user.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets Password of user login.
        /// </summary>
        private string Password { get; set; }

        /// <summary>
        /// This method will set the information of the user to the user field and properties.
        /// </summary>
        /// <param name="userInfo">Itemarray from datatable from the database.</param>
        public void SetUserInfo(object[] userInfo)
        {
            this.UserName = userInfo[1].ToString();
            this.Email = userInfo[2].ToString();
            this.UserId = Convert.ToInt32(userInfo[3]);
            this.Password = userInfo[6].ToString();
            this.Name = userInfo[7].ToString();
        }
    }
}
