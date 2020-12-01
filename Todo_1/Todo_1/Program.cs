using System;
using System.Collections.Generic;

namespace Todo_1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--------------------------");
            Console.WriteLine("|                        |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|  Welcome to Todo App   |");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("|                        |");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Hello Folk,please enter your name");
            var taskObj = new Task
            {
                TaskList = new List<string>(),
                TaskCount = 0
            };
           // taskObj.TaskList = new List<string>();
            var name = Console.ReadLine();
            taskObj.Name = name;
            ITaskOperation taskOpObj = new TaskOperation();
            while (true)
            {
               
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------Menu-------------------");
                Console.WriteLine("        To Add task .Press 1");
                Console.WriteLine("        To Edit task .Press 2");
                Console.WriteLine("        To Delete task .Press 3");
                Console.WriteLine("        To View task .Press 4");
                Console.ForegroundColor = ConsoleColor.Gray;
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        taskOpObj.AddTask(taskObj);
                        break;
                    case 2:
                        taskOpObj.EditTask(taskObj);
                        break;
                    case 3:
                        taskOpObj.DeleteTask(taskObj);
                        break;
                    case 4:
                        taskOpObj.ShowTask(taskObj);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;


                }
                Console.WriteLine("If you want to exit from the application,press 'E' or 'e' or press any key to continue");
                var exit = Console.ReadKey().KeyChar;
                if(exit =='e'||exit =='E')
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you for using our application.");
                    break;
                }
            }







        }
    }
}
