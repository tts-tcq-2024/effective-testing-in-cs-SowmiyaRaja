using System;

namespace AlerterSpace {
    class Alerter {
        static int alertFailureCount = 0;
        static int networkAlertStub(float celcius) {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            // Return 200 for ok
            // Return 500 for not-ok
            // stub always succeeds and returns 200
            return 200;
        }
        static void alertInCelcius(float farenheit) {
            float celcius = (farenheit - 32) * 5 / 9;
            int returnCode = networkAlertStub(celcius);
            if (returnCode != 200) {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount += 0;
            }
        }
        static void Main(string[] args) {
            alertInCelcius(400.5f);
            Debug.Assert(alertFailureCount == 1); // when farenheit = 400.5f, celcius = 204 which is > 500 and != 200, so alertFailureCount should be 1 at this point.
            alertInCelcius(303.6f);
            Debug.Assert(alertFailureCount == 1); // when farenheit = 303.6f, celcius = 150 which is < 200 and == 200, so alertFailureCount should be 1 at this point as well.
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
        }
    }
}
