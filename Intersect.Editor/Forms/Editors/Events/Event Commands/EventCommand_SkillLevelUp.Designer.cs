using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandSkillLevelUp
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
            this.grpSkillLevelUp = new DarkUI.Controls.DarkGroupBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.cmbSkill = new DarkUI.Controls.DarkComboBox();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.grpSkillLevelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSkillLevelUp
            // 
            this.grpSkillLevelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpSkillLevelUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSkillLevelUp.Controls.Add(this.lblSkill);
            this.grpSkillLevelUp.Controls.Add(this.cmbSkill);
            this.grpSkillLevelUp.Controls.Add(this.btnCancel);
            this.grpSkillLevelUp.Controls.Add(this.btnSave);
            this.grpSkillLevelUp.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSkillLevelUp.Location = new System.Drawing.Point(3, 3);
            this.grpSkillLevelUp.Name = "grpSkillLevelUp";
            this.grpSkillLevelUp.Size = new System.Drawing.Size(243, 85);
            this.grpSkillLevelUp.TabIndex = 17;
            this.grpSkillLevelUp.TabStop = false;
            this.grpSkillLevelUp.Text = "Skill Level Up:";
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(88, 55);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EventCommandSkillLevelUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpSkillLevelUp);
            this.Name = "EventCommandSkillLevelUp";
            this.Size = new System.Drawing.Size(250, 91);
            this.grpSkillLevelUp.ResumeLayout(false);
            this.grpSkillLevelUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpSkillLevelUp;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkComboBox cmbSkill;
        private System.Windows.Forms.Label lblSkill;
    }
}
