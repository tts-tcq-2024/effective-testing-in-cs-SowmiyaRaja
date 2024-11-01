namespace AlerterSpace
{
    public interface INetworkAlert
    {
        int NetworkAlertSystem(float celsius);
    }

    public class NetworkAlertStub : INetworkAlert
    {
        public int NetworkAlertSystem(float celsius)
        {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            return 500;
        }
    }

    public class NetworkAlert : INetworkAlert
    {
        public int NetworkAlertSystem(float celsius)
        {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            return 200;
        }
    }
}

