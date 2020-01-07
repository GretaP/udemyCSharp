using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace IntermediatePolymorphism
{
    public abstract class DbConnection
    {
        public DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString)) throw new InvalidOperationException("You can not connect with and empty connection string; connection failed.");
            ConnectionString = connectionString;
        }

        protected string ConnectionString { get; }
        protected TimeSpan TimeOut { get; set; }
        
        public abstract void Open();
        public abstract void Close();
    }

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
    }

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
    }
}
