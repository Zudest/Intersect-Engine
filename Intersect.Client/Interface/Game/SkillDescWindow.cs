using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.Enums;
using Intersect.GameObjects;

namespace Intersect.Client.Interface.Game
{
    public class SkillDescWindow
    {

        ImagePanel mDescWindow;

        public SkillDescWindow(
            Guid skillId,
            int playerLevel,
            long playerExperience,
            int playerStatus,
            int x,
            int y,
            bool centerHorizontally = false)
        {
            var skill = SkillBase.Get(skillId);
            if (skill == null)
            {
                return;
            }

            mDescWindow = new ImagePanel(Interface.GameUi.GameCanvas, "SkillDescWindow"); //SkillDescWindowExpanded

            var icon = new ImagePanel(mDescWindow, "SkillIcon");

            var skillName = new Label(mDescWindow, "SkillName");
            skillName.Text = skill.Name;

            var skillDesc = new RichLabel(mDescWindow, "SkillDesc");
            var skillDescText = new Label(mDescWindow, "SkillDescText");
            skillDescText.Font = skillDescText.Parent.Skin.DefaultFont;
            skillDescText.IsHidden = true;

            //Load this up now so we know what color to make the text when filling out the desc
            mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());

            //Level
            skillDesc.AddText(
                    Strings.SkillDesc.skilllevel.ToString(playerLevel, skill.MaxLevel), skillDesc.RenderColor,
                    skillDescText.CurAlignments.Count > 0 ? skillDescText.CurAlignments[0] : Alignments.Left,
                    skillDescText.Font
                );
            skillDesc.AddLineBreak();

            //Experience
            skillDesc.AddText(
                    Strings.SkillDesc.experience.ToString(playerExperience, skill.ExperienceToNextLevel(playerLevel + 1)), skillDesc.RenderColor,
                    skillDescText.CurAlignments.Count > 0 ? skillDescText.CurAlignments[0] : Alignments.Left,
                    skillDescText.Font
                );
            skillDesc.AddLineBreak();
            skillDesc.AddLineBreak();

            //Description
            if (skill.Description.Length > 0)
            {
                skillDesc.AddText(
                    Strings.SkillDesc.desc.ToString(skill.Description), skillDesc.RenderColor,
                    skillDescText.CurAlignments.Count > 0 ? skillDescText.CurAlignments[0] : Alignments.Left,
                    skillDescText.Font
                );

                skillDesc.AddLineBreak();
                skillDesc.AddLineBreak();
            }


            //Load Again for positioning purposes.
            mDescWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
            skillDescText.IsHidden = true;
            skillDescText.IsHidden = true;
            icon.Texture = Globals.ContentManager.GetTexture(Framework.Content.TextureType.Spell, skill.Icon); //TextureType.Spell or TextureType.Skill??
            if (centerHorizontally)
            {
                mDescWindow.MoveTo(x - mDescWindow.Width / 2, y + mDescWindow.Padding.Top);
            }
            else
            {
                mDescWindow.MoveTo(x - mDescWindow.Width - mDescWindow.Padding.Right, y + mDescWindow.Padding.Top);
            }
        }

        public void Dispose()
        {
            if (mDescWindow == null)
            {
                return;
            }

            Interface.GameUi.GameCanvas.RemoveChild(mDescWindow, false);
            mDescWindow.Dispose();
        }

    }

}