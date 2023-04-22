using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmSkills
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSkills));
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.grpSkills = new DarkUI.Controls.DarkGroupBox();
            this.btnClearSearch = new DarkUI.Controls.DarkButton();
            this.txtSearch = new DarkUI.Controls.DarkTextBox();
            this.lstGameObjects = new Intersect.Editor.Forms.Controls.GameObjectList();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpGeneral = new DarkUI.Controls.DarkGroupBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.cmbClass = new DarkUI.Controls.DarkComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.nudMaxLevel = new DarkUI.Controls.DarkNumericUpDown();
            this.lblMaxLevel = new System.Windows.Forms.Label();
            this.cmbLevelMaxAnimation = new DarkUI.Controls.DarkComboBox();
            this.cmbLevelUpAnimation = new DarkUI.Controls.DarkComboBox();
            this.lblLevelMaxAnimation = new System.Windows.Forms.Label();
            this.lblLevelUpAnimation = new System.Windows.Forms.Label();
            this.grpExpGrid = new DarkUI.Controls.DarkGroupBox();
            this.btnUpdateExpGrid = new DarkUI.Controls.DarkButton();
            this.nudBaseExp = new DarkUI.Controls.DarkNumericUpDown();
            this.btnResetExpGrid = new DarkUI.Controls.DarkButton();
            this.nudExpIncrease = new DarkUI.Controls.DarkNumericUpDown();
            this.expGrid = new System.Windows.Forms.DataGridView();
            this.lblExpIncrease = new System.Windows.Forms.Label();
            this.lblBaseExp = new System.Windows.Forms.Label();
            this.txtDesc = new DarkUI.Controls.DarkTextBox();
            this.cmbIcon = new DarkUI.Controls.DarkComboBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.picSkill = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddFolder = new DarkUI.Controls.DarkButton();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cmbFolder = new DarkUI.Controls.DarkComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.toolStrip = new DarkUI.Controls.DarkToolStrip();
            this.toolStripItemNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAlphabetical = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripItemPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemUndo = new System.Windows.Forms.ToolStripButton();
            this.nudOrder = new DarkUI.Controls.DarkNumericUpDown();
            this.grpSkills.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLevel)).BeginInit();
            this.grpExpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkill)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(352, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(172, 27);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(177, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(169, 27);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpSkills
            // 
            this.grpSkills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpSkills.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSkills.Controls.Add(this.btnClearSearch);
            this.grpSkills.Controls.Add(this.txtSearch);
            this.grpSkills.Controls.Add(this.lstGameObjects);
            this.grpSkills.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSkills.Location = new System.Drawing.Point(12, 36);
            this.grpSkills.Name = "grpSkills";
            this.grpSkills.Size = new System.Drawing.Size(203, 385);
            this.grpSkills.TabIndex = 22;
            this.grpSkills.TabStop = false;
            this.grpSkills.Text = "Skills";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(179, 13);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Padding = new System.Windows.Forms.Padding(5);
            this.btnClearSearch.Size = new System.Drawing.Size(18, 20);
            this.btnClearSearch.TabIndex = 28;
            this.btnClearSearch.Text = "X";
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtSearch.Location = new System.Drawing.Point(6, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 20);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lstGameObjects
            // 
            this.lstGameObjects.AllowDrop = true;
            this.lstGameObjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstGameObjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstGameObjects.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstGameObjects.HideSelection = false;
            this.lstGameObjects.ImageIndex = 0;
            this.lstGameObjects.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lstGameObjects.Location = new System.Drawing.Point(6, 39);
            this.lstGameObjects.Name = "lstGameObjects";
            this.lstGameObjects.SelectedImageIndex = 0;
            this.lstGameObjects.Size = new System.Drawing.Size(191, 340);
            this.lstGameObjects.TabIndex = 26;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.grpGeneral);
            this.pnlContainer.Location = new System.Drawing.Point(221, 36);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(459, 385);
            this.pnlContainer.TabIndex = 31;
            this.pnlContainer.Visible = false;
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpGeneral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGeneral.Controls.Add(this.nudOrder);
            this.grpGeneral.Controls.Add(this.lblOrder);
            this.grpGeneral.Controls.Add(this.cmbClass);
            this.grpGeneral.Controls.Add(this.lblClass);
            this.grpGeneral.Controls.Add(this.nudMaxLevel);
            this.grpGeneral.Controls.Add(this.lblMaxLevel);
            this.grpGeneral.Controls.Add(this.cmbLevelMaxAnimation);
            this.grpGeneral.Controls.Add(this.cmbLevelUpAnimation);
            this.grpGeneral.Controls.Add(this.lblLevelMaxAnimation);
            this.grpGeneral.Controls.Add(this.lblLevelUpAnimation);
            this.grpGeneral.Controls.Add(this.grpExpGrid);
            this.grpGeneral.Controls.Add(this.txtDesc);
            this.grpGeneral.Controls.Add(this.cmbIcon);
            this.grpGeneral.Controls.Add(this.lblIcon);
            this.grpGeneral.Controls.Add(this.picSkill);
            this.grpGeneral.Controls.Add(this.lblDescription);
            this.grpGeneral.Controls.Add(this.btnAddFolder);
            this.grpGeneral.Controls.Add(this.lblFolder);
            this.grpGeneral.Controls.Add(this.cmbFolder);
            this.grpGeneral.Controls.Add(this.lblName);
            this.grpGeneral.Controls.Add(this.txtName);
            this.grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGeneral.Location = new System.Drawing.Point(5, 3);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(449, 379);
            this.grpGeneral.TabIndex = 31;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(272, 136);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(36, 13);
            this.lblOrder.TabIndex = 61;
            this.lblOrder.Text = "Order:";
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbClass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbClass.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbClass.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbClass.DrawDropdownHoverOutline = false;
            this.cmbClass.DrawFocusRectangle = false;
            this.cmbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClass.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(63, 134);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(151, 21);
            this.cmbClass.TabIndex = 60;
            this.cmbClass.Text = null;
            this.cmbClass.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(11, 137);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 59;
            this.lblClass.Text = "Class:";
            // 
            // nudMaxLevel
            // 
            this.nudMaxLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMaxLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMaxLevel.Location = new System.Drawing.Point(311, 108);
            this.nudMaxLevel.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudMaxLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxLevel.Name = "nudMaxLevel";
            this.nudMaxLevel.Size = new System.Drawing.Size(132, 20);
            this.nudMaxLevel.TabIndex = 58;
            this.nudMaxLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxLevel.ValueChanged += new System.EventHandler(this.nudMaxLevel_ValueChanged);
            // 
            // lblMaxLevel
            // 
            this.lblMaxLevel.AutoSize = true;
            this.lblMaxLevel.Location = new System.Drawing.Point(250, 110);
            this.lblMaxLevel.Name = "lblMaxLevel";
            this.lblMaxLevel.Size = new System.Drawing.Size(59, 13);
            this.lblMaxLevel.TabIndex = 57;
            this.lblMaxLevel.Text = "Max Level:";
            // 
            // cmbLevelMaxAnimation
            // 
            this.cmbLevelMaxAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbLevelMaxAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbLevelMaxAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbLevelMaxAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbLevelMaxAnimation.DrawDropdownHoverOutline = false;
            this.cmbLevelMaxAnimation.DrawFocusRectangle = false;
            this.cmbLevelMaxAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLevelMaxAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevelMaxAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLevelMaxAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbLevelMaxAnimation.FormattingEnabled = true;
            this.cmbLevelMaxAnimation.Location = new System.Drawing.Point(311, 81);
            this.cmbLevelMaxAnimation.Name = "cmbLevelMaxAnimation";
            this.cmbLevelMaxAnimation.Size = new System.Drawing.Size(132, 21);
            this.cmbLevelMaxAnimation.TabIndex = 56;
            this.cmbLevelMaxAnimation.Text = null;
            this.cmbLevelMaxAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbLevelMaxAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbLevelMaxAnimation_SelectedIndexChanged);
            // 
            // cmbLevelUpAnimation
            // 
            this.cmbLevelUpAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbLevelUpAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbLevelUpAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbLevelUpAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbLevelUpAnimation.DrawDropdownHoverOutline = false;
            this.cmbLevelUpAnimation.DrawFocusRectangle = false;
            this.cmbLevelUpAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLevelUpAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevelUpAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLevelUpAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbLevelUpAnimation.FormattingEnabled = true;
            this.cmbLevelUpAnimation.Location = new System.Drawing.Point(311, 54);
            this.cmbLevelUpAnimation.Name = "cmbLevelUpAnimation";
            this.cmbLevelUpAnimation.Size = new System.Drawing.Size(132, 21);
            this.cmbLevelUpAnimation.TabIndex = 55;
            this.cmbLevelUpAnimation.Text = null;
            this.cmbLevelUpAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbLevelUpAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbLevelUpAnimation_SelectedIndexChanged);
            // 
            // lblLevelMaxAnimation
            // 
            this.lblLevelMaxAnimation.AutoSize = true;
            this.lblLevelMaxAnimation.Location = new System.Drawing.Point(220, 84);
            this.lblLevelMaxAnimation.Name = "lblLevelMaxAnimation";
            this.lblLevelMaxAnimation.Size = new System.Drawing.Size(88, 13);
            this.lblLevelMaxAnimation.TabIndex = 54;
            this.lblLevelMaxAnimation.Text = "Max Level Anim.:";
            // 
            // lblLevelUpAnimation
            // 
            this.lblLevelUpAnimation.AutoSize = true;
            this.lblLevelUpAnimation.Location = new System.Drawing.Point(227, 57);
            this.lblLevelUpAnimation.Name = "lblLevelUpAnimation";
            this.lblLevelUpAnimation.Size = new System.Drawing.Size(82, 13);
            this.lblLevelUpAnimation.TabIndex = 53;
            this.lblLevelUpAnimation.Text = "Level Up Anim.:";
            // 
            // grpExpGrid
            // 
            this.grpExpGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpExpGrid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpExpGrid.Controls.Add(this.btnUpdateExpGrid);
            this.grpExpGrid.Controls.Add(this.nudBaseExp);
            this.grpExpGrid.Controls.Add(this.btnResetExpGrid);
            this.grpExpGrid.Controls.Add(this.nudExpIncrease);
            this.grpExpGrid.Controls.Add(this.expGrid);
            this.grpExpGrid.Controls.Add(this.lblExpIncrease);
            this.grpExpGrid.Controls.Add(this.lblBaseExp);
            this.grpExpGrid.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpExpGrid.Location = new System.Drawing.Point(5, 172);
            this.grpExpGrid.Margin = new System.Windows.Forms.Padding(2);
            this.grpExpGrid.Name = "grpExpGrid";
            this.grpExpGrid.Padding = new System.Windows.Forms.Padding(2);
            this.grpExpGrid.Size = new System.Drawing.Size(439, 204);
            this.grpExpGrid.TabIndex = 52;
            this.grpExpGrid.TabStop = false;
            this.grpExpGrid.Text = "Experience Data and Override";
            // 
            // btnUpdateExpGrid
            // 
            this.btnUpdateExpGrid.Location = new System.Drawing.Point(264, 30);
            this.btnUpdateExpGrid.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateExpGrid.Name = "btnUpdateExpGrid";
            this.btnUpdateExpGrid.Padding = new System.Windows.Forms.Padding(5);
            this.btnUpdateExpGrid.Size = new System.Drawing.Size(83, 21);
            this.btnUpdateExpGrid.TabIndex = 57;
            this.btnUpdateExpGrid.Text = "Update Grid";
            this.btnUpdateExpGrid.Click += new System.EventHandler(this.btnUpdateExpGrid_Click);
            // 
            // nudBaseExp
            // 
            this.nudBaseExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudBaseExp.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudBaseExp.Location = new System.Drawing.Point(7, 30);
            this.nudBaseExp.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudBaseExp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBaseExp.Name = "nudBaseExp";
            this.nudBaseExp.Size = new System.Drawing.Size(99, 20);
            this.nudBaseExp.TabIndex = 56;
            this.nudBaseExp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnResetExpGrid
            // 
            this.btnResetExpGrid.Location = new System.Drawing.Point(351, 30);
            this.btnResetExpGrid.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetExpGrid.Name = "btnResetExpGrid";
            this.btnResetExpGrid.Padding = new System.Windows.Forms.Padding(5);
            this.btnResetExpGrid.Size = new System.Drawing.Size(83, 21);
            this.btnResetExpGrid.TabIndex = 39;
            this.btnResetExpGrid.Text = "Reset Grid";
            // 
            // nudExpIncrease
            // 
            this.nudExpIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudExpIncrease.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudExpIncrease.Location = new System.Drawing.Point(115, 30);
            this.nudExpIncrease.Name = "nudExpIncrease";
            this.nudExpIncrease.Size = new System.Drawing.Size(122, 20);
            this.nudExpIncrease.TabIndex = 55;
            this.nudExpIncrease.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // expGrid
            // 
            this.expGrid.AllowUserToAddRows = false;
            this.expGrid.AllowUserToDeleteRows = false;
            this.expGrid.AllowUserToResizeColumns = false;
            this.expGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.expGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.expGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.expGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.expGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.expGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.expGrid.ColumnHeadersHeight = 24;
            this.expGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.expGrid.EnableHeadersVisualStyles = false;
            this.expGrid.Location = new System.Drawing.Point(7, 56);
            this.expGrid.MultiSelect = false;
            this.expGrid.Name = "expGrid";
            this.expGrid.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.expGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.expGrid.Size = new System.Drawing.Size(427, 143);
            this.expGrid.TabIndex = 0;
            this.expGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.expGrid_CellEndEdit);
            this.expGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.expGrid_CellMouseDown);
            this.expGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.expGrid_EditingControlShowing);
            this.expGrid.SelectionChanged += new System.EventHandler(this.expGrid_SelectionChanged);
            this.expGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.expGrid_KeyDown);
            // 
            // lblExpIncrease
            // 
            this.lblExpIncrease.AutoSize = true;
            this.lblExpIncrease.Location = new System.Drawing.Point(112, 14);
            this.lblExpIncrease.Name = "lblExpIncrease";
            this.lblExpIncrease.Size = new System.Drawing.Size(125, 13);
            this.lblExpIncrease.TabIndex = 54;
            this.lblExpIncrease.Text = "Exp Increase (Per Lvl %):";
            // 
            // lblBaseExp
            // 
            this.lblBaseExp.AutoSize = true;
            this.lblBaseExp.Location = new System.Drawing.Point(6, 15);
            this.lblBaseExp.Name = "lblBaseExp";
            this.lblBaseExp.Size = new System.Drawing.Size(100, 13);
            this.lblBaseExp.TabIndex = 53;
            this.lblBaseExp.Text = "Base Exp To Level:";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtDesc.Location = new System.Drawing.Point(63, 68);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(151, 60);
            this.txtDesc.TabIndex = 51;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // cmbIcon
            // 
            this.cmbIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbIcon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbIcon.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbIcon.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbIcon.DrawDropdownHoverOutline = false;
            this.cmbIcon.DrawFocusRectangle = false;
            this.cmbIcon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbIcon.FormattingEnabled = true;
            this.cmbIcon.Items.AddRange(new object[] {
            "None"});
            this.cmbIcon.Location = new System.Drawing.Point(267, 27);
            this.cmbIcon.Name = "cmbIcon";
            this.cmbIcon.Size = new System.Drawing.Size(176, 21);
            this.cmbIcon.TabIndex = 50;
            this.cmbIcon.Text = "None";
            this.cmbIcon.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbIcon.SelectedIndexChanged += new System.EventHandler(this.cmbIcon_SelectedIndexChanged);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(264, 11);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(31, 13);
            this.lblIcon.TabIndex = 49;
            this.lblIcon.Text = "Icon:";
            // 
            // picSkill
            // 
            this.picSkill.BackColor = System.Drawing.Color.Black;
            this.picSkill.Location = new System.Drawing.Point(226, 16);
            this.picSkill.Name = "picSkill";
            this.picSkill.Size = new System.Drawing.Size(32, 32);
            this.picSkill.TabIndex = 48;
            this.picSkill.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(7, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(38, 13);
            this.lblDescription.TabIndex = 47;
            this.lblDescription.Text = "Desc.:";
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(196, 41);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddFolder.Size = new System.Drawing.Size(18, 21);
            this.btnAddFolder.TabIndex = 46;
            this.btnAddFolder.Text = "+";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(6, 45);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(39, 13);
            this.lblFolder.TabIndex = 45;
            this.lblFolder.Text = "Folder:";
            // 
            // cmbFolder
            // 
            this.cmbFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbFolder.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbFolder.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbFolder.DrawDropdownHoverOutline = false;
            this.cmbFolder.DrawFocusRectangle = false;
            this.cmbFolder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFolder.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbFolder.FormattingEnabled = true;
            this.cmbFolder.Location = new System.Drawing.Point(63, 41);
            this.cmbFolder.Name = "cmbFolder";
            this.cmbFolder.Size = new System.Drawing.Size(127, 21);
            this.cmbFolder.TabIndex = 44;
            this.cmbFolder.Text = null;
            this.cmbFolder.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbFolder.SelectedIndexChanged += new System.EventHandler(this.cmbFolder_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtName.Location = new System.Drawing.Point(63, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 18;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemNew,
            this.toolStripSeparator1,
            this.toolStripItemDelete,
            this.toolStripSeparator2,
            this.btnAlphabetical,
            this.toolStripSeparator4,
            this.toolStripItemCopy,
            this.toolStripItemPaste,
            this.toolStripSeparator3,
            this.toolStripItemUndo});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(684, 25);
            this.toolStrip.TabIndex = 43;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripItemNew
            // 
            this.toolStripItemNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemNew.Image")));
            this.toolStripItemNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemNew.Name = "toolStripItemNew";
            this.toolStripItemNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemNew.Text = "New";
            this.toolStripItemNew.Click += new System.EventHandler(this.toolStripItemNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemDelete
            // 
            this.toolStripItemDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemDelete.Enabled = false;
            this.toolStripItemDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemDelete.Image")));
            this.toolStripItemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemDelete.Name = "toolStripItemDelete";
            this.toolStripItemDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemDelete.Text = "Delete";
            this.toolStripItemDelete.Click += new System.EventHandler(this.toolStripItemDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAlphabetical
            // 
            this.btnAlphabetical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlphabetical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnAlphabetical.Image = ((System.Drawing.Image)(resources.GetObject("btnAlphabetical.Image")));
            this.btnAlphabetical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlphabetical.Name = "btnAlphabetical";
            this.btnAlphabetical.Size = new System.Drawing.Size(23, 22);
            this.btnAlphabetical.Text = "Order Chronologically";
            this.btnAlphabetical.Click += new System.EventHandler(this.btnAlphabetical_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemCopy
            // 
            this.toolStripItemCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemCopy.Enabled = false;
            this.toolStripItemCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemCopy.Image")));
            this.toolStripItemCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemCopy.Name = "toolStripItemCopy";
            this.toolStripItemCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemCopy.Text = "Copy";
            this.toolStripItemCopy.Click += new System.EventHandler(this.toolStripItemCopy_Click);
            // 
            // toolStripItemPaste
            // 
            this.toolStripItemPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemPaste.Enabled = false;
            this.toolStripItemPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemPaste.Image")));
            this.toolStripItemPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemPaste.Name = "toolStripItemPaste";
            this.toolStripItemPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemPaste.Text = "Paste";
            this.toolStripItemPaste.Click += new System.EventHandler(this.toolStripItemPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemUndo
            // 
            this.toolStripItemUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemUndo.Enabled = false;
            this.toolStripItemUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemUndo.Image")));
            this.toolStripItemUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemUndo.Name = "toolStripItemUndo";
            this.toolStripItemUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemUndo.Text = "Undo";
            this.toolStripItemUndo.Click += new System.EventHandler(this.toolStripItemUndo_Click);
            // 
            // nudOrder
            // 
            this.nudOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudOrder.Location = new System.Drawing.Point(311, 134);
            this.nudOrder.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOrder.Name = "nudOrder";
            this.nudOrder.Size = new System.Drawing.Size(132, 20);
            this.nudOrder.TabIndex = 62;
            this.nudOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOrder.ValueChanged += new System.EventHandler(this.nudOrder_ValueChanged);
            // 
            // FrmSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(684, 466);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpSkills);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSkills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skills Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSkills_FormClosed);
            this.Load += new System.EventHandler(this.frmSkills_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.grpSkills.ResumeLayout(false);
            this.grpSkills.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLevel)).EndInit();
            this.grpExpGrid.ResumeLayout(false);
            this.grpExpGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkill)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkGroupBox grpSkills;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkGroupBox grpGeneral;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkButton btnClearSearch;
        private DarkTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnAlphabetical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private DarkButton btnAddFolder;
        private System.Windows.Forms.Label lblFolder;
        private DarkComboBox cmbFolder;
        private Controls.GameObjectList lstGameObjects;
        private System.Windows.Forms.Label lblDescription;
        private DarkComboBox cmbIcon;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.PictureBox picSkill;
        private DarkTextBox txtDesc;
        private DarkGroupBox grpExpGrid;
        private DarkButton btnResetExpGrid;
        private System.Windows.Forms.DataGridView expGrid;
        private DarkNumericUpDown nudBaseExp;
        private DarkNumericUpDown nudExpIncrease;
        private System.Windows.Forms.Label lblExpIncrease;
        private System.Windows.Forms.Label lblBaseExp;
        private DarkNumericUpDown nudMaxLevel;
        private System.Windows.Forms.Label lblMaxLevel;
        private DarkComboBox cmbLevelMaxAnimation;
        private DarkComboBox cmbLevelUpAnimation;
        private System.Windows.Forms.Label lblLevelMaxAnimation;
        private System.Windows.Forms.Label lblLevelUpAnimation;
        private DarkButton btnUpdateExpGrid;
        private DarkComboBox cmbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblOrder;
        private DarkNumericUpDown nudOrder;
    }
}
