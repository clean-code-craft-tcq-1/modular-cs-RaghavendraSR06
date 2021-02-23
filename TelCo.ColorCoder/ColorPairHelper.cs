using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public partial  class ColorPair
    {
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorColorIndex = GetColorIndex(pair.Major, MapMajor);

            int minorColorIndex = GetColorIndex(pair.Minor, MapMinor);

            if (majorColorIndex == -1 || minorColorIndex == -1)
            {
                throw new ArgumentException($"Unknown Colors: {pair}");
            }

            return (majorColorIndex * MapMinor.Length) + (minorColorIndex + 1);
        }

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
