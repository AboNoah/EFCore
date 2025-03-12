using System;
using System.Collections.Generic;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data;

public partial class ApplicationDBContext : DbContext
{
    public ApplicationDBContext()
    {
    }

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<BlogHeader> BlogHeaders { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyTest> CompanyTests { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeTest> EmployeeTests { get; set; }

    public virtual DbSet<ManyBlog> ManyBlogs { get; set; }

    public virtual DbSet<ManyPost> ManyPosts { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<TestPost> TestPosts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=EFCoreDB;User Id=sa;Password=123;Encrypt=false;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BlogHeader>(entity =>
        {
            entity.HasOne(d => d.Blog).WithOne(p => p.BlogHeader).HasConstraintName("FK_Blog_BlogHeader");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.Property(e => e.DeptId).HasDefaultValue("");
        });

        modelBuilder.Entity<EmployeeTest>(entity =>
        {
            entity.HasOne(d => d.CompanyTest).WithMany(p => p.EmployeeTests)
                .HasPrincipalKey(p => new { p.TestId, p.TestName })
                .HasForeignKey(d => new { d.TestId, d.TestName });
        });

        modelBuilder.Entity<ManyPost>(entity =>
        {
            entity.HasOne(d => d.Blog).WithMany(p => p.ManyPosts).HasConstraintName("FR_ManyBlog_ManyPosts");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.OrderNo).HasDefaultValueSql("(NEXT VALUE FOR [OrderNamber])");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.Property(e => e.Name).HasDefaultValue("");

            entity.HasMany(d => d.Posts).WithMany(p => p.Tags)
                .UsingEntity<Dictionary<string, object>>(
                    "PostTag",
                    r => r.HasOne<TestPost>().WithMany().HasForeignKey("PostsId"),
                    l => l.HasOne<Tag>().WithMany().HasForeignKey("TagsId"),
                    j =>
                    {
                        j.HasKey("TagsId", "PostsId");
                        j.ToTable("PostTags");
                        j.HasIndex(new[] { "PostsId" }, "IX_PostTags_PostsId");
                    });
        });

        modelBuilder.Entity<TestPost>(entity =>
        {
            entity.Property(e => e.Title).HasDefaultValue("");
        });
        modelBuilder.HasSequence("OrderNamber");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
