using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    public enum Status
    {
        Open,
        InProgress,
        Closed
    }

    public class Task
    {

        private DateTime start;
        private DateTime end;
        public int ID { get; private set; }
        public string Summary { get; set; }
        public string Description { get; set; }

        public Status status { get;}

        public Task(int id, string summary)
        {
            this.start = DateTime.Now;
            this.status = Status.Open;
            this.Summary = summary;
            this.ID = id;
        }

        public double getDuration()
        {
            return (DateTime.Now - start).TotalHours;
        }

        public int getId()
        {
            return this.ID;
        }

        public void setStatus(Status status)
        {
            
        }




    }
}
