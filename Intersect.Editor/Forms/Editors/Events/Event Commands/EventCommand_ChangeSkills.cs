using System;
using System.Windows.Forms;

using Intersect.Editor.Localization;
using Intersect.GameObjects;
using Intersect.GameObjects.Events;
using Intersect.GameObjects.Events.Commands;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandChangeSkills : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private EventPage mCurrentPage;

        private ChangeSkillsCommand mMyCommand;

        public EventCommandChangeSkills(ChangeSkillsCommand refCommand, EventPage refPage, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;
            mCurrentPage = refPage;
            InitLocalization();
            cmbSkill.Items.Clear();
            cmbSkill.Items.AddRange(SkillBase.Names);
            cmbAction.SelectedIndex = refCommand.Add ? 0 : 1;
            cmbSkill.SelectedIndex = SkillBase.ListIndex(mMyCommand.SkillId);
        }

        private void InitLocalization()
        {
            grpChangeSkills.Text = Strings.EventChangeSkills.title;
            cmbAction.Items.Clear();
            for (var i = 0; i < Strings.EventChangeSkills.actions.Count; i++)
            {
                cmbAction.Items.Add(Strings.EventChangeSkills.actions[i]);
            }

            lblAction.Text = Strings.EventChangeSkills.action;
            lblSkill.Text = Strings.EventChangeSkills.skill;
            btnSave.Text = Strings.EventChangeSkills.okay;
            btnCancel.Text = Strings.EventChangeSkills.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.Add = !Convert.ToBoolean(cmbAction.SelectedIndex);
            mMyCommand.SkillId = SkillBase.IdFromList(cmbSkill.SelectedIndex);
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

    }

}
