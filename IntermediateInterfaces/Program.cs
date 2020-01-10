using System;

namespace IntermediateInterfaces
{
    /// <summary>
    /// Mock Workflow engine with WriteLine implementation rather than actual tasks
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var testing = new VideoUpload();

            try
            {
                var workflow1 = new WorkflowEngine(testing, new SendEmail(), new VideoRecordChange());
                workflow1.Run();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Operation aborted");
            }
        }
    }
}

