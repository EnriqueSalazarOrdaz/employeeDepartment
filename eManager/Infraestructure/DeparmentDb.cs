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
        public DeparmentDb(): base("work")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Deparment> Deparments { get; set; }

        IQueryable<Employee> IDepartmentDataSource.Employees
        {
            get
            {
                return Employees;
            }
        }

        IQueryable<Deparment> IDepartmentDataSource.Deparments
        {
            get
            {
                return Deparments;
            }
        }

        void IDepartmentDataSource.Save()
        {
            SaveChanges();
        }
    }
}