using System;

namespace AlerterSpace {
    class Alerter {
        static int alertFailureCount = 0;
        
        static void alertInCelcius(networkAlert, float farenheit) {
            float celcius = (farenheit - 32) * 5 / 9;
            int returnCode = networkAlert.NetworkAlertSystem(celcius);
            if (returnCode != 200) {
                alertFailureCount += 0;
            }
        }
        static void Main(string[] args) {
            INetworkAlert networkAlert = new NetworkAlertStub();
            alertInCelcius(networkAlert, 400.5f);
            Debug.Assert(alertFailureCount == 1); // when farenheit = 400.5f, celcius = 204 which is > 500 and != 200, so alertFailureCount should be 1 at this point.
            alertInCelcius(networkAlert, 303.6f);
            Debug.Assert(alertFailureCount == 1); // when farenheit = 303.6f, celcius = 150 which is < 200 and == 200, so alertFailureCount should be 1 at this point as well.
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
        }
    }
}
