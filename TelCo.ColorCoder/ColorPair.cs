using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public class ColorPair
    {

        public static Color[] MapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
        public static Color[] MapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };

        public Color Major;
        public Color Minor;

        public ColorPair(Color majorColor, Color minorColor)
        {
            Major = majorColor;
            Minor = minorColor;
        }
        
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", Major.Name, Minor.Name);
        }

    }
}
