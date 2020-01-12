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
                    Console.WriteLine("------------");
                    Console.WriteLine("Menu");
                    Console.WriteLine("V to add VideoUpload to workflow ");
                    Console.WriteLine("C to add change video record to workflow");
                    Console.WriteLine("E to add email to workflow.");
                    Console.WriteLine("S to see your current workflow");
                    Console.WriteLine("N to create a new workflow from scratch");
                    Console.WriteLine("R to run workflow");
                    Console.WriteLine("esc to end program");
                    Console.WriteLine("-----------------");

                    var key = Console.ReadKey(true);
                    Console.Clear();

                    switch (key.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.V:
                            workFlow.Add(new VideoUpload());
                            Console.WriteLine("Added VideoUpload to workflow.");
                            break;
                        case ConsoleKey.C:
                            workFlow.Add(new VideoRecordChange());
                            Console.WriteLine("Added VideoRecordChange to workflow.");
                            break;
                        case ConsoleKey.E:
                            workFlow.Add(new SendEmail());
                            Console.WriteLine("Added SendEmail to workflow.");
                            break;
                        case ConsoleKey.N:
                            workFlow = new WorkFlowList();
                            Console.WriteLine("Cleared the workflow");
                            break;
                        case ConsoleKey.S:
                            var getList = workFlow.GetWorkflow();
                            foreach (var activity in getList)
                            {
                                Console.WriteLine(activity);
                            }
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("Running workflow");
                            new WorkflowEngine(workFlow.GetWorkflow()).Run();
                            Console.WriteLine("-----------------------");
                            break;
                        default:
                            Console.WriteLine("Invalid entry - try again");
                            continue;
                    }
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Operation aborted");
                    Console.WriteLine("------------");
                }
            }
        }
    }
}

