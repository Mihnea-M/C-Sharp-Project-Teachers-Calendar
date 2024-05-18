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
            //loadRooms();
            // loadSubjects();
        }

        public void loadRooms()
        {
            rooms = RoomRepo.getRooms();

            comboBoxRoom.DataSource = null;
            comboBoxRoom.Items.Clear();

            comboBoxRoom.DataSource = rooms;
            comboBoxRoom.DisplayMember = "Name";
            comboBoxRoom.ValueMember = "Id";
            comboBoxRoom.SelectedIndex = -1;
        }

        public void loadSubjects()
        {
            subjects = SubjectRepo.getSubjects();

            comboBoxSubject.DataSource = null;
            comboBoxSubject.Items.Clear();

            comboBoxSubject.DataSource = subjects;
            comboBoxSubject.DisplayMember = "Name";
            comboBoxSubject.ValueMember = "Id";
            comboBoxSubject.SelectedIndex = -1;
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            RoomForm roomForm = new RoomForm(room);
            
            roomForm.ShowDialog();
            if (roomForm.DialogResult == DialogResult.OK)
            {
                RoomRepo.addRoom(room);
                //loadRooms();
            }
        }
    }
}
