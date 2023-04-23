using System;
using System.Windows.Forms;

using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Events.Commands;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandGiveSkillExperience : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private GiveSkillExperienceCommand mMyCommand;

        public EventCommandGiveSkillExperience(GiveSkillExperienceCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;
            InitLocalization();

            rdoVariable.Checked = mMyCommand.UseVariable;
            rdoGlobalVariable.Checked = mMyCommand.VariableType == VariableType.ServerVariable;

            cmbSkill.Items.Clear();
            cmbSkill.Items.AddRange(SkillBase.Names);
            cmbSkill.SelectedIndex = SkillBase.ListIndex(mMyCommand.SkillId);

            SetupAmountInput();
        }

        private void InitLocalization()
        {
            grpGiveExperience.Text = Strings.EventGiveSkillExperience.title;
            lblExperience.Text = Strings.EventGiveSkillExperience.label;

            lblVariable.Text = Strings.EventGiveSkillExperience.Variable;

            grpAmountType.Text = Strings.EventGiveSkillExperience.AmountType;
            rdoManual.Text = Strings.EventGiveSkillExperience.Manual;
            rdoVariable.Text = Strings.EventGiveSkillExperience.Variable;

            grpManualAmount.Text = Strings.EventGiveSkillExperience.Manual;
            grpVariableAmount.Text = Strings.EventGiveSkillExperience.Variable;

            rdoPlayerVariable.Text = Strings.EventGiveSkillExperience.PlayerVariable;
            rdoGlobalVariable.Text = Strings.EventGiveSkillExperience.ServerVariable;

            lblSkill.Text = Strings.EventChangeSkills.skill;

            btnSave.Text = Strings.EventGiveSkillExperience.okay;
            btnCancel.Text = Strings.EventGiveSkillExperience.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.SkillId = SkillBase.IdFromList(cmbSkill.SelectedIndex);
            mMyCommand.Exp = (long) nudExperience.Value;
            mMyCommand.VariableType = rdoPlayerVariable.Checked ? VariableType.PlayerVariable : VariableType.ServerVariable;
            mMyCommand.UseVariable = !rdoManual.Checked;
            mMyCommand.VariableId = rdoPlayerVariable.Checked ? PlayerVariableBase.IdFromList(cmbVariable.SelectedIndex, VariableDataType.Integer) : ServerVariableBase.IdFromList(cmbVariable.SelectedIndex, VariableDataType.Integer);
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

        private void rdoManual_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInput();
        }

        private void rdoVariable_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInput();
        }

        private void rdoPlayerVariable_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInput();
        }

        private void rdoGlobalVariable_CheckedChanged(object sender, EventArgs e)
        {
            SetupAmountInput();
        }

        private void VariableBlank()
        {
            if (cmbVariable.Items.Count > 0)
            {
                cmbVariable.SelectedIndex = 0;
            }
            else
            {
                cmbVariable.SelectedIndex = -1;
                cmbVariable.Text = "";
            }
        }

        private void SetupAmountInput()
        {
            grpManualAmount.Visible = rdoManual.Checked;
            grpVariableAmount.Visible = !rdoManual.Checked;

            cmbVariable.Items.Clear();
            if (rdoPlayerVariable.Checked)
            {
                cmbVariable.Items.AddRange(PlayerVariableBase.GetNamesByType(VariableDataType.Integer));
                // Do not update if the wrong type of variable is saved
                if (mMyCommand.VariableType == VariableType.PlayerVariable)
                {
                    var index = PlayerVariableBase.ListIndex(mMyCommand.VariableId, VariableDataType.Integer);
                    if (index > -1)
                    {
                        cmbVariable.SelectedIndex = index;
                    }
                    else
                    {
                        VariableBlank();
                    }
                }
                else
                {
                    VariableBlank();
                }
            }
            else
            {
                cmbVariable.Items.AddRange(ServerVariableBase.GetNamesByType(VariableDataType.Integer));
                // Do not update if the wrong type of variable is saved
                if (mMyCommand.VariableType == VariableType.ServerVariable)
                {
                    var index = ServerVariableBase.ListIndex(mMyCommand.VariableId, VariableDataType.Integer);
                    if (index > -1)
                    {
                        cmbVariable.SelectedIndex = index;
                    }
                    else
                    {
                        VariableBlank();
                    }
                }
                else
                {
                    VariableBlank();
                }
            }

            nudExperience.Value = Math.Max(1, mMyCommand.Exp);
        }
    }
}
