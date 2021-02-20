using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    public class ColorPair
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        public static Color[] MapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        public static Color[] MapMinor;
        /// <summary>
        /// data type defined to hold the two colors of color pair
        /// </summary>
        /// 
        internal Color Major;
        internal Color Minor;
        public override string ToString()
        {
            return $"MajorColor:{Major.Name}, MinorColor:{Minor.Name}";
        }

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
        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            var majorColorIndex = GetColorIndex(pair.Major, MapMajor);

            var minorColorIndex = GetColorIndex(pair.Minor, MapMinor);

            if (majorColorIndex == -1 || minorColorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair));
            }

            return (majorColorIndex * MapMinor.Length) + (minorColorIndex + 1);
        }

        /// <summary>
        /// Get the color index based on colorPair
        /// </summary>
        /// <param name="pair">color pair</param>
        /// <param name="colorMap">color map</param>
        /// <returns>color index</returns>
        public static int GetColorIndex(Color pair, Color[] colorMap)
        {
            int index = -1;
            for (int i = 0; i < colorMap.Length; i++)
            {
                if (colorMap[i] == pair)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
