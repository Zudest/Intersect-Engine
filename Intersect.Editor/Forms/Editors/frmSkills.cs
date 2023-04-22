using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using DarkUI.Forms;
using Intersect.Editor.Content;
using Intersect.Editor.General;
using Intersect.Editor.Localization;
using Intersect.Editor.Networking;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using Intersect.Models;
using Intersect.Utilities;

//<ZUDEST>

namespace Intersect.Editor.Forms.Editors
{

    public partial class FrmSkills : EditorForm
    {

        private List<SkillBase> mChanged = new List<SkillBase>();

        private string mCopiedItem;

        private SkillBase mEditorItem;

        private List<string> mKnownFolders = new List<string>();

        public FrmSkills()
        {
            ApplyHooks();
            InitializeComponent();
            lstGameObjects.LostFocus += itemList_FocusChanged;
            lstGameObjects.GotFocus += itemList_FocusChanged;
            //cmbType.Items.Clear();
            //cmbType.Items.Add(Strings.General.none);
            //cmbType.Items.AddRange(ItemBase.Names);

            lstGameObjects.Init(UpdateToolStripItems, AssignEditorItem, toolStripItemNew_Click, toolStripItemCopy_Click, toolStripItemUndo_Click, toolStripItemPaste_Click, toolStripItemDelete_Click);
        }
        private void AssignEditorItem(Guid id)
        {
            mEditorItem = SkillBase.Get(id);
            UpdateEditor();
        }

        protected override void GameObjectUpdatedDelegate(GameObjectType type)
        {
            if (type == GameObjectType.Skills)
            {
                InitEditor();
                if (mEditorItem != null && !DatabaseObject<SkillBase>.Lookup.Values.Contains(mEditorItem))
                {
                    mEditorItem = null;
                    UpdateEditor();
                }
            }
        }

        private void UpdateEditor()
        {
            if (mEditorItem != null)
            {
                pnlContainer.Show();

                txtName.Text = mEditorItem.Name;
                cmbFolder.Text = mEditorItem.Folder;
                txtDesc.Text = mEditorItem.Description;

                cmbLevelUpAnimation.SelectedIndex = AnimationBase.ListIndex(mEditorItem.LevelUpAnimationId) + 1;
                cmbLevelMaxAnimation.SelectedIndex = AnimationBase.ListIndex(mEditorItem.LevelMaxAnimationId) + 1;
                cmbClass.SelectedIndex = ClassBase.ListIndex(mEditorItem.ClassId) + 1;

                cmbIcon.SelectedIndex = cmbIcon.FindString(TextUtils.NullToNone(mEditorItem.Icon));
                picSkill.BackgroundImage?.Dispose();
                picSkill.BackgroundImage = null;
                if (cmbIcon.SelectedIndex > 0)
                {
                    picSkill.BackgroundImage = Image.FromFile("resources/spells/" + cmbIcon.Text);
                }

                nudMaxLevel.Value = mEditorItem.MaxLevel;
                nudOrder.Value = mEditorItem.Order;

                nudBaseExp.Value = mEditorItem.BaseExp;
                nudExpIncrease.Value = mEditorItem.ExpIncrease;

                if (mChanged.IndexOf(mEditorItem) == -1)
                {
                    mChanged.Add(mEditorItem);
                    mEditorItem.MakeBackup();
                }
            }
            else
            {
                pnlContainer.Hide();
            }

            UpdateToolStripItems();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            mEditorItem.Name = txtName.Text;
            lstGameObjects.UpdateText(txtName.Text);
        }
                
        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (var item in mChanged)
            {
                item.RestoreBackup();
                item.DeleteBackup();
            }

            Hide();
            Globals.CurrentEditor = -1;
            Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Send Changed items
            foreach (var item in mChanged)
            {
                PacketSender.SendSaveObject(item);
                item.DeleteBackup();
            }

            Hide();
            Globals.CurrentEditor = -1;
            Dispose();
        }

        private void toolStripItemNew_Click(object sender, EventArgs e)
        {
            PacketSender.SendCreateObject(GameObjectType.Skills);
        }

        private void toolStripItemDelete_Click(object sender, EventArgs e)
        {
            if (mEditorItem != null && lstGameObjects.Focused)
            {
                if (DarkMessageBox.ShowWarning(
                        Strings.SkillsEditor.deleteprompt, Strings.SkillsEditor.deletetitle, 
                        DarkDialogButton.YesNo, Icon
                    ) ==
                    DialogResult.Yes)
                {
                    PacketSender.SendDeleteObject(mEditorItem);
                }
            }
        }

