using JumpKing;

namespace JumpKingPlus
{
    #region wardrobe
    public struct Reskin
    {
        public Items skin;
        public string name;
    }

    public struct Collection
    {
        public string name;
        public string description;
        public bool enabled;
        public Reskin[] Reskins;
    }

    public struct WardrobeSettings
    {
        public bool isCollection;
        public Items? skin;
        public string name;
        public string description;
        public bool? enabled;
        public Collection? collection;
    }
    #endregion

    #region level
    public struct Mod
    {
        public About About;
        public Compatibility Compatibility;
        public Fonts Fonts;
        public Ending Ending;
        public Credit[] EndingLines;
    }

    public struct About
    {
        public string title;
        public string image_key;
        public LevelColor? LevelColor;
        public int ending_screen;
        public int? ending_screen_nbp;
        public int? ending_screen_owl;
        public bool disableProgress;
        public StartPosition? StartingPosition;
    }

    public struct LevelColor
    {
        public byte red;
        public byte green;
        public byte blue;
        public byte alpha;
    }

    public struct StartPosition
    {
        public float positionX;
        public float positionY;
        public float? velocityX;
        public float? velocityY;
        public bool? isOnGround;
    }

    public struct Compatibility
    {
        public string minimum_version;
        public string maximum_version;
    }

    public struct Fonts
    {
        public string MenuFont;
        public string MenuFontSmall;
        public string StyleFont;
        public string OptimusUnderline;
        public string Tangerine;
        public string LocationFont;
        public string GargoyleFont;
    }

    public struct Ending
    {
        public string MainBabe;
        public string MainShoes;
        public string NBPBabe;
        public string NBPShoes;
        public string OwlBabe;
        public string OwlBird;
    }

    public struct Credit
    {
        public string header;
        public string[] People;
    }
    #endregion
}