using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

			//workers - more than one project
			//projects - more than one worker and tast
			//tasks - duration, status, start, end
			//calculate for some period which worker worked how much on which tasks

			Project pr1 = new Project(1, "First project");
			Project pr2 = new Project(2, "Second project");

			Task ts1 = new Task(1, "First task");
			Task ts2 = new Task(2, "Second task");
			Task ts3 = new Task(3, "Third task");

			Worker w1 = new Worker("Ivan", "Ivanov", 1);
			Worker w2 = new Worker("Gosho", "Goshev", 2);
			Worker w3 = new Worker("Tosho", "Toshev", 1);

			pr1.addTask(ts1);
			pr1.addTask(ts2);

			pr2.addTask(ts3);

			pr1.addWorker(w1);
			pr1.addWorker(w2);

			pr2.addWorker(w3);

			pr1.assignWorkerToTask(w1, ts1);
			pr1.assignWorkerToTask(w2, ts1);
			pr1.assignWorkerToTask(w1, ts2);
			pr2.assignWorkerToTask(w3, ts3);


			Manager.printAllProjects(w1);
			Console.WriteLine();
			Manager.printAllProjects(w2);
			Console.WriteLine();
			Manager.printAllProjects(w3);
			Console.WriteLine();

			Manager.printAllTasks(w1);
			Console.WriteLine();
			Manager.printAllTasks(w2);
			Console.WriteLine();
			Manager.printAllTasks(w3);
			Console.WriteLine();



			//Console.WriteLine(project.getTaskByIndex(10));

		}
    }
}
