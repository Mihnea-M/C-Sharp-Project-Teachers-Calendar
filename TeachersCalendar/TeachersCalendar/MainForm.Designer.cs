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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.daySchedule = new System.Windows.Forms.DataGridView();
            this.timeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MondayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuesdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WednesdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThursdayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FridayCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxTeachers = new System.Windows.Forms.ComboBox();
            this.addTeacherBtn = new System.Windows.Forms.Button();
            this.editTeacherBtn = new System.Windows.Forms.Button();
            this.deleteTeacherBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.daySchedule)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
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
            this.daySchedule.ReadOnly = true;
            this.daySchedule.RowHeadersVisible = false;
            this.daySchedule.RowHeadersWidth = 82;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.daySchedule.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.daySchedule.RowTemplate.Height = 53;
            this.daySchedule.RowTemplate.ReadOnly = true;
            this.daySchedule.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.daySchedule.Size = new System.Drawing.Size(1093, 177);
            this.daySchedule.TabIndex = 0;
            this.daySchedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.daySchedule_CellDoubleClick);
            // 
            // timeCol
            // 
            this.timeCol.HeaderText = "Time interval";
            this.timeCol.MinimumWidth = 10;
            this.timeCol.Name = "timeCol";
            this.timeCol.ReadOnly = true;
            this.timeCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.timeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.timeCol.Width = 90;
            // 
            // MondayCol
            // 
            this.MondayCol.HeaderText = "Monday";
            this.MondayCol.MinimumWidth = 10;
            this.MondayCol.Name = "MondayCol";
            this.MondayCol.ReadOnly = true;
            this.MondayCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MondayCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MondayCol.Width = 200;
            // 
            // TuesdayCol
            // 
            this.TuesdayCol.HeaderText = "Tuesday";
            this.TuesdayCol.MinimumWidth = 10;
            this.TuesdayCol.Name = "TuesdayCol";
            this.TuesdayCol.ReadOnly = true;
            this.TuesdayCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TuesdayCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TuesdayCol.Width = 200;
            // 
            // WednesdayCol
            // 
            this.WednesdayCol.HeaderText = "Wednesday";
            this.WednesdayCol.MinimumWidth = 10;
            this.WednesdayCol.Name = "WednesdayCol";
            this.WednesdayCol.ReadOnly = true;
            this.WednesdayCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WednesdayCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WednesdayCol.Width = 200;
            // 
            // ThursdayCol
            // 
            this.ThursdayCol.HeaderText = "Thursday";
            this.ThursdayCol.MinimumWidth = 10;
            this.ThursdayCol.Name = "ThursdayCol";
            this.ThursdayCol.ReadOnly = true;
            this.ThursdayCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ThursdayCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ThursdayCol.Width = 200;
            // 
            // FridayCol
            // 
            this.FridayCol.HeaderText = "Friday";
            this.FridayCol.MinimumWidth = 10;
            this.FridayCol.Name = "FridayCol";
            this.FridayCol.ReadOnly = true;
            this.FridayCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FridayCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FridayCol.Width = 200;
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
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip.Size = new System.Drawing.Size(1210, 39);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "Data";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(45, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Import/Export";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 369);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1210, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1210, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createReportToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // createReportToolStripMenuItem
            // 
            this.createReportToolStripMenuItem.Name = "createReportToolStripMenuItem";
            this.createReportToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.createReportToolStripMenuItem.Text = "Create report";
            this.createReportToolStripMenuItem.Click += new System.EventHandler(this.createReportToolStripMenuItem_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(144, 26);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.testToolStripMenuItem.Text = "Create report";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(TeachersCalendar.MainForm);
            // 
            // mainFormBindingSource1
            // 
            this.mainFormBindingSource1.DataSource = typeof(TeachersCalendar.MainForm);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 391);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteTeacherBtn);
            this.Controls.Add(this.editTeacherBtn);
            this.Controls.Add(this.addTeacherBtn);
            this.Controls.Add(this.comboBoxTeachers);
            this.Controls.Add(this.daySchedule);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Teachers Calendar";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.daySchedule)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createReportToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}

