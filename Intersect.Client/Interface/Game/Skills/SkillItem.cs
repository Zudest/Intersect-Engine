using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.GenericClasses;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.Framework.Gwen.Input;
using Intersect.Client.Framework.Input;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.Client.Networking;
using Intersect.GameObjects;
using Intersect.Client.Interface.Game.Spells;

namespace Intersect.Client.Interface.Game.Skills
{

    public class SkillItem
    {

        public ImagePanel Container;

        private Guid mCurrentSkillId;

        private SkillDescWindow mDescWindow;

        private bool mMouseOver;

        private SkillsWindow mSkillWindow;

        private string mTexLoaded = "";

        private int mYindex;
        public ImagePanel Pnl;

        public SkillItem(SkillsWindow skillWindow, int index)
        {
            mSkillWindow = skillWindow;
            mYindex = index;
        }

        public void Setup()
        {
            Pnl = new ImagePanel(Container, "SkillIcon");
            Pnl.HoverEnter += pnl_HoverEnter;
            Pnl.HoverLeave += pnl_HoverLeave;
        }

        void pnl_HoverLeave(Base sender, EventArgs arguments)
        {
            mMouseOver = false;
            if (mDescWindow != null)
            {
                mDescWindow.Dispose();
                mDescWindow = null;
            }
        }

        void pnl_HoverEnter(Base sender, EventArgs arguments)
        {
            if (InputHandler.MouseFocus != null)
            {
                return;
            }

            mMouseOver = true;

            if (mDescWindow != null)
            {
                mDescWindow.Dispose();
                mDescWindow = null;
            }

            mDescWindow = new SkillDescWindow(
                Globals.Me.Skills[mYindex].SkillId,
                Globals.Me.Skills[mYindex].Level,
                Globals.Me.Skills[mYindex].Experience,
                Globals.Me.Skills[mYindex].Status,
                mSkillWindow.X,
                mSkillWindow.Y);
        }

        public FloatRect RenderBounds()
        {
            var rect = new FloatRect()
            {
                X = Pnl.LocalPosToCanvas(new Point(0, 0)).X,
                Y = Pnl.LocalPosToCanvas(new Point(0, 0)).Y,
                Width = Pnl.Width,
                Height = Pnl.Height
            };

            return rect;
        }

        public void Update()
        {
            var skill = SkillBase.Get(Globals.Me.Skills[mYindex].SkillId);
            if (mTexLoaded != "" && skill == null ||
                 skill != null && mTexLoaded != skill.Icon ||
                 mCurrentSkillId != Globals.Me.Skills[mYindex].SkillId)
            {
                if (skill != null)
                {
                    var skillTex = Globals.ContentManager.GetTexture(Framework.Content.TextureType.Spell, skill.Icon); //TextureType.Spell or TextureType.Skill?? //ZUDEST
                    if (skillTex != null)
                    {
                        Pnl.Texture = skillTex;
                        Pnl.RenderColor = new Color(255, 255, 255, 255);
                    }
                    else
                    {
                        if (Pnl.Texture != null)
                        {
                            Pnl.Texture = null;
                        }
                    }

                    mTexLoaded = skill.Icon;
                    mCurrentSkillId = Globals.Me.Skills[mYindex].SkillId;
                }
                else
                {
                    if (Pnl.Texture != null)
                    {
                        Pnl.Texture = null;
                    }

                    mTexLoaded = "";
                }
            }
        }

    }

}