using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models;

[Index("CompanyId", Name = "IX_Employees_CompanyId")]
[Index("FullName", "Position", Name = "IX_Employees_FullName_Position")]
public partial class Employee
{
    [Key]
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string Position { get; set; } = null!;

    public int CompanyId { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("Employees")]
    public virtual Company Company { get; set; } = null!;
}
