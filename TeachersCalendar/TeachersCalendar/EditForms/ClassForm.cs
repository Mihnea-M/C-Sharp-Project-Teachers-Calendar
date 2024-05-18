using System;
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

namespace TeachersCalendar.EditForms
{
    public partial class ClassForm : Form
    {
        ClassTimeRepo classTimeRepo = new ClassTimeRepo();
        private ClassTime ClassTime {  get; set; }
        public UniClass UniClass { get; set; }

        private List<Room> rooms;
        private List<Subject> subjects;

        public ClassForm(UniClass uniClass, int dayIndex, int timeIndex)
        {
            this.UniClass = uniClass;
            this.UniClass.ClassTime = classTimeRepo.getClassTime(dayIndex, timeIndex);
            InitializeComponent();
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            this.headerLabel.Text = "Insert a new class at " + UniClass.ClassTime.getTime() + " on " + UniClass.ClassTime.getDay();

            loadRooms();
            loadSubjects();

            comboBoxSubject.SelectedIndex = -1;
            comboBoxRoom.SelectedIndex = -1;

            showSubjectInfo();
        }

        public void loadRooms()
        {
            rooms = RoomRepo.getRooms();

            comboBoxRoom.DataSource = null;
            comboBoxRoom.Items.Clear();

            comboBoxRoom.DataSource = rooms;
            comboBoxRoom.DisplayMember = "Name";
            comboBoxRoom.ValueMember = "Id";

        }

        public void loadSubjects()
        {
            subjects = SubjectRepo.getSubjects();

            comboBoxSubject.DataSource = null;
            comboBoxSubject.Items.Clear();

            comboBoxSubject.DataSource = subjects;
            comboBoxSubject.DisplayMember = "Name";
            comboBoxSubject.ValueMember = "Id";

            showSubjectInfo();
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            RoomForm roomForm = new RoomForm(room);
            roomForm.editBtnText("Cancel");
            roomForm.ShowDialog();
            if (roomForm.DialogResult == DialogResult.OK)
            {
                RoomRepo.addRoom(room);
                loadRooms();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room room = comboBoxRoom.SelectedItem as Room;
            if (room == null)
            {
                MessageBox.Show("Please select a room!", "Invalid room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RoomForm roomForm = new RoomForm(room);

            roomForm.editBtnText("Delete");
            roomForm.ShowDialog();
            
            if (roomForm.DialogResult == DialogResult.OK)
            {
                RoomRepo.updateRoom(room);
                loadRooms();
            }
            else
            {
                RoomRepo.deleteRoom(room);
                loadRooms();
            }
        }

        public void showSubjectInfo()
        {
            this.subjectInfoLabel.Text = string.Empty;
            Subject subject = comboBoxSubject.SelectedItem as Subject;
            if(subject != null)
            {
                this.subjectInfoLabel.Text = "Description:\n" + subject.Description;
            }
            else
            {
                this.subjectInfoLabel.Text = "";
            }
            
        }

        private void addSubjectBtn_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            SubjectForm subjectForm = new SubjectForm(subject);
            subjectForm.editBtnText("Cancel");
            subjectForm.ShowDialog();
            if (subjectForm.DialogResult == DialogResult.OK)
            {
                SubjectRepo.addSubject(subject);
                loadSubjects();
            }
        }

  
        private void editSubjectButton_Click(object sender, EventArgs e)
        {
            Subject subject = comboBoxSubject.SelectedItem as Subject;
            if (subject == null)
            {
                MessageBox.Show("Please select a subject!", "Invalid subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SubjectForm subjectForm = new SubjectForm(subject);

            subjectForm.editBtnText("Delete");
            subjectForm.ShowDialog();

            if (subjectForm.DialogResult == DialogResult.OK)
            {
                SubjectRepo.updateSubject(subject);
                loadSubjects();
            }
            else
            {
                SubjectRepo.deleteSubject(subject);
                loadSubjects();
            }
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSubjectInfo();
        }
    }
}
