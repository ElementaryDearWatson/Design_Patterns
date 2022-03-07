namespace SingletonPatterns
{
    internal class ServerNonSingleton
    {
        private Dictionary<int, string> tableServers = new Dictionary<int, string>();
        private int nextServer = 0;

        public ServerNonSingleton()
        {
            tableServers.Add(1, "Bob");
            tableServers.Add(2, "Tim");
            tableServers.Add(3, "Manny");
            tableServers.Add(4, "Mary");
            tableServers.Add(5, "Katie");
        }

        public string GetNextServer()
        {
            string output = tableServers.ElementAt(nextServer).Value;
            nextServer += 1;
            if (nextServer >= tableServers.Count)
            {
                nextServer = 0;
            }
            return output;
        }
    }
}
