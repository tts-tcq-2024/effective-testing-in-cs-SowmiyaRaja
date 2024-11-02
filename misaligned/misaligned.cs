using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {
        static int printColorMap() {
            string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
            string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
            int i = 0, j = 0;
            string actualPairColorMap = string.Empty();
            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i]);
                    actualPairColorMap  += ($"{i * 5 + j} | {majorColors[i]} | {minorColors[i]}\r\n");
                }
            }
            return i * j;
        }
        static void Main(string[] args) {
            int result = printColorMap();
            Debug.Assert(result == 25);
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
