using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_1
{
   public interface ITaskOperation
    {
        public void AddTask(Task obj);
        public void ShowTask(Task obj);
        public void DeleteTask(Task obj);
        public void EditTask(Task obj);
    }
}
