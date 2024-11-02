namespace MisalignedSpace
{
    public class MisalignedUnitTest
    {
        public static void PairColorMapPrintVerification()
        {
            string expectedPairColorMap;
            bool isColorMapCorrect, isColorMapCountCorrect;
            
            int ColorMapCount = Misaligned.PrintColorMap();
            expectedPairColorMap = GenerateExpectedOutput();

            isColorMapCorrect = Debug.Equals(Misaligned.actualPairColorMap, expectedPairColorMap);
            isColorMapCountCorrect = Debug.Equals(25, ColorMapCount);

            if (!isColorMapCorrect || !isColorMapCountCorrect)
                Console.WriteLine("Test failed, Either pair color map or pair count is not correct.");
            else
                Console.WriteLine("Test passed.");
        }

        private static string GeneratePairColorMap()
        {
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            string output = string.Empty();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    output += $"{i * 5 + j} | {majorColors[i]} | {minorColors[j]}\r\n";
            }
            return output;
        }
    }
}
