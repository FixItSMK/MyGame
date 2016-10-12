using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ShopPM
    {
        //จุดที่ใช้ตรวจสอบว่าใช่หน้า Shop ไหม
        public static readonly PixelMapping borderleft = new PixelMapping
        {
            // ที่ห้อง
            //X = 259,
            //Y = 157,
            //Color = 12661028,
            //ที่ทำงาน
            X = 323,
            Y = 143,
            Color = 4311087,
            Type = MappingType.ANCHOR
        };

        //จุดที่ใช้ตรวจสอบว่าใช่หน้า Shop ไหม
        public static readonly PixelMapping Mimic = new PixelMapping
        {
            // ที่ห้อง
            //X = 829,
            //Y = 89,
            //Color = 10310986,
            //ที่ทำงาน
            X = 828,
            Y = 90,
            Color = 11162967,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CommonShop = new PixelMapping
        {
            X = 490,
            Y = 270,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ShopCommon = new PixelMapping
        {
            X = 457,
            Y = 142,
            Color = 9926221,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ShopPackge = new PixelMapping
        {
            X = 145,
            Y = 221,
            Color = 16053492,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping KeyTab = new PixelMapping
        {
            X = 110,
            Y = 90,
            Color = 0,
            Type = MappingType.BUTTON
        };


        public static readonly int GOLD_OFFSET_X = 268;
        public static readonly int GOLD_OFFSET_Y = 0;
        public static readonly int HONOR_OFFSET_X = 269;
        public static readonly int HONOR_OFFSET_Y = 0;
        public static readonly int KEY_OFFSET_X = 266;
        public static readonly int KEY_OFFSET_Y = 0;
        public static readonly int RUBY_OFFSET_X = 269;
        public static readonly int RUBY_OFFSET_Y = 0;

        public static readonly PixelMapping Key1Honor10 = new PixelMapping
        {
            X = 310,
            Y = 390,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Key5Ruby10 = new PixelMapping
        {
            X = 515,
            Y = 390,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Key10Honor100 = new PixelMapping
        {
            X = 721,
            Y = 390,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Key10Ruby20 = new PixelMapping
        {
            X = 242,
            Y = 390,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Key20Ruby35 = new PixelMapping
        {
            X = 422,
            Y = 390,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Key40Ruby45 = new PixelMapping
        {
            X = 627,
            Y = 390,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Key100Ruby100 = new PixelMapping
        {
            X = 854,
            Y = 326,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping KeyTabLeftMost = new PixelMapping
        {
            X = 247,
            Y = 507,
            Color = 6432294,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping KeyTabRightMost = new PixelMapping
        {
            X = 854,
            Y = 326,
            Color = 15559504,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping KeyTabSelected = new PixelMapping
        {
            X = 110,
            Y = 68,
            Color = 13797636,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ScrollAreaLeft = new PixelMapping
        {
            X = 220,
            Y = 360,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ScrollAreaRight = new PixelMapping
        {
            X = 920,
            Y = 360,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}