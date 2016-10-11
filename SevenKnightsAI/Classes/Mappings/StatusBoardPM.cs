using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class StatusBoardPM
    {
        public static readonly PixelMapping LeftTabCon = new PixelMapping
        {
            X = 264,
            Y = 14,
            Color = 10713909,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping RightTabCol = new PixelMapping
        {
            X = 675,
            Y = 21,
            Color = 8086064,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping ContentsTab = new PixelMapping
        {
            X = 320,
            Y = 112,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping ContentsTabSelect = new PixelMapping
        {
            X = 223,
            Y = 96,
            Color = 13929220,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping HottimeTabSelect = new PixelMapping
        {
            X = 471,
            Y = 95,
            Color = 13995013,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping HottimeTab = new PixelMapping
        {
            X = 476,
            Y = 112,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping HeroRateTab = new PixelMapping
        {
            X = 740,
            Y = 112,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping HottimeRedIcon = new PixelMapping
        {
            X = 367,
            Y = 77,
            Color = 13051905,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ActiveButtonColor = new PixelMapping
        {
            X = 763,
            Y = 520,
            Color = 7481868,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping StatusBar = new PixelMapping
        {
            X = 198,
            Y = 516,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ActiveHottimeButton = new PixelMapping
        {
            X = 760,
            Y = 510,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping ConfirmOKtick = new PixelMapping
        {
            X = 540,
            Y = 397,
            Color = 16760352,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping NoRedCloss = new PixelMapping
        {
            X = 316,
            Y = 394,
            Color = 14171656,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 540,
            Y = 400,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping ClosButton = new PixelMapping
        {
            X = 860,
            Y = 48,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}
