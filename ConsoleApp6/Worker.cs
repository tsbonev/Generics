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
		public Dictionary<Task, int> hoursWorked { get; private set; }


		public Worker(string fname, string lname, int id)
        {
            ID = id;
            FirstName = fname;
            LastName = lname;
        }

		public void addHoursWorked(Task task, int hours)
		{
			try
			{
				if (task == null)
				{
					throw new NullReferenceException();
				}

				addTask(task, hours);
			}
			catch(NullReferenceException e)
			{
				Console.WriteLine(e.StackTrace);
			}
		}

		public void addTask(Task task, int i = 0)
		{
			try
			{
				if (task == null)
				{
					throw new NullReferenceException();
				}

				if (hoursWorked == null)
				{
					hoursWorked = new Dictionary<Task, int>();
				}

				hoursWorked.Add(task, i);
			}
			catch(NullReferenceException e)
			{
				Console.WriteLine(e.StackTrace);
			}
		}

    }
}
