using System;

namespace IntermediatePolymorphism
{
    public abstract class DbConnection
    {
        /// <summary>
        /// Base class.  Has properties ConnectionString and Timeout, and checks if string param is null/empty
        /// </summary>
        /// <param name="connectionString"></param>
        public DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString)) throw new InvalidOperationException("You can not connect with and empty connection string; connection failed.");
            ConnectionString = connectionString;
        }

        protected string ConnectionString { get; }
        protected TimeSpan TimeOut { get; set; }
        
        public abstract void Open();
        public abstract void Close();
        public abstract void Execute(string command);
    }

    /// <summary>
    /// Inherited from DbConnection.  ConsoleWriteLine specific to SQL in overwritten methods
    /// </summary>
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("SQL connection opened (let's pretend!) {0}.  TimeoutValue is: {1}", ConnectionString, TimeOut);
        }

        public override void Close()
        {
            Console.WriteLine("SQL Closed Let's pretend");
        }

        public override void Execute(string command)
        {
            Console.WriteLine("This is the command in T-SQL language, if there were any logic here: {0}",command);
        }
    }

    /// <summary>
    /// Inherited from DbConnection.  ConsoleWriteLine specific to Oracle in overwritten methods
    /// </summary>
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Oracle connection opened (let's pretend!) {0}", ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("Oracle Closed Let's pretend");
        }

        public override void Execute(string command)
        {
            Console.WriteLine(command);
        }
    }
}
