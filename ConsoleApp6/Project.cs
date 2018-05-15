using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Project
    {
		public int ID { get; private set; }
		public string Summary { get; set; }
		public string Description { get; set; }

		private List<Task> projectTasks;
		private List<Worker> projectWorkers;

        public Project(int id, string summmary)
        {
			this.ID = id;
			this.Summary = summmary;
        }

        public void addTask(Task task)
        {
            try
            {
				if (task == null)
				{
					throw new NullReferenceException();
				}

				if (projectTasks == null)
				{
					projectTasks = new List<Task>();
				}

				this.projectTasks.Add(task);
				task.assignToProject(this);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public Task getTaskById(int id)
        {
            return projectTasks.FirstOrDefault(t => t.ID.Equals(id));
        }

        public Task getTaskByIndex(int index)
        {
            try
            {
                return projectTasks.ElementAt(index);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
            
        }

		public void addWorker(Worker worker)
		{
			try
			{
				if (worker == null)
				{
					throw new NullReferenceException();
				}

				if (projectWorkers == null)
				{
					projectWorkers = new List<Worker>();
				}

				this.projectWorkers.Add(worker);
			}
			catch(NullReferenceException e)
			{
				Console.WriteLine(e.StackTrace);
			}
		}

		public Worker getWorkerById(int id)
		{
			return this.projectWorkers.FirstOrDefault(w => w.ID.Equals(id));
		}

		public void assignWorkerToTask(Worker worker, Task task)
		{

			try
			{
				if (worker == null || task == null)
				{
					throw new NullReferenceException();
				}

				if (!this.projectWorkers.Contains(worker))
				{
					addWorker(worker);
				}

				if (!this.projectTasks.Contains(task))
				{
					addTask(task);
				}

				task.addWorker(worker);
				worker.addTask(task);

			}
			catch(NullReferenceException e)
			{
				Console.WriteLine(e.StackTrace);
			}

		}

	}
}
