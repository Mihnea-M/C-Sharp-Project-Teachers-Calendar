using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeachersCalendar.Models;

namespace TeachersCalendar.EditForms
{
    public partial class TeacherForm : Form
    {
        public Teacher Teacher { get; set; }
        public TeacherForm(Teacher teacher)
        {
            Teacher = teacher;
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Teacher.FirstName = firstNameTB.Text;
            Teacher.LastName = lastNameTB.Text;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            firstNameTB.Text = Teacher.FirstName;
            lastNameTB.Text = Teacher.LastName;
        }

        private void firstNameTB_Validating(object sender, CancelEventArgs e)
        {
            if (firstNameTB.Text.Length < 1 || firstNameTB.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Invalid name");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void lastNameTB_Validating(object sender, CancelEventArgs e)
        {
            if (lastNameTB.Text.Length < 1 || lastNameTB.Text.Any(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Invalid name");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }
    }
}
