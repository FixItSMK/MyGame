using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class OutOfKeysOfferPM
    {
        public static readonly PixelMapping BuyButton = new PixelMapping
        {
            X = 532,
            Y = 398,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping BuyButtonBorder = new PixelMapping
        {
            X = 532,
            Y = 398,
            Color = 16759838,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 60,
            Y = 27,
            Color = 3805699,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 316,
            Y = 393,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RedCross = new PixelMapping
        {
            X = 316,
            Y = 393,
            Color = 14433544,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SkipTodayButton = new PixelMapping
        {
            X = 715,
            Y = 408,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}