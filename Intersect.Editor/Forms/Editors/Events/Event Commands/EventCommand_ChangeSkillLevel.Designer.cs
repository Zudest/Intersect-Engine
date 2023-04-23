using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandChangeSkillLevel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpChangeLevel = new DarkUI.Controls.DarkGroupBox();
            this.nudLevel = new DarkUI.Controls.DarkNumericUpDown();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.cmbSkill = new DarkUI.Controls.DarkComboBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.grpChangeLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChangeLevel
            // 
            this.grpChangeLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpChangeLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpChangeLevel.Controls.Add(this.lblSkill);
            this.grpChangeLevel.Controls.Add(this.cmbSkill);
            this.grpChangeLevel.Controls.Add(this.nudLevel);
            this.grpChangeLevel.Controls.Add(this.lblLevel);
            this.grpChangeLevel.Controls.Add(this.btnCancel);
            this.grpChangeLevel.Controls.Add(this.btnSave);
            this.grpChangeLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpChangeLevel.Location = new System.Drawing.Point(3, 3);
            this.grpChangeLevel.Name = "grpChangeLevel";
            this.grpChangeLevel.Size = new System.Drawing.Size(243, 110);
            this.grpChangeLevel.TabIndex = 17;
            this.grpChangeLevel.TabStop = false;
            this.grpChangeLevel.Text = "Change Skill Level:";
            // 
            // nudLevel
            // 
            this.nudLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLevel.Location = new System.Drawing.Point(71, 55);
            this.nudLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(164, 20);
            this.nudLevel.TabIndex = 22;
            this.nudLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(9, 57);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(55, 13);
            this.lblLevel.TabIndex = 21;
            this.lblLevel.Text = "Set Level:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(89, 81);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbSkill
            // 
            this.cmbSkill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSkill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSkill.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSkill.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSkill.DrawDropdownHoverOutline = false;
            this.cmbSkill.DrawFocusRectangle = false;
            this.cmbSkill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSkill.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSkill.FormattingEnabled = true;
            this.cmbSkill.Location = new System.Drawing.Point(71, 28);
            this.cmbSkill.Name = "cmbSkill";
            this.cmbSkill.Size = new System.Drawing.Size(165, 21);
            this.cmbSkill.TabIndex = 42;
            this.cmbSkill.Text = null;
            this.cmbSkill.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Location = new System.Drawing.Point(35, 31);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(29, 13);
            this.lblSkill.TabIndex = 43;
            this.lblSkill.Text = "Skill:";
            // 
            // EventCommandChangeSkillLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpChangeLevel);
            this.Name = "EventCommandChangeSkillLevel";
            this.Size = new System.Drawing.Size(250, 116);
            this.grpChangeLevel.ResumeLayout(false);
            this.grpChangeLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpChangeLevel;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private System.Windows.Forms.Label lblLevel;
        private DarkNumericUpDown nudLevel;
        private DarkComboBox cmbSkill;
        private System.Windows.Forms.Label lblSkill;
    }
}
