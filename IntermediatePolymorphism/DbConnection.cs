using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace IntermediatePolymorphism
{
    public abstract class DbConnection
    {
        //public string ConnectionString { get; set; }
        //public TimeSpan Timeout { get; set; }

        public abstract void Open();
        public abstract void Close();

/*        public DbConnection(string connectionString)
        {
           // if (connectionString.IsNull)

        }*/
    }

    public class SqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("SQL connection opened (let's pretend!) {0}");
        }

        public override void Close()
        {
            Console.WriteLine("SQL Closed Let's pretend");
        }
    }
}
