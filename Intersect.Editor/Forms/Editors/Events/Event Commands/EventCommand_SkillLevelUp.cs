using System;
using System.Windows.Forms;

using Intersect.Editor.Localization;
using Intersect.GameObjects;
using Intersect.GameObjects.Events.Commands;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandSkillLevelUp : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private SkillLevelUpCommand mMyCommand;

        public EventCommandSkillLevelUp(SkillLevelUpCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;

            cmbSkill.Items.Clear();
            cmbSkill.Items.AddRange(SkillBase.Names);
            cmbSkill.SelectedIndex = SkillBase.ListIndex(mMyCommand.SkillId);

            InitLocalization();
        }

        private void InitLocalization()
        {
            lblSkill.Text = Strings.EventChangeSkills.skill;
            grpSkillLevelUp.Text = Strings.EventSkillLevelUp.title;
            btnSave.Text = Strings.EventSkillLevelUp.okay;
            btnCancel.Text = Strings.EventSkillLevelUp.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.SkillId = SkillBase.IdFromList(cmbSkill.SelectedIndex);
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

    }

}
