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
    public partial class RoomForm : Form
    {
        private Room Room { get; set; }
        public RoomForm(Room room)
        {
            this.Room = room;
            InitializeComponent();
        }

        public void editBtnText(string text)
        {
            this.cancelBtn.Text = text;
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            Room.Name = nameTb.Text;
            Room.Capacity = (int)capacityNumUpDown.Value;
            Room.HasComputers = hasComputersCheckBox.Checked;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            nameTb.Text = Room.Name;
            capacityNumUpDown.Value = Room.Capacity;
            hasComputersCheckBox.Checked = !Room.HasComputers;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (cancelBtn.Text == "Cancel")
            {
                DialogResult = DialogResult.Cancel;
            }
            else if (cancelBtn.Text == "Delete")
            {
                DialogResult = DialogResult.No;
            }
        }
    }
}
