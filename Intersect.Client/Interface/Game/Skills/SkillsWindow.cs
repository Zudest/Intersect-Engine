using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.GenericClasses;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.GameObjects;

namespace Intersect.Client.Interface.Game.Skills
{

    public class SkillsWindow
    {

        //Skill List
        public List<SkillItem> Items = new List<SkillItem>();

        //Initialized
        private bool mInitializedSkills;

        //Item/Skill Rendering
        private ScrollControl mItemContainer;

        private List<Label> mTextLevel = new List<Label>();

        private List<Label> mTextMaxLevel = new List<Label>();

        //Controls
        private WindowControl mSkillWindow;

        //Location
        public int X;

        public int Y;

        //Init
        public SkillsWindow(Canvas gameCanvas)
        {
            mSkillWindow = new WindowControl(gameCanvas, Strings.Skills.title, false, "SkillsWindow");
            mSkillWindow.DisableResizing();

            mItemContainer = new ScrollControl(mSkillWindow, "SkillsContainer");
            mItemContainer.EnableScroll(false, true);
            mSkillWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
        }

        //Methods
        public void Update()
        {
            if (!mInitializedSkills)
            {
                InitItemContainer();
                mInitializedSkills = true;
            }

            if (mSkillWindow.IsHidden == true)
            {
                return;
            }

            X = mSkillWindow.X;
            Y = mSkillWindow.Y;

            for (var i = 0; i < Options.MaxSkillSlots; i++)
            {
                if (Globals.Me.Skills[i].SkillId != Guid.Empty)
                {
                    //we check if the skill is class exclusive to hide it
                    var activeSkill = SkillBase.Get(Globals.Me.Skills[i].SkillId);
                    if (activeSkill != null)
                    {
                        if (activeSkill.Class != null && activeSkill.ClassId != Globals.Me.Class)
                        {
                            Items[i].Pnl.IsHidden = true;
                            mTextLevel[i].IsHidden = true;
                            mTextMaxLevel[i].IsHidden = true;
                            continue;
                        }
                    }

                    Items[i].Pnl.IsHidden = false;
                    mTextLevel[i].IsHidden = false;
                    mTextLevel[i].Text = Globals.Me.Skills[i].Level.ToString();
                    mTextMaxLevel[i].IsHidden = false;
                    mTextMaxLevel[i].Text = activeSkill.MaxLevel.ToString();
                    Items[i].Update();
                }
                else
                {
                    Items[i].Pnl.IsHidden = true;
                    mTextLevel[i].IsHidden = true;
                    mTextMaxLevel[i].IsHidden = true;
                }
            }

        }

        private void InitItemContainer()
        {
            for (var i = 0; i < Options.MaxSkillSlots; i++)
            {
                Items.Add(new SkillItem(this, i));
                Items[i].Container = new ImagePanel(mItemContainer, "Skill");
                Items[i].Setup();

                mTextLevel.Add(new Label(Items[i].Container, "SkillTextLevel"));
                mTextLevel[i].Text = "";

                mTextMaxLevel.Add(new Label(Items[i].Container, "SkillTextMaxLevel"));
                mTextMaxLevel[i].Text = "";

                Items[i].Container.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());

                var xPadding = Items[i].Container.Margin.Left + Items[i].Container.Margin.Right;
                var yPadding = Items[i].Container.Margin.Top + Items[i].Container.Margin.Bottom;
                Items[i]
                    .Container.SetPosition(
                        i %
                        (mItemContainer.Width / (Items[i].Container.Width + xPadding)) *
                        (Items[i].Container.Width + xPadding) +
                        xPadding,
                        i /
                        (mItemContainer.Width / (Items[i].Container.Width + xPadding)) *
                        (Items[i].Container.Height + yPadding) +
                        yPadding
                    );
            }
        }

        public void Show()
        {
            mSkillWindow.IsHidden = false;
        }

        public bool IsVisible()
        {
            return !mSkillWindow.IsHidden;
        }

        public void Hide()
        {
            mSkillWindow.IsHidden = true;
        }

        public FloatRect RenderBounds()
        {
            var rect = new FloatRect()
            {
                X = mSkillWindow.LocalPosToCanvas(new Point(0, 0)).X -
                    (Items[0].Container.Padding.Left + Items[0].Container.Padding.Right) / 2,
                Y = mSkillWindow.LocalPosToCanvas(new Point(0, 0)).Y -
                    (Items[0].Container.Padding.Top + Items[0].Container.Padding.Bottom) / 2,
                Width = mSkillWindow.Width + Items[0].Container.Padding.Left + Items[0].Container.Padding.Right,
                Height = mSkillWindow.Height + Items[0].Container.Padding.Top + Items[0].Container.Padding.Bottom
            };

            return rect;
        }

    }

}