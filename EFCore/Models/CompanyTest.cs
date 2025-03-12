using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models;

[Table("CompanyTest")]
[Index("TestId", "TestName", Name = "AK_CompanyTest_TestId_TestName", IsUnique = true)]
public partial class CompanyTest
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int TestId { get; set; }

    public int TestName { get; set; }

    [InverseProperty("CompanyTest")]
    public virtual ICollection<EmployeeTest> EmployeeTests { get; set; } = new List<EmployeeTest>();
}
