using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class QuestSelectPM
    {
        #region Public Fields

        public static readonly PixelMapping QuestAvailable = new PixelMapping
        {
            X = 515,
            Y = 223,
            Color = 13051905,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestButton = new PixelMapping
        {
            X = 558,
            Y = 270,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestIcon = new PixelMapping
        {
            X = 576,
            Y = 274,
            Color = 14796387,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SpecialQuestAvailable = new PixelMapping
        {
            X = 360,
            Y = 224,
            Color = 13051905,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SpecialQuestButton = new PixelMapping
        {
            X = 402,
            Y = 270,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SpecialQuestIcon = new PixelMapping
        {
            X = 400,
            Y = 265,
            Color = 12153660,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TitleBorderLeft = new PixelMapping
        {
            X = 268,
            Y = 180,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TitleBorderRight = new PixelMapping
        {
            X = 690,
            Y = 180,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        #endregion Public Fields
    }
}