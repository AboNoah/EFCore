using EFCore.Config;
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
    class ApplictionDBContext_Old:DbContext
    {    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
        
            optionsBuilder.UseSqlServer(@"server=localhost\SQLEXPRESS; database=EFCoreDB;User Id=sa;Password=123;Encrypt=false;MultipleActiveResultSets=true");
        
       //public DbSet<ManyBlog> ManyBlogs { get; set; }//Context Object
       //public DbSet<Blog> Blogs { get; set; }//Context Object
       // public DbSet<Company> Companies { get; set; }
       // public DbSet<Employee> Employees { get; set; }
       // public DbSet<EmployeeTest> EmployeeTests { get; set; }
       // public DbSet<TestPost> TestPosts { get; set; }
       // public DbSet<Tag> Tags { get; set; }
       // public DbSet<PostTag> PostTags { get; set; }
       // public DbSet<Order> Orders { get; set; }
        // public DbSet<Author> Authors { get; set; }//Context Object
                                                             // public DbSet<Category> Categories { get; set; }//Context Object
                                                             //// public DbSet<Book> Books { get; set; }//Context Object
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
     //       //Squences
     //       modelBuilder.HasSequence("OrderNamber");
     //       modelBuilder.Entity<Order>()
     //           .Property(o => o.OrderNo)
     //           .HasDefaultValueSql("NEXT VALUE FOR OrderNamber");
     ////       modelBuilder.HasSequence<int>("OrderNumbers", schema: "shared")
     ////.StartsAt(1000)
     ////.IncrementsBy(5);
     //       //Index
     //       modelBuilder.Entity<Company>()
     //           .HasIndex(c => c.DeptID);
     //       //Index
     //       //modelBuilder.Entity<Company>()
     //       //    .HasIndex(c => c.DeptID).IsUnique().HasFilter(null); //Index
     //       //modelBuilder.Entity<Company>()
     //       //    .HasIndex(c => c.DeptID).HasDatabaseName("Index_Test");
     //       //Index Composit
     //       modelBuilder.Entity<Employee>()
     //           .HasIndex(c => new { c.FullName,c.Position });
     //       //One To One
     //       modelBuilder.Entity<Blog>()
     //                  .HasOne(h => h.Header)
     //                  .WithOne(b => b.Blog)
     //                  .HasForeignKey<BlogHeader>(f => f.BlogId)
     //                  .HasConstraintName("FK_Blog_BlogHeader");

     //       //One To Many
     //       modelBuilder.Entity<ManyBlog>()
     //                   .HasMany(p => p.ManyPosts)
     //                   .WithOne(b => b.ManyBlog)
     //                   .HasForeignKey(e=> e.BlogId)
     //                   .HasConstraintName("FR_ManyBlog_ManyPosts");

     //       modelBuilder.Entity<Company>()
     //           .HasMany(e => e.Employees)
     //           .WithOne(c => c.Company)
     //           .HasForeignKey(e => e.CompanyId);

     //       modelBuilder.Entity<CompanyTest>()
     //           .HasMany(e => e.EmployeesTest)
     //           .WithOne(c => c.CompanyTest)
     //           .HasForeignKey(e => new { e.TestId, e.TestName })
     //           .HasPrincipalKey(c => new { c.TestId, c.TestName });

     //       //Many To Many
     //       //// تعيين المفتاح المركب لجدول PostTag
     //       //modelBuilder.Entity<PostTag>()
     //       //    .HasKey(pt => new { pt.PostsId, pt.TagsId });

     //       //// تعريف العلاقة بين Post و PostTag
     //       //modelBuilder.Entity<PostTag>()
     //       //    .HasOne(pt => pt.TestPost)
     //       //    .WithMany(p => p.PostTags)
     //       //    .HasForeignKey(pt => pt.PostsId);

     //       //// تعريف العلاقة بين Tag و PostTag
     //       //modelBuilder.Entity<PostTag>()
     //       //    .HasOne(pt => pt.Tag)
     //       //    .WithMany(t => t.PostTags)
     //       //    .HasForeignKey(pt => pt.TagsId);



     //       modelBuilder.Entity<PostTag>(entity =>
     //       {
     //           // تعيين المفتاح المركب باستخدام TagId و PostId
     //           entity.HasKey(pt => new { pt.TagsId, pt.PostsId });

     //           // تعريف العلاقة بين Post و PostTag
     //           entity.HasOne(pt => pt.TestPost)
     //                 .WithMany(p => p.PostTags)
     //                 .HasForeignKey(pt => pt.PostsId);

     //           // تعريف العلاقة بين Tag و PostTag
     //           entity.HasOne(pt => pt.Tag)
     //                 .WithMany(t => t.PostTags)
     //                 .HasForeignKey(pt => pt.TagsId);
     //       });
            //modelBuilder.Entity<Category>().Property(c => c.Id).ValueGeneratedOnAdd();
            //modelBuilder.Entity<Author>().Property(d => d.DisplayName).HasComputedColumnSql("[FirstName] +' ' + [LastName]");
            //modelBuilder.Entity<Blog>().Property(b => b.rating).HasDefaultValue(2);
            //modelBuilder.Entity<Blog>().Property(b => b.CreateOn).HasDefaultValueSql("getdate()-1");
            ////modelBuilder.Entity<AuditEntry>().ToTable("AuditEntries");
            // modelBuilder.Entity<Post>().ToView("Posts",schema: "Blogging"); //View
            // new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Blog>());
            //modelBuilder.Ignore<Post>();
            // modelBuilder.Entity<Blog>().Property(n=>n.Url).HasColumnName("BlogUrl"); // Rename property
            // modelBuilder.Entity<Book>().HasKey(n=>new { n.Name ,n.Author}).HasName("compiost_Book"); // Column Comment property
            //  modelBuilder.Entity<Book>().HasKey(n=>n.BookKey).HasName("PK_BookKey"); // Column Comment property
            //    modelBuilder.Entity<Book>().HasKey(n=>n.BookKey); // Column Comment property
            //modelBuilder.Entity<Blog>().Property(n=>n.Url).HasComment("Column Comments"); // Column Comment property
            //modelBuilder.Entity<Blog>().Property(n=>n.Url).HasMaxLength(150); // Column MaxLength property
            //modelBuilder.Entity<Blog>().Property(n=>n.Url).HasColumnType("nvarchar(50)"); // Column Type property
            // modelBuilder.Entity<Blog>().Property(n=>n.Rating).HasColumnType("decimal(5,2)"); // Column Type property
            // modelBuilder.HasDefaultSchema("Blogging");//Default Schema

        }
       
    }
}
