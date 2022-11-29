using System.Data.SqlTypes;

namespace TestWorkflowApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var env = args[0];
            var specificDatabaseName = args[1];
            bool.TryParse(args[2], out bool throwException);

            if (throwException)
            {
                throw new SqlNullValueException("Missing value for ID column");
            }

            Console.WriteLine($"Executing on {env} environment. Running migrations on - {specificDatabaseName} database.");
        }
    }
}