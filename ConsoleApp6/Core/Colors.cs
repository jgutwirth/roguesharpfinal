using RLNET;

namespace ConsoleApp6.Core
{
    public static class Colors
    {
        public static RLColor FloorBackground = RLColor.Black;
        public static RLColor Floor = Swatch.DbVegetation;
        public static RLColor FloorBackgroundFov = Swatch.DbDark;
        public static RLColor FloorFov = Swatch.DbGrass;

        public static RLColor WallBackground = Swatch.SecondaryDarkest;
        public static RLColor Wall = Swatch.Secondary;
        public static RLColor WallBackgroundFov = Swatch.SecondaryDarker;
        public static RLColor WallFov = Swatch.DbStone;

        public static RLColor DoorBackground = Swatch.ComplimentDarkest;
        public static RLColor Door = Swatch.ComplimentLighter;
        public static RLColor DoorBackgroundFov = Swatch.ComplimentDarker;
        public static RLColor DoorFov = Swatch.ComplimentLightest;

        public static RLColor StairsBackground = Swatch.AlternateDarkest;
        public static RLColor Stairs = Swatch.DbWood;
        public static RLColor StairsBackgroundFov = Swatch.AlternateDarker;
        public static RLColor StairsFov = Swatch.DbBrightWood;

        public static RLColor TextHeading = RLColor.White;
        public static RLColor Text = Swatch.DbLight;
        public static RLColor Gold = Swatch.DbSun;
        public static RLColor Player = Swatch.DbSkin;

        public static RLColor KoboldColor = Swatch.DbBrightWood;
        public static RLColor GoblinColor = Swatch.DbGrass;
        public static RLColor SlimeColor = Swatch.DbDeepWater;
    }
}
