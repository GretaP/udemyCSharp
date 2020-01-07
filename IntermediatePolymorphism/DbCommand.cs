using System;

namespace IntermediatePolymorphism
{
    /// <summary>
    /// Pretends to send a command to the "database" by using the connection to access methods in the Connection class.
    /// Behavior will depend on connection type
    /// </summary>
    class DbCommand
    {
        private string Instruction { get;}
        private DbConnection Connection { get; }

        /// <summary>
        /// Sets instruction and connection as properties, and checks that the params are not null
        /// </summary>
        /// <param name="connection">Database connection, instantiated earlier in main program</param>
        /// <param name="instruction">Currently just a string that hopefully will make you laugh</param>
        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null || String.IsNullOrEmpty(instruction) ) throw new InvalidOperationException("There must be a connection in order to execute a DbCommand.  Command failed.");
            Instruction = instruction;
            Connection = connection;
        }

        /// <summary>
        /// Calls methods in Connection, demonstrating polymorphism
        /// </summary>
        public void Execute()
        {
            Connection.Open();
            Connection.Execute(Instruction);
            Connection.Close();
        }

    }
}
