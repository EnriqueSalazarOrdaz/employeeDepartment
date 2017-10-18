using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace eManager.Domain
{
    public class Deparment
    {
        public virtual int id { get; set; }
        [Display(Name="Deparment Name:")]
        public virtual string name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
