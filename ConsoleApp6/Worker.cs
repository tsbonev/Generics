using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Worker
    {
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private List<Project> workerProjects;
        private List<Task> currentTasks;

        public Worker(string fname, string lname, int id)
        {
            ID = id;
            FirstName = fname;
            LastName = lname;

            this.workerProjects = new List<Project>();
            this.currentTasks = new List<Task>();
        }

        public void addProject(Project project)
        {
            try
            {
                if (project == null) throw new NullReferenceException();
                this.workerProjects.Add(project);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void addTask(Task task)
        {
            try
            {
                if (task == null) throw new NullReferenceException();
                this.currentTasks.Add(task);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
