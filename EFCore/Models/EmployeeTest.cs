using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models;

[Index("TestId", "TestName", Name = "IX_EmployeeTests_TestId_TestName")]
public partial class EmployeeTest
{
    [Key]
    public int Id { get; set; }

    public int TestId { get; set; }

    public int TestName { get; set; }

    public string FullName { get; set; } = null!;

    public string Position { get; set; } = null!;

    [ForeignKey("TestId, TestName")]
    [InverseProperty("EmployeeTests")]
    public virtual CompanyTest CompanyTest { get; set; } = null!;
}
