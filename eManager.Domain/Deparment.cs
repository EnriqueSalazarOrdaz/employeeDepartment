using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManager.Domain
{
    public class Deparment
    {
        public virtual int idDeparment { get; set; }
        public virtual string name { get; set; }
        public virtual ICollection<Employee> type { get; set; }
    }
}
