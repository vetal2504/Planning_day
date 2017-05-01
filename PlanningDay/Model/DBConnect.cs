using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PlanningDay.Model
{
    class DBConnect : DbContext
    {
        public DBConnect() : base("DBConnection")
        {

        }

        public DbSet<TableTask> AllWork { get; set; }
    }
}
