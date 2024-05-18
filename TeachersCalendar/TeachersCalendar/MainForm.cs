﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeachersCalendar.Enums;
using TeachersCalendar.Models;
using TeachersCalendar.Repos;

namespace TeachersCalendar
{
    public partial class MainForm : Form
    {
        List<Teacher> Teachers;
        private Repos.TeacherRepo teacherRepo = new Repos.TeacherRepo();
        public MainForm()
        {
            Teachers = new List<Teacher>();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Teachers = teacherRepo.getTeachers();
            loadComboBox();
            loadDayScheduleTimes();
        }

        private void loadComboBox()
        {
            comboBoxTeachers.DataSource = null;
            comboBoxTeachers.Items.Clear();

            comboBoxTeachers.SelectedIndexChanged -= comboBoxTeachers_SelectedIndexChanged;

            comboBoxTeachers.DataSource = Teachers;
            comboBoxTeachers.DisplayMember = "FullName";
            comboBoxTeachers.ValueMember = "Id";
            comboBoxTeachers.SelectedIndex = -1;

            comboBoxTeachers.SelectedIndexChanged += comboBoxTeachers_SelectedIndexChanged;
            
        }

        private void loadDayScheduleTimes()
        {
            for (int i = 0; i < 7; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(daySchedule);
                row.Cells[0].Value = ClassTime.getTime(i);
                daySchedule.Rows.Add(row);
            }
        }

        private void comboBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Teacher selectedTeacher = comboBoxTeachers.SelectedItem as Teacher;
                if (selectedTeacher == null)
                    // TODO 
                    return;
                    //MessageBox.Show("You clicked " + selectedTeacher.Id);
            } catch (Exception ex)
            {
                return ;
            }
        }

        private void addTeacherBtn_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            EditForms.TeacherForm teacherForm = new EditForms.TeacherForm(teacher);
            if(teacherForm.ShowDialog() == DialogResult.OK)
            {
                Teachers.Add(teacher);
                teacherRepo.addTeacher(teacher);
                loadComboBox();
            }
        }

        private void editTeacherBtn_Click(object sender, EventArgs e)
        {
            Teacher teacher = comboBoxTeachers.SelectedItem as Teacher;
            if (teacher == null)
            {
                MessageBox.Show("Please select a teacher!", "Invalid teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EditForms.TeacherForm teacherForm = new EditForms.TeacherForm(teacher);
            if (teacherForm.ShowDialog() == DialogResult.OK)
            {
                teacherRepo.updateTeacher(teacher);
                loadComboBox();
            }
        }

        private void deleteTeacherBtn_Click(object sender, EventArgs e)
        {

            Teacher teacher = comboBoxTeachers.SelectedItem as Teacher;
            if (teacher == null)
            {
                MessageBox.Show("Please select a teacher!", "Invalid teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this teacher?", 
                "Confirm Deletion",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.OK)
            {
                teacherRepo.deleteTeacher(teacher);
                Teachers.Remove(teacher);
                loadComboBox();
            }
        }

        private void daySchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.RowIndex == -1)
            {
                return;
            }
            UniClass uniClass = new UniClass();
            EditForms.ClassForm classForm = new EditForms.ClassForm(uniClass, e.ColumnIndex, e.RowIndex);
            classForm.ShowDialog();
            
        }
    }
}