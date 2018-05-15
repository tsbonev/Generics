using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	public static class Manager
	{

		public static int getHoursWorkedTotal(Worker worker)
		{
			return worker.hoursWorked.Sum(h => h.Value);
		}

		public static int getHoursWorkedOnTask(Worker worker, Task task)
		{
			return worker.hoursWorked.Where(t => t.Key.Equals(task)).Sum(h => h.Value);
		}

		public static int getHoursWorkedOnProject(Worker worker, Project project)
		{
			return worker.hoursWorked.Where(k => k.Key.TaskProject.Equals(project)).Sum(h => h.Value);
		}

		public static void printAllTasks(Worker worker)
		{
			foreach (Task task in worker.hoursWorked.Keys)
			{
				Console.WriteLine("{0} has worked on {1} for {2} hours", worker.FirstName, task.Summary, getHoursWorkedOnTask(worker, task));
			}
		}

		public static void printAllProjects(Worker worker)
		{
			List<Project> projects = new List<Project>();
			worker.hoursWorked.Keys.ToList().ForEach(t => addDistinct(t.TaskProject, projects));
			foreach (Project project in projects)
			{
				Console.WriteLine("{0} has worked on {1} for {2} hours", worker.FirstName, project.Summary, getHoursWorkedOnProject(worker, project));
			}

		}

		private static void addDistinct(Project project, List<Project> projects)
		{
			if (!projects.Contains(project)) projects.Add(project);
		}

	}
}
