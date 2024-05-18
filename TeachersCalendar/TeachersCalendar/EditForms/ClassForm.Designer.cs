namespace TeachersCalendar.EditForms
{
    partial class ClassForm
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
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.addRoomBtn = new System.Windows.Forms.Button();
            this.addSubjectBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.editRoomButton = new System.Windows.Forms.Button();
            this.editSubjectButton = new System.Windows.Forms.Button();
            this.subjectInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DataSource = this.roomBindingSource;
            this.comboBoxRoom.DisplayMember = "Capacity";
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(554, 160);
            this.comboBoxRoom.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(238, 33);
            this.comboBoxRoom.TabIndex = 4;
            this.comboBoxRoom.ValueMember = "Id";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(TeachersCalendar.Models.Room);
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(432, 165);
            this.roomLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(74, 25);
            this.roomLabel.TabIndex = 5;
            this.roomLabel.Text = "Room:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(24, 60);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(194, 37);
            this.headerLabel.TabIndex = 6;
            this.headerLabel.Text = "headerLabel";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(24, 165);
            this.subjectLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(90, 25);
            this.subjectLabel.TabIndex = 8;
            this.subjectLabel.Text = "Subject:";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.DataSource = this.roomBindingSource;
            this.comboBoxSubject.DisplayMember = "Capacity";
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(146, 160);
            this.comboBoxSubject.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(238, 33);
            this.comboBoxSubject.TabIndex = 7;
            this.comboBoxSubject.ValueMember = "Id";
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.Location = new System.Drawing.Point(437, 212);
            this.addRoomBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Size = new System.Drawing.Size(208, 44);
            this.addRoomBtn.TabIndex = 9;
            this.addRoomBtn.Text = "Add new room";
            this.addRoomBtn.UseVisualStyleBackColor = true;
            this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
            // 
            // addSubjectBtn
            // 
            this.addSubjectBtn.Location = new System.Drawing.Point(29, 212);
            this.addSubjectBtn.Margin = new System.Windows.Forms.Padding(6);
            this.addSubjectBtn.Name = "addSubjectBtn";
            this.addSubjectBtn.Size = new System.Drawing.Size(205, 44);
            this.addSubjectBtn.TabIndex = 10;
            this.addSubjectBtn.Text = "Add new subject";
            this.addSubjectBtn.UseVisualStyleBackColor = true;
            this.addSubjectBtn.Click += new System.EventHandler(this.addSubjectBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(438, 346);
            this.okBtn.Margin = new System.Windows.Forms.Padding(6);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(158, 44);
            this.okBtn.TabIndex = 11;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(638, 346);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(158, 44);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // editRoomButton
            // 
            this.editRoomButton.Location = new System.Drawing.Point(654, 212);
            this.editRoomButton.Margin = new System.Windows.Forms.Padding(6);
            this.editRoomButton.Name = "editRoomButton";
            this.editRoomButton.Size = new System.Drawing.Size(138, 44);
            this.editRoomButton.TabIndex = 13;
            this.editRoomButton.Text = "Edit room";
            this.editRoomButton.UseVisualStyleBackColor = true;
            this.editRoomButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // editSubjectButton
            // 
            this.editSubjectButton.Location = new System.Drawing.Point(246, 212);
            this.editSubjectButton.Margin = new System.Windows.Forms.Padding(6);
            this.editSubjectButton.Name = "editSubjectButton";
            this.editSubjectButton.Size = new System.Drawing.Size(138, 44);
            this.editSubjectButton.TabIndex = 14;
            this.editSubjectButton.Text = "Edit subject";
            this.editSubjectButton.UseVisualStyleBackColor = true;
            this.editSubjectButton.Click += new System.EventHandler(this.editSubjectButton_Click);
            // 
            // subjectInfoLabel
            // 
            this.subjectInfoLabel.AutoSize = true;
            this.subjectInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectInfoLabel.Location = new System.Drawing.Point(36, 289);
            this.subjectInfoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.subjectInfoLabel.Name = "subjectInfoLabel";
            this.subjectInfoLabel.Size = new System.Drawing.Size(0, 37);
            this.subjectInfoLabel.TabIndex = 15;
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 473);
            this.Controls.Add(this.subjectInfoLabel);
            this.Controls.Add(this.editSubjectButton);
            this.Controls.Add(this.editRoomButton);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.addSubjectBtn);
            this.Controls.Add(this.addRoomBtn);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.comboBoxRoom);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ClassForm";
            this.Text = "ClassForm";
            this.Load += new System.EventHandler(this.ClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Button addRoomBtn;
        private System.Windows.Forms.Button addSubjectBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button editRoomButton;
        private System.Windows.Forms.Button editSubjectButton;
        private System.Windows.Forms.Label subjectInfoLabel;
    }
}