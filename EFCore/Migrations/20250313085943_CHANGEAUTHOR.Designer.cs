﻿// <auto-generated />
using EFCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20250313085943_CHANGEAUTHOR")]
    partial class CHANGEAUTHOR
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("OrderNamber");

            modelBuilder.Entity("EFCore.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NationalityId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("EFCore.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EFCore.Models.BlogHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "BlogId" }, "IX_BlogHeader_BlogId")
                        .IsUnique();

                    b.ToTable("BlogHeader");
                });

            modelBuilder.Entity("EFCore.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("EFCore.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DeptId")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasDefaultValue("")
                        .HasColumnName("DeptID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DeptId" }, "IX_Companies_DeptID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("EFCore.Models.CompanyTest", b =>
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

                    b.HasIndex(new[] { "TestId", "TestName" }, "AK_CompanyTest_TestId_TestName")
                        .IsUnique();

                    b.ToTable("CompanyTest");
                });

            modelBuilder.Entity("EFCore.Models.Employee", b =>
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

                    b.HasIndex(new[] { "CompanyId" }, "IX_Employees_CompanyId");

                    b.HasIndex(new[] { "FullName", "Position" }, "IX_Employees_FullName_Position");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EFCore.Models.EmployeeTest", b =>
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

                    b.HasIndex(new[] { "TestId", "TestName" }, "IX_EmployeeTests_TestId_TestName");

                    b.ToTable("EmployeeTests");
                });

            modelBuilder.Entity("EFCore.Models.ManyBlog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("ManyBlogs");
                });

            modelBuilder.Entity("EFCore.Models.ManyPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "BlogId" }, "IX_ManyPost_BlogId");

                    b.ToTable("ManyPost");
                });

            modelBuilder.Entity("EFCore.Models.Nationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("EFCore.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<long>("OrderNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("(NEXT VALUE FOR [OrderNamber])");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EFCore.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("gender");

                    b.Property<string>("IpAddress")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("ip_address");

                    b.Property<string>("LastName")
                        .HasMaxLength(512)
                        .IsUnicode(false)
                        .HasColumnType("varchar(512)")
                        .HasColumnName("last_name");

                    b.HasKey("Id");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("EFCore.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("EFCore.Models.TestPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.HasKey("Id");

                    b.ToTable("TestPosts");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.Property<int>("PostsId")
                        .HasColumnType("int");

                    b.HasKey("TagsId", "PostsId");

                    b.HasIndex(new[] { "PostsId" }, "IX_PostTags_PostsId");

                    b.ToTable("PostTags", (string)null);
                });

            modelBuilder.Entity("EFCore.Models.Author", b =>
                {
                    b.HasOne("EFCore.Models.Nationality", "Nationality")
                        .WithMany("Authors")
                        .HasForeignKey("NationalityId");

                    b.Navigation("Nationality");
                });

            modelBuilder.Entity("EFCore.Models.BlogHeader", b =>
                {
                    b.HasOne("EFCore.Models.Blog", "Blog")
                        .WithOne("BlogHeader")
                        .HasForeignKey("EFCore.Models.BlogHeader", "BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Blog_BlogHeader");

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("EFCore.Models.Book", b =>
                {
                    b.HasOne("EFCore.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("EFCore.Models.Employee", b =>
                {
                    b.HasOne("EFCore.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("EFCore.Models.EmployeeTest", b =>
                {
                    b.HasOne("EFCore.Models.CompanyTest", "CompanyTest")
                        .WithMany("EmployeeTests")
                        .HasForeignKey("TestId", "TestName")
                        .HasPrincipalKey("TestId", "TestName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyTest");
                });

            modelBuilder.Entity("EFCore.Models.ManyPost", b =>
                {
                    b.HasOne("EFCore.Models.ManyBlog", "Blog")
                        .WithMany("ManyPosts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FR_ManyBlog_ManyPosts");

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("EFCore.Models.TestPost", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EFCore.Models.Blog", b =>
                {
                    b.Navigation("BlogHeader");
                });

            modelBuilder.Entity("EFCore.Models.Company", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EFCore.Models.CompanyTest", b =>
                {
                    b.Navigation("EmployeeTests");
                });

            modelBuilder.Entity("EFCore.Models.ManyBlog", b =>
                {
                    b.Navigation("ManyPosts");
                });

            modelBuilder.Entity("EFCore.Models.Nationality", b =>
                {
                    b.Navigation("Authors");
                });
#pragma warning restore 612, 618
        }
    }
}
