using System;
using System.Diagnostics;

namespace TelCo.ColorCoder
{
    public class ColorPairMappingTests
    {
        public static void GetColorFromPairNumberTest(int pairNumber, ColorPair colorPair)
        {
            ColorPair testPair1 = ColorMapper.GetColorFromPairNumber(pairNumber);
            DisplayColorPair(pairNumber, colorPair);
            Debug.Assert(testPair1.Major == colorPair.Major);
            Debug.Assert(testPair1.Minor == colorPair.Minor);
        }
        public static void GetPairNumberFromColorTest(ColorPair colorPair, int number)
        {
            ColorPair testPair2 = new ColorPair(colorPair.Major, colorPair.Minor);
            int pairNumber = ColorMapper.GetPairNumberFromColor(testPair2);
            DisplayColorPair(colorPair, pairNumber);
            Debug.Assert(pairNumber == number);
        }

        private static void DisplayColorPair(int pairNumber, ColorPair colorPair)
        {
            Console.WriteLine(string.Format("[In]Pair Number: {0},[Out] Colors: {1}", pairNumber, colorPair));
        }
        private static void DisplayColorPair(ColorPair colorPair, int pairNumber)
        {
            Console.WriteLine(string.Format("[In]Colors: {0}, [Out] PairNumber: {1}", colorPair, pairNumber));
        }
    }
}
