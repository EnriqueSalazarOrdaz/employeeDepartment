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
    public class Employee
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }

    }
}
