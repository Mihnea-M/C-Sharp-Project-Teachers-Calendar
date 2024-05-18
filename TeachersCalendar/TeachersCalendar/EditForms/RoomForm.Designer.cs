namespace TeachersCalendar.EditForms
{
    partial class RoomForm
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
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.capacityNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.hasComputersCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.capacityNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(64, 340);
            this.okBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(150, 44);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "Save";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(248, 340);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(150, 44);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(168, 56);
            this.nameTb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(226, 31);
            this.nameTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capacity:";
            // 
            // capacityNumUpDown
            // 
            this.capacityNumUpDown.Location = new System.Drawing.Point(180, 156);
            this.capacityNumUpDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.capacityNumUpDown.Name = "capacityNumUpDown";
            this.capacityNumUpDown.Size = new System.Drawing.Size(218, 31);
            this.capacityNumUpDown.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room";
            // 
            // hasComputersCheckBox
            // 
            this.hasComputersCheckBox.AutoSize = true;
            this.hasComputersCheckBox.Location = new System.Drawing.Point(140, 254);
            this.hasComputersCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hasComputersCheckBox.Name = "hasComputersCheckBox";
            this.hasComputersCheckBox.Size = new System.Drawing.Size(185, 29);
            this.hasComputersCheckBox.TabIndex = 7;
            this.hasComputersCheckBox.Text = "has computers";
            this.hasComputersCheckBox.UseVisualStyleBackColor = true;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 473);
            this.Controls.Add(this.hasComputersCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.capacityNumUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capacityNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown capacityNumUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox hasComputersCheckBox;
    }
}