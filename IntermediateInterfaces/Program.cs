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
            var workFlow = new WorkFlowList();

            while (true)
            {
                try
                {
                    Console.WriteLine(
                        "------------\nMenu: \nV to add VideoUpload to workflow \nC to add change video record to workflow \nE to add email to workflow.  \nS to see your current workflow  \nN to create a new workflow from scratch \nR to run workflow \nesc to end program \n-----------------");
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.Escape:
                            return;
                        case ConsoleKey.V:
                            workFlow.Add(new VideoUpload());
                            Console.Clear();
                            Console.WriteLine("Added VideoUpload to workflow.");
                            break;
                        case ConsoleKey.C:
                            workFlow.Add(new VideoRecordChange());
                            Console.Clear();
                            Console.WriteLine("Added VideoRecordChange to workflow.");
                            break;
                        case ConsoleKey.E:
                            workFlow.Add(new SendEmail());
                            Console.Clear();
                            Console.WriteLine("Added SendEmail to workflow.");
                            break;
                        case ConsoleKey.N:
                            workFlow = new WorkFlowList();
                            Console.Clear();
                            Console.WriteLine("Cleared the workflow");
                            break;
                        case ConsoleKey.S:
                            var getList = workFlow.GetWorkflow();
                            Console.Clear();
                            foreach (var activity in getList)
                            {
                                Console.WriteLine(activity);
                            }
                            break;
                        case ConsoleKey.R:
                            Console.Clear();
                            Console.WriteLine("-----------------------\nRunning workflow");
                            var engine = new WorkflowEngine(workFlow.GetWorkflow());
                            engine.Run();
                            Console.WriteLine("-----------------------");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid entry - try again");
                            break;
                    }

                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"{e.Message}\nOperation aborted\n------------");
                }
            }
        }
    }
}

