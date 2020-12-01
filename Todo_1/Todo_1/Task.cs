using System;
using System.Collections.Generic;
using System.Text;

namespace Todo_1
{
    //POCO class
   public class Task
    {
       
        public List<String> TaskList { get; set; }
        public string Name { get; set; }
        public int TaskCount { get; set; }
    }
}
