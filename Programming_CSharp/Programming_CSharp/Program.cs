using System;
using TestLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.IO;

namespace Programming_CSharp
{
     class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(@"C:\Programming\SRC\Programming_CSharp\Programming_CSharp\test.json");
            string jsonString = r.ReadToEnd();
            var data = JsonConvert.DeserializeObject<TasksDto>(jsonString, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });
            r.Close();

            foreach(var task in data.tasks)
            {
                if(task.isDone == false)
                {
                    Console.WriteLine(task.taskName);
                }
            }


        }
    }
     public class TasksDto
    {
        public List<Task> tasks;
    }

    public class Task
    {
        public int id;
        public string taskName;
        public string discription;
        public DateTime dueDate;
        public bool isDone;
    }
}
