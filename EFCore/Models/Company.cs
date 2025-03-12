using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models;

[Index("DeptId", Name = "IX_Companies_DeptID")]
public partial class Company
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [Column("DeptID")]
    public string DeptId { get; set; } = null!;

    [InverseProperty("Company")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
