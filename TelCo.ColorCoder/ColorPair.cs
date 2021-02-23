using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public partial class ColorPair
    {

        public static Color[] MapMajor, MapMinor;
        internal Color Major, Minor;

        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", Major.Name, Minor.Name);
        }

        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = MapMinor.Length;
            int majorSize = MapMajor.Length;

            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            // Find index of major and minor color from pair number
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            ColorPair pair = new ColorPair()
            {
                Major = MapMajor[majorIndex],
                Minor = MapMinor[minorIndex]
            };

            return pair;
        }
    }
}
