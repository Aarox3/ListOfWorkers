using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_List
{
    public class Worker
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime EmployData { get; set; }

        public DateTime ToFireData { get; set; }

        public string Salary { get; set; }

        public string Comments { get; set; }
    }
}
