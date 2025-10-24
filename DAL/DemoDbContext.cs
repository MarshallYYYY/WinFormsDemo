using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsDemo.Models;

namespace WinFormsDemo.DAL
{
    public class DemoDbContext : DbContext
    {
        //public DemoDbContext() : base("Server=localhost\\MSSQLSERVER01;Database=OwnerDb;Trusted_Connection=true;")
        public DemoDbContext() : base("Data Source=.\\MSSQLSERVER01;Database=OwnerDb;UID=SSMS21;PWD=YYYXUEBING")
        {

        }
        public DbSet<Owner> Owners { get; set; }
    }
}
