using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eManager.Domain;

namespace eManager.Infraestructure
{
    public class DeparmentDb : DbContext, IDepartmentDataSource
    {
        public DbSet<Employee> Employees2 { get; set; }
        public DbSet<Deparment> Deparments2 { get; set; }

        IQueryable<Employee> IDepartmentDataSource.Employees
        {
            get
            {
                return Employees2;
            }
        }

        IQueryable<Deparment> IDepartmentDataSource.Deparments
        {
            get
            {
                return Deparments2;
            }
        }
    }
}