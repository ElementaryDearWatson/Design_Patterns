namespace SingletonPatterns
{
    internal class ServerSingleton
    {
        private static readonly ServerSingleton _instance = new ServerSingleton();
        private Dictionary<int, string> tableServers = new Dictionary<int, string>();
        private int nextServer = 0;

        private ServerSingleton()
        {
            tableServers.Add(1, "Bob");
            tableServers.Add(2, "Tim");
            tableServers.Add(3, "Manny");
            tableServers.Add(4, "Mary");
            tableServers.Add(5, "Katie");
        }

        public static ServerSingleton GetTableServers()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            string output = tableServers.ElementAt(nextServer).Value;
            nextServer+=1;
            if (nextServer >= tableServers.Count)
            {
                nextServer = 0;
            }
            return output;
        }
    }
}
