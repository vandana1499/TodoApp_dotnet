using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_1
{
    class TaskOperation : ITaskOperation

    {
        public TaskOperation()
        {

        }
        public void ShowTask(Task taskObj)
        {
            if (taskObj.TaskCount > 0)
            {
                Console.WriteLine($"Dear {taskObj.Name},You have {taskObj.TaskCount} task/s.");
                Console.WriteLine("----------------------------");
                for (int i = 0; i < taskObj.TaskList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{taskObj.TaskList[i]}           ");
                }
                Console.WriteLine("----------------------------");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No task present!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        public void AddTask(Task taskObj)
        {
            int id = 0;
            var flag = true;
            while (flag)
            {
                Console.WriteLine($"Enter the  task({id + 1}) or to quit enter 'q' or 'Q'");
                var value = Console.ReadLine();
                if (value == "q" || value == "Q")
                {
                    flag = false;

                }
                else
                {

                    taskObj.TaskList.Add(value);
                    id++;
                    taskObj.TaskCount = id;
                }


            }
        }
        public void DeleteTask(Task taskObj)
        {
            ShowTask(taskObj);
            if (taskObj.TaskCount == 0)
            {
                Console.WriteLine("Add the task first!");

            }
            else
            {
                Console.WriteLine("From the above enter the task number you want to delete");
                int taskNo = Convert.ToInt32(Console.ReadLine());
                if (taskNo - 1 < 0 || taskNo > taskObj.TaskList.Count)
                {
                    Console.WriteLine("Invalid Taskno.");
                }
                else
                {
                    taskObj.TaskList.RemoveAt(taskNo - 1);
                    taskObj.TaskCount = taskObj.TaskList.Count;
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfuly deleted. Here's the new list of task");
                    ShowTask(taskObj);
                }
            }
        }
        public void EditTask(Task taskObj)
        {

            ShowTask(taskObj);
            if (taskObj.TaskCount == 0)
            {
                Console.WriteLine("Add the task first!");

            }
            else
            {
                Console.WriteLine("From the above enter the task number you want to edit");
                int taskNo = Convert.ToInt32(Console.ReadLine());
                if (taskNo - 1 < 0 || taskNo > taskObj.TaskList.Count)
                {
                    Console.WriteLine("Invalid Taskno.");
                }
                else
                {
                    Console.WriteLine("Edit the task by writing the new task");
                    string EditedTask = Console.ReadLine();
                    taskObj.TaskList[taskNo - 1] = EditedTask;
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfuly edited. Here's the new list of task");
                    ShowTask(taskObj);
                }
            }
        }
    }
}
