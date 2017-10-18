using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManager.Domain
{
    public class Deparment
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
