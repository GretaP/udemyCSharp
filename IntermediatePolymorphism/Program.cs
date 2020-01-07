using System;

namespace IntermediatePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnection connectionSql = new SqlConnection("nyan kittie");
            DbConnection connectionOracle = new OracleConnection("Tell us the way of the world oh oracle");

            //example of Commands
            DbCommand obey = new DbCommand(connectionOracle, "obey me");
            obey.Execute();

            DbCommand sing = new DbCommand(connectionSql, "Sing your little cat song");
            sing.Execute();


            //Example of exception handled in case of null string
/*            try
            {
                var connectionEmpty = new SqlConnection("");
                //var connectionEmpty = new SqlConnection();
                connectionEmpty.Open();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }*/
            
            //example of exception handling in Command class
/*            try
            {
                DbCommand mistake = new DbCommand(connectionSql, "");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }*/


        }
    }
}
