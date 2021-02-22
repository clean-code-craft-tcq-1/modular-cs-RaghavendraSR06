using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public partial class ColorPair
    {
       
        public static Color[] MapMajor;
        public static Color[] MapMinor;

        internal Color Major;
        internal Color Minor;
       
        /// <summary>
        /// Given a pair number function returns the major and minor colors in that order
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched</param>
        /// <returns></returns>
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = MapMinor.Length;
            int majorSize = MapMajor.Length;

            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    $"Argument PairNumber:{pairNumber} is outside the allowed range");
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
