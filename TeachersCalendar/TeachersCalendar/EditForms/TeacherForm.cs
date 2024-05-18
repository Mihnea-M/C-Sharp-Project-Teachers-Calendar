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
    }
}
