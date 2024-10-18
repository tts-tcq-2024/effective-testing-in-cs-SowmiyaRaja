using System;
using System.Diagnostics;

namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if(cms < 38) {
                return "S";
            } else if(cms > 38 && cms < 42) {
                return "M";
            } else {
                return "L";
            }
        }
        static void Main(string[] args) {
            Debug.Assert(Size(37) == "S"); // test to verify Small size
            Debug.Assert(Size(40) == "M"); // test to verify Medium size
            Debug.Assert(Size(43) == "L"); // test to verify Large size
            Debug.Assert(Size(38) == "M"); //test to verify Small size 38
            Debug.Assert(Size(-1) == "Invalid negative value"); // test to verify negative size
            Debug.Assert(Size(1000) == "Invalid Out of range size"); // test to verify very biiger size which is not valid.
            Console.WriteLine( "All is well (maybe!)");
        }
    }
}
