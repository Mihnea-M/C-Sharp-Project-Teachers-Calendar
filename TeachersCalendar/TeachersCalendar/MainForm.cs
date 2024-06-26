﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeachersCalendar.EditForms;
using TeachersCalendar.Enums;
using TeachersCalendar.Models;
using TeachersCalendar.Repos;
using static System.Windows.Forms.LinkLabel;

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
            daySchedule.Rows.Clear();
            loadDayScheduleTimes();
            try
            {
                Teacher selectedTeacher = comboBoxTeachers.SelectedItem as Teacher;
                if (selectedTeacher == null)
                {
                    statusStripLabel.Text = "";
                    MessageBox.Show("Please select a teacher!", "Invalid teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                selectedTeacher.Classes = ClassRepo.getClassesOfTeacher(selectedTeacher);
                statusStripLabel.Text = "Displaying the calendar of professor " + selectedTeacher.FullName;
                loadTeacherClasses(selectedTeacher.Classes);
            } catch (Exception ex)
            {
                return ;
            }
        }

        private void loadTeacherClasses(List<UniClass> classes)
        {
            foreach(UniClass clazz in classes)
            {
                int rowIndex = clazz.ClassTime.TimeIndex;
                int colIndex = clazz.ClassTime.DayIndex;
                string classDesc = clazz.Subject.Name + " - " + clazz.Room.Name;
                daySchedule.Rows[rowIndex].Cells[colIndex].Value = classDesc;
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
            Teacher teacher = comboBoxTeachers.SelectedItem as Teacher;
            if (teacher == null)
            {
                MessageBox.Show("Please select a teacher!", "Invalid teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (e.ColumnIndex == 0 || e.RowIndex == -1)
            {
                return;
            }
            UniClass uniClass = null;
            foreach (var clazz in teacher.Classes) 
            {
                if (clazz.ClassTime.TimeIndex == e.RowIndex && clazz.ClassTime.DayIndex == e.ColumnIndex)
                {
                    uniClass = clazz;
                }
            }
            if (uniClass != null)
            {
                EditForms.ClassForm classForm = new EditForms.ClassForm(uniClass, uniClass.Room, uniClass.Subject);
                if (classForm.ShowDialog() == DialogResult.OK)
                {
                    ClassRepo.updateClass(uniClass, teacher);
                    loadTeacherClasses(teacher.Classes);
                }
            }
            else
            {
                uniClass = new UniClass();
                EditForms.ClassForm classForm = new EditForms.ClassForm(uniClass, e.ColumnIndex, e.RowIndex);
                if (classForm.ShowDialog() == DialogResult.OK)
                {
                    ClassRepo.addClass(uniClass, teacher);
                    teacher.Classes.Add(uniClass);
                    loadTeacherClasses(teacher.Classes);
                }
            }
        }

        private void createReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createReport();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createReport();
        }

        private void createReport()
        {
            Teacher teacher = comboBoxTeachers.SelectedItem as Teacher;
            if (teacher == null)
            {
                MessageBox.Show("Please select a teacher!", "Invalid teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string fileName = "report_" + teacher.LastName + "_" + teacher.FirstName + ".txt";
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.WriteLine("******** Professor " + teacher.FullName + " calendar ********\n");
                    if (teacher.Classes != null && teacher.Classes.Count > 0)
                    {
                        foreach (var clazz in teacher.Classes)
                        {
                            string toWriteFormat = "{0} in room {1} there will be an {2} class:\n   -Room capacity - {3}\n   -Subject description - {4}\n";
                            string toWrite = string.Format(toWriteFormat, clazz.ClassTime.ToString(), clazz.Room.Name, clazz.Subject.Name, clazz.Room.Capacity, clazz.Subject.Description);
                            sw.WriteLine(toWrite);
                        }
                    }
                    else
                    {
                        sw.WriteLine(" - This professor does not have any classes scheduled! - ");
                    }
                    statusStripLabel.Text = "Report created!";
                }
            }
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher teacher = comboBoxTeachers.SelectedItem as Teacher;
            if (teacher == null)
            {
                MessageBox.Show("Please select a teacher!", "Invalid teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(FileStream file = File.Create(saveFileDialog.FileName))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(file, teacher);
                    statusStripLabel.Text = "Serialization successfull!";
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.S)
            {
                createReport();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.S))
            {
                createReport();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(FileStream fileStream = File.OpenRead(openFileDialog.FileName))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    Teacher placeholder = (Teacher)binaryFormatter.Deserialize(fileStream);
                    Console.WriteLine(""); //used for debugging. deserialization does not make sense in current context
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = comboBoxTeachers.SelectedItem as Teacher;
            if (teacher == null)
            {
                MessageBox.Show("Please select a teacher!", "Invalid teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (teacher.Classes == null || teacher.Classes.Count == 0)
            {
                MessageBox.Show("No classes available!", "Invalid classes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StatsForm statsForm = new StatsForm(teacher.Classes);
            statsForm.ShowDialog();
        }
    }
}
