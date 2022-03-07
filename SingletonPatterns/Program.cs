namespace SingletonPatterns
{
    public class Program
    {
        static readonly ServerSingleton host1List = ServerSingleton.GetTableServers();
        static readonly ServerSingleton host2List = ServerSingleton.GetTableServers();

        //what if you need two use cases of the 
        static ServerNonSingleton hostListNonSingleton1 = new ServerNonSingleton();
        static ServerNonSingleton hostListNonSingleton2 = new ServerNonSingleton();
        public static void Main(string[] args)
        {
            ServerNonSingleton serverNonSingleton = new ServerNonSingleton();
            for (int i = 0; i < 10; i++)
            {
                ////Non-singleton instance
                //Console.WriteLine("The next server is:" + serverNonSingleton.GetNextServer());
                //HostListNonSingleton1();
                //HostListNonSingleton2();

                //Singleton instances
                Host1GetNextServer();
                Host2GetNextServer();
            }
            Console.ReadLine();
        }

        private static void HostListNonSingleton1()
        {
            Console.WriteLine("The next server for Host1 is: " +hostListNonSingleton1.GetNextServer());
        }
        private static void HostListNonSingleton2()
        {
            Console.WriteLine("The next server for Host2 is: " +hostListNonSingleton2.GetNextServer());
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