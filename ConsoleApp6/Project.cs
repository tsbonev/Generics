using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Project
    {

        private List<Task> projectTasks;

        public Project()
        {
            this.projectTasks = new List<Task>();
        }

        public void addTask(Task task)
        {
            try
            {
                if (task == null) throw new NullReferenceException();
                this.projectTasks.Add(task);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Task getTask(Guid id)
        {
            return projectTasks.Find(t => t.getId().Equals(id));
        }

        public Task getTaskByIndex(int index)
        {
            try
            {
                return projectTasks.ElementAt(index);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }

        public void assignWorker(Worker worker, Task task)
        {
            try
            {
                if (task == null) throw new NullReferenceException();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            if (projectTasks.Contains(task))
            {
                    worker.addTask(task);
            }
        }

    }
}
