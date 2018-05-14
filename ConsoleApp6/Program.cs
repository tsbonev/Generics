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

            Task task = new Task();
            Project project = new Project();
            Worker worker = new Worker();

            project.addTask(task);
            worker.addProject(project);
            project.assignWorker(worker, null);
           


            //Console.WriteLine(project.getTaskByIndex(10));

        }
    }
}
