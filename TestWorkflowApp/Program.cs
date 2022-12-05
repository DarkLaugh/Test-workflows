namespace TestWorkflowApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var env = args[0];
            var specificDatabaseName = args[1];

            Console.WriteLine($"Executing on {env} environment. Running migrations on - {specificDatabaseName} database.");
        }
    }
}