using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GradeTrackerLogicEngine;
using Microsoft.VisualBasic;

namespace GradeTracker
{
    public partial class ProfessorDashboard : Form
    {

        public ProfessorDashboard()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ManageUsersBtn_Click(object sender, EventArgs e)
        {

        }

        private void ManageCoursesBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            CourseInfo courseInfo = new CourseInfo();
            courseInfo.Show();
        }
    }
}
