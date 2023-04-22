using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandChangeSkills
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
            this.grpChangeSkills = new DarkUI.Controls.DarkGroupBox();
            this.cmbSkill = new DarkUI.Controls.DarkComboBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.cmbAction = new DarkUI.Controls.DarkComboBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.grpChangeSkills.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChangeSkills
            // 
            this.grpChangeSkills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpChangeSkills.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpChangeSkills.Controls.Add(this.cmbSkill);
            this.grpChangeSkills.Controls.Add(this.lblSkill);
            this.grpChangeSkills.Controls.Add(this.cmbAction);
            this.grpChangeSkills.Controls.Add(this.lblAction);
            this.grpChangeSkills.Controls.Add(this.btnCancel);
            this.grpChangeSkills.Controls.Add(this.btnSave);
            this.grpChangeSkills.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpChangeSkills.Location = new System.Drawing.Point(3, 3);
            this.grpChangeSkills.Name = "grpChangeSkills";
            this.grpChangeSkills.Size = new System.Drawing.Size(193, 112);
            this.grpChangeSkills.TabIndex = 17;
            this.grpChangeSkills.TabStop = false;
            this.grpChangeSkills.Text = "Change Player Skills:";
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
            this.cmbSkill.Location = new System.Drawing.Point(64, 46);
            this.cmbSkill.Name = "cmbSkill";
            this.cmbSkill.Size = new System.Drawing.Size(115, 21);
            this.cmbSkill.TabIndex = 24;
            this.cmbSkill.Text = null;
            this.cmbSkill.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Location = new System.Drawing.Point(5, 48);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(29, 13);
            this.lblSkill.TabIndex = 23;
            this.lblSkill.Text = "Skill:";
            // 
            // cmbAction
            // 
            this.cmbAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbAction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbAction.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAction.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbAction.DrawDropdownHoverOutline = false;
            this.cmbAction.DrawFocusRectangle = false;
            this.cmbAction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAction.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAction.FormattingEnabled = true;
            this.cmbAction.Items.AddRange(new object[] {
            "Add",
            "Remove"});
            this.cmbAction.Location = new System.Drawing.Point(64, 19);
            this.cmbAction.Name = "cmbAction";
            this.cmbAction.Size = new System.Drawing.Size(115, 21);
            this.cmbAction.TabIndex = 22;
            this.cmbAction.Text = "Add";
            this.cmbAction.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(5, 21);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(40, 13);
            this.lblAction.TabIndex = 21;
            this.lblAction.Text = "Action:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(89, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EventCommandChangeSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpChangeSkills);
            this.Name = "EventCommandChangeSkills";
            this.Size = new System.Drawing.Size(205, 118);
            this.grpChangeSkills.ResumeLayout(false);
            this.grpChangeSkills.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpChangeSkills;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkComboBox cmbAction;
        private System.Windows.Forms.Label lblAction;
        private DarkComboBox cmbSkill;
        private System.Windows.Forms.Label lblSkill;
    }
}
