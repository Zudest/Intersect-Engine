using System;
using System.Windows.Forms;

using Intersect.Editor.Localization;
using Intersect.GameObjects;
using Intersect.GameObjects.Events.Commands;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandChangeSkillLevel : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private ChangeSkillLevelCommand mMyCommand;

        public EventCommandChangeSkillLevel(ChangeSkillLevelCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;
            if (mMyCommand.Level <= 0 || mMyCommand.Level > Options.MaxLevel)
            {
                mMyCommand.Level = 1;
            }

            cmbSkill.Items.Clear();
            cmbSkill.Items.AddRange(SkillBase.Names);
            cmbSkill.SelectedIndex = SkillBase.ListIndex(mMyCommand.SkillId);

            nudLevel.Maximum = Options.MaxLevel;
            nudLevel.Value = mMyCommand.Level;
            InitLocalization();
        }

        private void InitLocalization()
        {
            lblSkill.Text = Strings.EventChangeSkills.skill;
            grpChangeLevel.Text = Strings.EventChangeSkillLevel.title;
            lblLevel.Text = Strings.EventChangeSkillLevel.label;
            btnSave.Text = Strings.EventChangeSkillLevel.okay;
            btnCancel.Text = Strings.EventChangeSkillLevel.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.SkillId = SkillBase.IdFromList(cmbSkill.SelectedIndex);
            mMyCommand.Level = (int) nudLevel.Value;
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

    }

}
