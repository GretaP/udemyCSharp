using System;

namespace IntermediatePolymorphism
{
    class DbCommand
    {
        private string Instruction { get;}
        private DbConnection Connection { get; }

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null || instruction == null) throw new InvalidOperationException("There must be a connection in order to execute a DbCommand.  Command failed.");
            Instruction = instruction;
            Connection = connection;
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine(Instruction);
            Connection.Close();
        }

    }
}
