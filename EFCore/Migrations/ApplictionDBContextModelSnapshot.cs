﻿// <auto-generated />
using EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore.Migrations
{
    [DbContext(typeof(ApplictionDBContext))]
    partial class ApplictionDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("OrderNamber");

            modelBuilder.Entity("EFCore.Model.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EFCore.Model.BlogHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BlogId")
                        .IsUnique();

                    b.ToTable("BlogHeader");
                });

            modelBuilder.Entity("EFCore.Model.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DeptID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeptID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("EFCore.Model.CompanyTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<int>("TestName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CompanyTest");
                });

            modelBuilder.Entity("EFCore.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("FullName", "Position");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EFCore.Model.EmployeeTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<int>("TestName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestId", "TestName");

                    b.ToTable("EmployeeTests");
                });

            modelBuilder.Entity("EFCore.Model.ManyBlog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("ManyBlogs");
                });

            modelBuilder.Entity("EFCore.Model.ManyPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("ManyPost");
                });

            modelBuilder.Entity("EFCore.Model.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<long>("OrderNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("NEXT VALUE FOR OrderNamber");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EFCore.Model.PostTag", b =>
                {
                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.Property<int>("PostsId")
                        .HasColumnType("int");

                    b.HasKey("TagsId", "PostsId");

                    b.HasIndex("PostsId");

                    b.ToTable("PostTags");
                });

            modelBuilder.Entity("EFCore.Model.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("EFCore.Model.TestPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestPosts");
                });

            modelBuilder.Entity("EFCore.Model.BlogHeader", b =>
                {
                    b.HasOne("EFCore.Model.Blog", "Blog")
                        .WithOne("Header")
                        .HasForeignKey("EFCore.Model.BlogHeader", "BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Blog_BlogHeader");

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("EFCore.Model.Employee", b =>
                {
                    b.HasOne("EFCore.Model.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EFCore.Model.EmployeeTest", b =>
                {
                    b.HasOne("EFCore.Model.CompanyTest", "CompanyTest")
                        .WithMany("EmployeesTest")
                        .HasForeignKey("TestId", "TestName")
                        .HasPrincipalKey("TestId", "TestName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyTest");
                });

            modelBuilder.Entity("EFCore.Model.ManyPost", b =>
                {
                    b.HasOne("EFCore.Model.ManyBlog", "ManyBlog")
                        .WithMany("ManyPosts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FR_ManyBlog_ManyPosts");

                    b.Navigation("ManyBlog");
                });

            modelBuilder.Entity("EFCore.Model.PostTag", b =>
                {
                    b.HasOne("EFCore.Model.TestPost", "TestPost")
                        .WithMany("PostTags")
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore.Model.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tag");

                    b.Navigation("TestPost");
                });

            modelBuilder.Entity("EFCore.Model.Blog", b =>
                {
                    b.Navigation("Header");
                });

            modelBuilder.Entity("EFCore.Model.Company", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EFCore.Model.CompanyTest", b =>
                {
                    b.Navigation("EmployeesTest");
                });

            modelBuilder.Entity("EFCore.Model.ManyBlog", b =>
                {
                    b.Navigation("ManyPosts");
                });

            modelBuilder.Entity("EFCore.Model.Tag", b =>
                {
                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("EFCore.Model.TestPost", b =>
                {
                    b.Navigation("PostTags");
                });
#pragma warning restore 612, 618
        }
    }
}