        private void toolStripItemCopy_Click(object sender, EventArgs e)
        {
            if (mEditorItem != null && lstGameObjects.Focused)
            {
                mCopiedItem = mEditorItem.JsonData;
                toolStripItemPaste.Enabled = true;
            }
        }

        private void toolStripItemPaste_Click(object sender, EventArgs e)
        {
            if (mEditorItem != null && mCopiedItem != null && lstGameObjects.Focused)
            {
                mEditorItem.Load(mCopiedItem, true);
                UpdateEditor();
            }
        }

        private void toolStripItemUndo_Click(object sender, EventArgs e)
        {
            if (mChanged.Contains(mEditorItem) && mEditorItem != null)
            {
                if (DarkMessageBox.ShowWarning(
                        Strings.SkillsEditor.undoprompt, Strings.SkillsEditor.undotitle, 
                        DarkDialogButton.YesNo,Icon
                    ) ==
                    DialogResult.Yes)
                {
                    mEditorItem.RestoreBackup();
                    UpdateEditor();
                }
            }
        }

        private void itemList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Z)
                {
                    toolStripItemUndo_Click(null, null);
                }
                else if (e.KeyCode == Keys.V)
                {
                    toolStripItemPaste_Click(null, null);
                }
                else if (e.KeyCode == Keys.C)
                {
                    toolStripItemCopy_Click(null, null);
                }
            }
            else
            {
                if (e.KeyCode == Keys.Delete)
                {
                    toolStripItemDelete_Click(null, null);
                }
            }
        }

        private void UpdateToolStripItems()
        {
            toolStripItemCopy.Enabled = mEditorItem != null && lstGameObjects.Focused;
            toolStripItemPaste.Enabled = mEditorItem != null && mCopiedItem != null && lstGameObjects.Focused;
            toolStripItemDelete.Enabled = mEditorItem != null && lstGameObjects.Focused;
            toolStripItemUndo.Enabled = mEditorItem != null && lstGameObjects.Focused;
        }

        private void itemList_FocusChanged(object sender, EventArgs e)
        {
            UpdateToolStripItems();
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.N)
                {
                    toolStripItemNew_Click(null, null);
                }
            }
        }
        
        private void frmSkills_Load(object sender, EventArgs e)
        {
            cmbLevelUpAnimation.Items.Clear();
            cmbLevelUpAnimation.Items.Add(Strings.General.None);
            cmbLevelUpAnimation.Items.AddRange(AnimationBase.Names);

            cmbLevelMaxAnimation.Items.Clear();
            cmbLevelMaxAnimation.Items.Add(Strings.General.None);
            cmbLevelMaxAnimation.Items.AddRange(AnimationBase.Names);

            cmbClass.Items.Clear();
            cmbClass.Items.Add(Strings.General.None);
            cmbClass.Items.AddRange(ClassBase.Names);

            cmbIcon.Items.Clear();
            cmbIcon.Items.Add(Strings.General.None);
            var skillNames = GameContentManager.GetSmartSortedTextureNames(GameContentManager.TextureType.Spell); //uses spell folder for icons
            cmbIcon.Items.AddRange(skillNames);

            InitLocalization();
        }

        private void InitLocalization()
        {
            Text = Strings.SkillsEditor.title;
            toolStripItemNew.Text = Strings.SkillsEditor.New;
            toolStripItemDelete.Text = Strings.SkillsEditor.delete;
            toolStripItemCopy.Text = Strings.SkillsEditor.copy;
            toolStripItemPaste.Text = Strings.SkillsEditor.paste;
            toolStripItemUndo.Text = Strings.SkillsEditor.undo;

            grpSkills.Text = Strings.SkillsEditor.skills;

            //Left Side
            grpGeneral.Text = Strings.SkillsEditor.general;
            lblName.Text = Strings.SkillsEditor.name;
            lblDescription.Text = Strings.SkillsEditor.skilldesc;

            //Right Side
            lblIcon.Text = Strings.SkillsEditor.icon;
            lblLevelUpAnimation.Text = Strings.SkillsEditor.levelupanimation;
            lblLevelMaxAnimation.Text = Strings.SkillsEditor.levelmaxanimation;
            lblMaxLevel.Text = Strings.SkillsEditor.skillmaxlevel;
            lblClass.Text = Strings.SkillsEditor.skillclass;

            //Exp Grid
            grpExpGrid.Text = Strings.SkillsEditor.experiencegrid;
            btnResetExpGrid.Text = Strings.SkillsEditor.resetgrid;
            lblBaseExp.Text = Strings.SkillsEditor.levelexp;
            lblExpIncrease.Text = Strings.SkillsEditor.levelexpscale;

            //Create EXP Grid...
            var levelCol = new DataGridViewTextBoxColumn();
            levelCol.HeaderText = Strings.SkillsEditor.gridlevel;
            levelCol.ReadOnly = true;
            levelCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            var tnlCol = new DataGridViewTextBoxColumn();
            tnlCol.HeaderText = Strings.SkillsEditor.gridtnl;
            tnlCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            var totalCol = new DataGridViewTextBoxColumn();
            totalCol.HeaderText = Strings.SkillsEditor.gridtotalexp;
            totalCol.ReadOnly = true;
            totalCol.SortMode = DataGridViewColumnSortMode.NotSortable;

            expGrid.Columns.Clear();
            expGrid.Columns.Add(levelCol);
            expGrid.Columns.Add(tnlCol);
            expGrid.Columns.Add(totalCol);

            //Searching/Sorting
            btnAlphabetical.ToolTipText = Strings.SkillsEditor.sortalphabetically;
            txtSearch.Text = Strings.SkillsEditor.searchplaceholder;
            lblFolder.Text = Strings.SkillsEditor.folderlabel;

            btnSave.Text = Strings.SkillsEditor.save;
            btnCancel.Text = Strings.SkillsEditor.cancel;
        }

        private void nudMaxLevel_ValueChanged(object sender, EventArgs e)
        {
            // This should never be below 1.
            nudMaxLevel.Value = Math.Max(1, nudMaxLevel.Value);
            mEditorItem.MaxLevel = (int)nudMaxLevel.Value;
        }

        private void nudOrder_ValueChanged(object sender, EventArgs e)
        {
            // This should never be below 1.
            nudOrder.Value = Math.Max(1, nudOrder.Value);
            mEditorItem.Order = (int)nudOrder.Value;
        }

        private void cmbIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            mEditorItem.Icon = cmbIcon.Text;
            picSkill.BackgroundImage?.Dispose();
            picSkill.BackgroundImage = null;
            picSkill.BackgroundImage = cmbIcon.SelectedIndex > 0
                ? Image.FromFile("resources/spells/" + cmbIcon.Text)
                : null;
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            mEditorItem.Description = txtDesc.Text;
        }

        private void FrmSkills_FormClosed(object sender, FormClosedEventArgs e)
        {
            Globals.CurrentEditor = -1;
        }

        private void cmbLevelUpAnimation_SelectedIndexChanged(object sender, EventArgs e)
        {
            mEditorItem.LevelUpAnimation = AnimationBase.Get(AnimationBase.IdFromList(cmbLevelUpAnimation.SelectedIndex - 1));
        }

        private void cmbLevelMaxAnimation_SelectedIndexChanged(object sender, EventArgs e)
        {
            mEditorItem.LevelMaxAnimation = AnimationBase.Get(AnimationBase.IdFromList(cmbLevelMaxAnimation.SelectedIndex - 1));
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            mEditorItem.Class = ClassBase.Get(ClassBase.IdFromList(cmbClass.SelectedIndex - 1));
        }

        #region "Exp Grid"

        private void btnUpdateExpGrid_Click(object sender, EventArgs e)
        {
            expGrid.Rows.Clear();

            for (var i = 1; i <= mEditorItem.MaxLevel; i++)
            {
                var index = expGrid.Rows.Add(i.ToString(), "", "");
                var row = expGrid.Rows[index];
                row.Cells[0].Style.SelectionBackColor = row.Cells[0].Style.BackColor;
                row.Cells[2].Style.SelectionBackColor = row.Cells[2].Style.BackColor;
            }

            UpdateExpGridValues(1);
        }

        private void UpdateExpGridValues(int start, int end = -1)
        {
            if (end == -1)
            {
                end = mEditorItem.MaxLevel;
            }

            if (start > end)
            {
                return;
            }

            if (start < 1)
            {
                start = 1;
            }

            for (var i = start; i <= end; i++)
            {
                if (i < mEditorItem.MaxLevel)
                {
                    if (mEditorItem.ExperienceOverrides.ContainsKey(i))
                    {
                        expGrid.Rows[i - 1].Cells[1].Value = Convert.ChangeType(
                            mEditorItem.ExperienceOverrides[i], expGrid.Rows[i - 1].Cells[1].ValueType
                        );

                        var style = expGrid.Rows[i - 1].Cells[1].InheritedStyle;
                        style.Font = new Font(style.Font, FontStyle.Bold);
                        expGrid.Rows[i - 1].Cells[1].Style.ApplyStyle(style);
                    }
                    else
                    {
                        expGrid.Rows[i - 1].Cells[1].Value = Convert.ChangeType(
                            mEditorItem.ExperienceCurve.Calculate(i), expGrid.Rows[i - 1].Cells[1].ValueType
                        );

                        expGrid.Rows[i - 1].Cells[1].Style.ApplyStyle(expGrid.Rows[i - 1].Cells[0].InheritedStyle);
                    }
                }
                else
                {
                    expGrid.Rows[i - 1].Cells[1].Value = Convert.ChangeType(0, expGrid.Rows[i - 1].Cells[1].ValueType);
                    expGrid.Rows[i - 1].Cells[1].ReadOnly = true;
                }

                if (i == 1)
                {
                    expGrid.Rows[i - 1].Cells[2].Value = Convert.ChangeType(0, expGrid.Rows[i - 1].Cells[1].ValueType);
                }
                else
                {
                    expGrid.Rows[i - 1].Cells[2].Value = Convert.ChangeType(
                        long.Parse(expGrid.Rows[i - 2].Cells[2].Value.ToString()) +
                        long.Parse(expGrid.Rows[i - 2].Cells[1].Value.ToString()),
                        expGrid.Rows[i - 1].Cells[2].ValueType
                    );
                }
            }
        }

        private void expGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right &&
                expGrid.CurrentCell != null &&
                expGrid.CurrentCell.IsInEditMode == false)
            {
                var cell = expGrid.CurrentCell;
                if (cell != null)
                {
                    var r = cell.DataGridView.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, false);
                    var p = new System.Drawing.Point(r.X + r.Width, r.Y + r.Height);
                    //mnuExpGrid.Show((DataGridView)sender, p);
                }
            }
        }

        private void expGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (expGrid.Rows.Count <= 0)
            {
                return;
            }

            var sel = expGrid.SelectedCells;
            if (sel.Count == 0)
            {
                expGrid.Rows[0].Cells[1].Selected = true;
            }
            else
            {
                var selection = sel[0];
                if (selection.ColumnIndex != 1)
                {
                    expGrid.Rows[selection.RowIndex].Cells[1].Selected = true;
                }
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            try
            {
                var s = Clipboard.GetText();
                var lines = s.Split('\n');
                int iFail = 0, iRow = expGrid.CurrentCell.RowIndex;
                var iCol = expGrid.CurrentCell.ColumnIndex;
                DataGridViewCell oCell;
                foreach (var line in lines)
                {
                    if (iRow < expGrid.RowCount && line.Length > 0)
                    {
                        var sCells = line.Split('\t');
                        for (var i = 0; i < 1; ++i)
                        {
                            if (iCol + i < this.expGrid.ColumnCount)
                            {
                                oCell = expGrid[iCol + i, iRow];
                                if (!oCell.ReadOnly)
                                {
                                    if (oCell.Value.ToString() != sCells[i])
                                    {
                                        var val = 0;
                                        if (int.TryParse(sCells[i], out val))
                                        {
                                            if (val > 0)
                                            {
                                                oCell.Value = Convert.ChangeType(val.ToString(), oCell.ValueType);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        iFail++;
                                    }

                                    //only traps a fail if the data has changed 
                                    //and you are pasting into a read only cell
                                }
                            }
                            else
                            {
                                break;
                            }
                        }

                        iRow++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void expGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(expGrid_KeyPress);
            var tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(expGrid_KeyPress);
            }
        }

        private void expGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void expGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cell = expGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            long val = 0;
            if (long.TryParse(cell.Value.ToString(), out val))
            {
                if (val == 0 || val == mEditorItem.ExperienceCurve.Calculate(e.RowIndex + 1))
                {
                    if (mEditorItem.ExperienceOverrides.ContainsKey(e.RowIndex + 1))
                    {
                        mEditorItem.ExperienceOverrides.Remove(e.RowIndex + 1);
                    }
                }
                else
                {
                    if (!mEditorItem.ExperienceOverrides.ContainsKey(e.RowIndex + 1))
                    {
                        mEditorItem.ExperienceOverrides.Add(e.RowIndex + 1, val);
                    }
                    else
                    {
                        mEditorItem.ExperienceOverrides[e.RowIndex + 1] = val;
                    }
                }

                UpdateExpGridValues(e.RowIndex + 1);
            }
            else
            {
                UpdateExpGridValues(e.RowIndex + 1, e.RowIndex + 2);
            }
        }

        private void btnResetExpGrid_Click(object sender, EventArgs e)
        {
            mEditorItem.ExperienceOverrides.Clear();
            UpdateExpGridValues(1);
        }

        private void expGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (expGrid.CurrentCell != null)
                {
                    if (!expGrid.CurrentCell.IsInEditMode && expGrid.CurrentCell.ReadOnly == false)
                    {
                        var level = expGrid.CurrentCell.RowIndex + 1;
                        if (mEditorItem.ExperienceOverrides.ContainsKey(level))
                        {
                            mEditorItem.ExperienceOverrides.Remove(level);
                        }

                        UpdateExpGridValues(level);
                    }
                }
            }
        }

        #endregion


        #region "Item List - Folders, Searching, Sorting, Etc"

        public void InitEditor()
        {
            //Collect folders
            var mFolders = new List<string>();
            foreach (var itm in SkillBase.Lookup)
            {
                if (!string.IsNullOrEmpty(((SkillBase) itm.Value).Folder) &&
                    !mFolders.Contains(((SkillBase) itm.Value).Folder))
                {
                    mFolders.Add(((SkillBase) itm.Value).Folder);
                    if (!mKnownFolders.Contains(((SkillBase) itm.Value).Folder))
                    {
                        mKnownFolders.Add(((SkillBase) itm.Value).Folder);
                    }
                }
            }

            mFolders.Sort();
            mKnownFolders.Sort();
            cmbFolder.Items.Clear();
            cmbFolder.Items.Add("");
            cmbFolder.Items.AddRange(mKnownFolders.ToArray());

            var items = SkillBase.Lookup.OrderBy(p => p.Value?.Name).Select(pair => new KeyValuePair<Guid, KeyValuePair<string, string>>(pair.Key,
                new KeyValuePair<string, string>(((SkillBase)pair.Value)?.Name ?? Models.DatabaseObject<SkillBase>.Deleted, ((SkillBase)pair.Value)?.Folder ?? ""))).ToArray();
            lstGameObjects.Repopulate(items, mFolders, btnAlphabetical.Checked, CustomSearch(), txtSearch.Text);
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            var folderName = "";
            var result = DarkInputBox.ShowInformation(
                Strings.SkillsEditor.folderprompt, Strings.SkillsEditor.foldertitle, ref folderName,
                DarkDialogButton.OkCancel
            );

            if (result == DialogResult.OK && !string.IsNullOrEmpty(folderName))
            {
                if (!cmbFolder.Items.Contains(folderName))
                {
                    mEditorItem.Folder = folderName;
                    lstGameObjects.ExpandFolder(folderName);
                    InitEditor();
                    cmbFolder.Text = folderName;
                }
            }
        }

        private void cmbFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            mEditorItem.Folder = cmbFolder.Text;
            InitEditor();
        }

        private void btnAlphabetical_Click(object sender, EventArgs e)
        {
            btnAlphabetical.Checked = !btnAlphabetical.Checked;
            InitEditor();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            InitEditor();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = Strings.SkillsEditor.searchplaceholder;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
            txtSearch.Focus();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = Strings.SkillsEditor.searchplaceholder;
        }

        private bool CustomSearch()
        {
            return !string.IsNullOrWhiteSpace(txtSearch.Text) &&
                   txtSearch.Text != Strings.SkillsEditor.searchplaceholder;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == Strings.SkillsEditor.searchplaceholder)
            {
                txtSearch.SelectAll();
            }
        }

        #endregion

    }

}
