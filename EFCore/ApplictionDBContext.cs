using EFCore.Config;
using EFCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    class ApplictionDBContext:DbContext
    {    
        public DbSet<Blog> Blogs { get; set; }//Context Object
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditEntry>();
            new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Blog>());
            modelBuilder.Ignore<Post>();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
        
            optionsBuilder.UseSqlServer(@"server=localhost\SQLEXPRESS; database=EFCoreDB;User Id=sa;Password=123;Encrypt=false;MultipleActiveResultSets=true");
        
    }
}
