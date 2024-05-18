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
    public partial class SubjectForm : Form
    {
        public Subject Subject { get; set; }
        public SubjectForm(Subject subject)
        {
            this.Subject = subject;
            InitializeComponent();
        }

        public void editBtnText(string text)
        {
            this.cancelBtn.Text = text;
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            nameTb.Text = Subject.Name;
            descriptionTb.Text = Subject.Description;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Subject.Name = nameTb.Text;
            Subject.Description = descriptionTb.Text;
        }
    }
}
