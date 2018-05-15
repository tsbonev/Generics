using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    public enum TaskStatus
    {
        Open,
        InProgress,
        Closed
    }

    public class Task
    {

		public DateTime Start { get; private set; }
		public DateTime End { get; private set; }
        public int ID { get; private set; }
        public string Summary { get; set; }
        public string Description { get; set; }
		public Project TaskProject { get; private set; }

		private List<Worker> workersOnTask;

        public TaskStatus Status { get; private set; }

        public Task(int id, string summary)
        {
            this.Start = DateTime.Now;
            this.Status = TaskStatus.Open;
            this.Summary = summary;
            this.ID = id;
        }

		public void assignToProject(Project project)
		{
			try
			{
				if (project == null)
				{
					throw new NullReferenceException();
				}

				if (this.TaskProject == null)
				{
					this.TaskProject = project;
				}
			}
			catch (NullReferenceException e)
			{
				Console.WriteLine(e.StackTrace);	
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

				if (this.workersOnTask == null)
				{
					this.workersOnTask = new List<Worker>();
				}

				this.workersOnTask.Add(worker);
			}
			catch(NullReferenceException e)
			{
				Console.WriteLine(e.StackTrace);
			}
		}

        public double getDuration()
        {
            return (DateTime.Now - Start).TotalHours;
        }

        public void setStatus(TaskStatus status)
        {
			if (canChangeStatus(status))
			{
				this.Status = status;
				if (status.Equals(TaskStatus.Closed))
				{
					this.End = DateTime.Now;
				}
			}
        }

		private bool canChangeStatus(TaskStatus status)
		{
			if (this.Status == status)
			{
				return false;
			}

			switch (status)
			{
				case TaskStatus.Open:
					if (this.Status == TaskStatus.Closed)
					{
						return false;
					}
					break;

				case TaskStatus.InProgress:
					if (this.Status == TaskStatus.Closed)
					{
						return false;
					}
					break;
					//can we go from open directly to closed?
					//can we go from InProgress to open?
			}

			return true;
		}

    }
}
