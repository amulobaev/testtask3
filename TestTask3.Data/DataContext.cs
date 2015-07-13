using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask3.Data.Entities;

namespace TestTask3.Data
{
    class DataContext : DbContext
    {
        public DbSet<DepartmentEntity> Departments { get; set; }
    }
}
