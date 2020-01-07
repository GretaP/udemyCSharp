using System;

namespace IntermediatePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
/*            DbConnection connectionSql = new SqlConnection("nyan kittie");
            connectionSql.Open();
            DbConnection connectionOracle = new OracleConnection("Tell us the way of the world oh oracle");
            connectionOracle.Open();
            connectionOracle.Close();*/

            try
            {

                var connectionEmpty = new SqlConnection("");
                //var connectionEmpty = new SqlConnection();
                connectionEmpty.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
