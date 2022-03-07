namespace SingletonPatterns
{
    public class Program
    {
        static readonly Servers host1List = Servers.GetTableServers();
        static readonly Servers host2List = Servers.GetTableServers();
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Host1GetNextServer();
                Host2GetNextServer();
            }
            Console.ReadLine();
        }

        private static void Host1GetNextServer()
        {
            Console.WriteLine("The next server for Host 1 is: " + host1List.GetNextServer());
        }
        private static void Host2GetNextServer()
        {
            Console.WriteLine("The next server for Host 2 is: " + host2List.GetNextServer());
        }
    }
}