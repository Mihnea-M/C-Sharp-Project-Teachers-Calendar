namespace TeachersCalendar
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.daySchedule = new System.Windows.Forms.DataGridView();
            this.comboBoxTeachers = new System.Windows.Forms.ComboBox();
            this.addTeacherBtn = new System.Windows.Forms.Button();
            this.editTeacherBtn = new System.Windows.Forms.Button();
            this.deleteTeacherBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MondayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuesdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WednesdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThursdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.daySchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // daySchedule
            // 
            this.daySchedule.AllowUserToAddRows = false;
            this.daySchedule.AllowUserToDeleteRows = false;
            this.daySchedule.AllowUserToResizeColumns = false;
            this.daySchedule.AllowUserToResizeRows = false;
            this.daySchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daySchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeCol,
            this.MondayCol,
            this.TuesdayCol,
            this.WednesdayCol,
            this.ThursdayCol,
            this.FridayCol});
            this.daySchedule.Location = new System.Drawing.Point(43, 131);
            this.daySchedule.Margin = new System.Windows.Forms.Padding(2);
            this.daySchedule.MultiSelect = false;
            this.daySchedule.Name = "daySchedule";
            this.daySchedule.RowHeadersVisible = false;
            this.daySchedule.RowHeadersWidth = 82;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.daySchedule.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.daySchedule.RowTemplate.Height = 33;
            this.daySchedule.Size = new System.Drawing.Size(1093, 223);
            this.daySchedule.TabIndex = 0;
            this.daySchedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.daySchedule_CellDoubleClick);
            // 
            // comboBoxTeachers
            // 
            this.comboBoxTeachers.FormattingEnabled = true;
            this.comboBoxTeachers.Location = new System.Drawing.Point(44, 63);
            this.comboBoxTeachers.Name = "comboBoxTeachers";
            this.comboBoxTeachers.Size = new System.Drawing.Size(338, 21);
            this.comboBoxTeachers.TabIndex = 1;
            this.comboBoxTeachers.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeachers_SelectedIndexChanged);
            // 
            // addTeacherBtn
            // 
            this.addTeacherBtn.Location = new System.Drawing.Point(44, 90);
            this.addTeacherBtn.Name = "addTeacherBtn";
            this.addTeacherBtn.Size = new System.Drawing.Size(88, 23);
            this.addTeacherBtn.TabIndex = 2;
            this.addTeacherBtn.Text = "Add teacher";
            this.addTeacherBtn.UseVisualStyleBackColor = true;
            this.addTeacherBtn.Click += new System.EventHandler(this.addTeacherBtn_Click);
            // 
            // editTeacherBtn
            // 
            this.editTeacherBtn.Location = new System.Drawing.Point(167, 90);
            this.editTeacherBtn.Name = "editTeacherBtn";
            this.editTeacherBtn.Size = new System.Drawing.Size(84, 23);
            this.editTeacherBtn.TabIndex = 3;
            this.editTeacherBtn.Text = "Edit teacher";
            this.editTeacherBtn.UseVisualStyleBackColor = true;
            this.editTeacherBtn.Click += new System.EventHandler(this.editTeacherBtn_Click);
            // 
            // deleteTeacherBtn
            // 
            this.deleteTeacherBtn.Location = new System.Drawing.Point(296, 90);
            this.deleteTeacherBtn.Name = "deleteTeacherBtn";
            this.deleteTeacherBtn.Size = new System.Drawing.Size(85, 23);
            this.deleteTeacherBtn.TabIndex = 4;
            this.deleteTeacherBtn.Text = "Delete teacher";
            this.deleteTeacherBtn.UseVisualStyleBackColor = true;
            this.deleteTeacherBtn.Click += new System.EventHandler(this.deleteTeacherBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a teacher:";
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(TeachersCalendar.MainForm);
            // 
            // mainFormBindingSource1
            // 
            this.mainFormBindingSource1.DataSource = typeof(TeachersCalendar.MainForm);
            // 
            // timeCol
            // 
            this.timeCol.HeaderText = "Time interval";
            this.timeCol.Name = "timeCol";
            this.timeCol.ReadOnly = true;
            this.timeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.timeCol.Width = 90;
            // 
            // MondayCol
            // 
            this.MondayCol.HeaderText = "Monday";
            this.MondayCol.MinimumWidth = 10;
            this.MondayCol.Name = "MondayCol";
            this.MondayCol.ReadOnly = true;
            this.MondayCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MondayCol.Width = 200;
            // 
            // TuesdayCol
            // 
            this.TuesdayCol.HeaderText = "Tuesday";
            this.TuesdayCol.MinimumWidth = 10;
            this.TuesdayCol.Name = "TuesdayCol";
            this.TuesdayCol.ReadOnly = true;
            this.TuesdayCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TuesdayCol.Width = 200;
            // 
            // WednesdayCol
            // 
            this.WednesdayCol.HeaderText = "Wednesday";
            this.WednesdayCol.MinimumWidth = 10;
            this.WednesdayCol.Name = "WednesdayCol";
            this.WednesdayCol.ReadOnly = true;
            this.WednesdayCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WednesdayCol.Width = 200;
            // 
            // ThursdayCol
            // 
            this.ThursdayCol.HeaderText = "Thursday";
            this.ThursdayCol.MinimumWidth = 10;
            this.ThursdayCol.Name = "ThursdayCol";
            this.ThursdayCol.ReadOnly = true;
            this.ThursdayCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ThursdayCol.Width = 200;
            // 
            // FridayCol
            // 
            this.FridayCol.HeaderText = "Friday";
            this.FridayCol.MinimumWidth = 10;
            this.FridayCol.Name = "FridayCol";
            this.FridayCol.ReadOnly = true;
            this.FridayCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FridayCol.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteTeacherBtn);
            this.Controls.Add(this.editTeacherBtn);
            this.Controls.Add(this.addTeacherBtn);
            this.Controls.Add(this.comboBoxTeachers);
            this.Controls.Add(this.daySchedule);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Teachers Calendar";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daySchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView daySchedule;
        private System.Windows.Forms.ComboBox comboBoxTeachers;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.BindingSource mainFormBindingSource1;
        private System.Windows.Forms.Button addTeacherBtn;
        private System.Windows.Forms.Button editTeacherBtn;
        private System.Windows.Forms.Button deleteTeacherBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MondayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuesdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WednesdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThursdayCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FridayCol;
    }
}

