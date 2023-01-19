
namespace JumpKing
{
    public enum Items
    {
        Crown,
        Shoes,
        GoldRing,

        CrownNBP,
        Ruby,
        SnakeRing,
        GiantBoots,
        Silver,

        Cap,

        GnomeHat,
        Tunic,
        YellowShoes,

        CrownOwl,
        CapeOwl,

        BabeGhostItem,
        GhostFragment,
        Shroom,

        BugNote,

        NULL
    };

    #region fallback
    public struct Vector2
    {
        public float X;
        public float Y;

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }
    }

    public struct Credit
    {
        public string header;
        public string[] people;
    }
    #endregion

    #region level
    public struct LevelSettings
    {
        public About About;
        public Ending Ending;
        public Credit[] EndingLines;
    }

    public struct About
    {
        public string title;
        public int ending_screen;
        public int? ending_screen_second;
        public int? ending_screen_third;
        public StartPosition? StartData;
    }

    public struct StartPosition
    {
        public Vector2? Position;
        public Vector2? Velocity;
    }

    public struct Ending
    {
        public string MainBabe;
        public ItemEnding MainItem;
        public string SecondBabe;
        public ItemEnding SecondItem;
        public string ThirdBabe;
        public ItemEnding ThirdItem;
    }

    public struct ItemEnding
    {
        public Items item;
        public string image;
    }
    #endregion

    #region skin
    public struct ReskinSettings
    {
        public Items skin;
        public string name;
        public bool enabled;
    }
    #endregion

    #region set
    public struct SetSettings
    {
        public bool enabled;
        public Reskin[] Reskins;
    }

    public struct Reskin
    {
        public Items skin;
        public string name;
    }
    #endregion
}