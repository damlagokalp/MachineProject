using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class MachineContext:DbContext
    {
        //Projenin hangi veritabanı ile ilişkili olduğunun belirtildiği yer 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //neden protected?
        {
            //sql server kullanılır
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MachineProject;Trusted_Connection=true", options => options.EnableRetryOnFailure());
        }
        //Benim nesnemle veritabanındaki nesnenin bağlanması
        public DbSet<Machine > Machines { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
