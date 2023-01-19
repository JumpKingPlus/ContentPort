using JumpKing;
using JumpKingPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKPort.DataStructure
{
    public static class Converter
    {
        public static SetSettings ToSet(WardrobeSettings p_settings)
        {
            SetSettings settings = new SetSettings();

            settings.enabled = p_settings.collection.Value.enabled;
            settings.Reskins = p_settings.collection.Value.Reskins;

            return settings;
        }

        public static ReskinSettings ToSkin(WardrobeSettings p_settings)
        {
            ReskinSettings settings = new ReskinSettings();

            settings.enabled = p_settings.enabled.Value;
            settings.skin = p_settings.skin.Value;
            settings.name = p_settings.name;

            return settings;
        }

        public static LevelSettings ToLevel(Mod p_settings)
        {
            LevelSettings settings = new LevelSettings();

            #region about
            settings.About.title = p_settings.About.title;
            settings.About.ending_screen = p_settings.About.ending_screen;
            settings.About.ending_screen_second = p_settings.About.ending_screen_nbp;
            settings.About.ending_screen_third = p_settings.About.ending_screen_owl;
            if (p_settings.About.StartingPosition.HasValue)
            {
                var startdata = new JumpKing.StartPosition();
                
                var position = 
                    new Vector2(
                        p_settings.About.StartingPosition.Value.positionX, 
                        p_settings.About.StartingPosition.Value.positionY
                    );

                if (p_settings.About.StartingPosition.Value.velocityX.HasValue
                    && p_settings.About.StartingPosition.Value.velocityY.HasValue)
                {
                    var velocity = new Vector2(
                        p_settings.About.StartingPosition.Value.velocityX.Value,
                        p_settings.About.StartingPosition.Value.velocityY.Value
                    );
                    startdata.Velocity = velocity;
                }

                startdata.Position = position;
                settings.About.StartData = startdata;
            }
            #endregion

            #region ending
            settings.Ending.MainBabe = p_settings.Ending.MainBabe;

            settings.Ending.MainItem = new ItemEnding();
            settings.Ending.MainItem.item = Items.Shoes;
            settings.Ending.MainItem.image = p_settings.Ending.MainShoes;

            settings.Ending.SecondBabe = p_settings.Ending.NBPBabe;

            settings.Ending.SecondItem = new ItemEnding();
            settings.Ending.SecondItem.item = Items.GiantBoots;
            settings.Ending.SecondItem.image = p_settings.Ending.NBPShoes;

            settings.Ending.ThirdBabe = p_settings.Ending.OwlBabe;

            settings.Ending.ThirdItem = new ItemEnding();
            settings.Ending.ThirdItem.item = Items.CapeOwl;
            settings.Ending.ThirdItem.image = p_settings.Ending.OwlBird;
            #endregion

            #region endinglines
            List<JumpKing.Credit> new_credits = new List<JumpKing.Credit>();
            foreach (JumpKingPlus.Credit credit in p_settings.EndingLines)
            {
                var new_credit = new JumpKing.Credit();
                new_credit.header = credit.header;
                new_credit.people = credit.People;
                new_credits.Add(new_credit);
            }
            settings.EndingLines = new_credits.ToArray();
            #endregion

            return settings;
        }
    }
}
