using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
    class Program
    {
        private static void Main(string[] args)
        {
            
            ColorPairMappingTests.GetColorFromPairNumberTest(4, new ColorPair(Color.White, Color.Brown));
            ColorPairMappingTests.GetColorFromPairNumberTest(5, new ColorPair(Color.White, Color.SlateGray));
            ColorPairMappingTests.GetColorFromPairNumberTest(23, new ColorPair(Color.Violet, Color.Green));

            ColorPairMappingTests.GetPairNumberFromColorTest(new ColorPair(Color.Yellow, Color.Green), 18);
            ColorPairMappingTests.GetPairNumberFromColorTest(new ColorPair(Color.Red, Color.Blue), 6);
        }
    }
}
