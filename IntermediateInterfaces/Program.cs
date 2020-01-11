using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IntermediateInterfaces
{
    /// <summary>
    /// Mock Workflow engine with WriteLine implementation rather than actual tasks
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
/*            var testing = new VideoUpload();

            IActivity[] testing2 =
            {
                new VideoUpload(),
                new SendEmail(),
                new VideoRecordChange()
            };*/


            try
            {
/*                var workflow1 = new WorkflowEngine(testing, new SendEmail(), new VideoRecordChange());
                workflow1.Run();
                var workflow2 = new WorkflowEngine(testing2);
                workflow2.Run();*/
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Operation aborted");
            }



/*
            var workflowtest = new WorkFlowList();
            workflowtest.Add(new SendEmail());
            workflowtest.Add(new VideoRecordChange());
            var hello = workflowtest.GetWorkflow();
            var workflowEngine1 = new WorkflowEngine(hello);
            workflowEngine1.Run();
*/



            try
            {
                var workflowtest2 = new WorkFlowList();
                workflowtest2.GetWorkflow();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                
            }


        }
    }
}

