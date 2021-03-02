using System;
using System.Drawing;
using System.Linq;

namespace TelCo.ColorCoder
{
    public class ColorMapper
    {
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = ColorPair.MapMinor.Length;
            int majorSize = ColorPair.MapMajor.Length;

            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            ColorPair pair = new ColorPair(ColorPair.MapMajor[majorIndex], ColorPair.MapMinor[minorIndex]);
            return pair;
        }
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorColorIndex = Array.FindIndex(ColorPair.MapMajor, item => item == pair.Major);
            int minorColorIndex = Array.FindIndex(ColorPair.MapMinor, item => item == pair.Minor);

            if (majorColorIndex == -1 || minorColorIndex == -1)
            {
                throw new ArgumentException($"Unknown Colors: {pair}");
            }
            return (majorColorIndex * ColorPair.MapMinor.Length) + (minorColorIndex + 1);
        }
    }
}
