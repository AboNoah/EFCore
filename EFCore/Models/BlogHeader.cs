using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models;

[Table("BlogHeader")]
[Index("BlogId", Name = "IX_BlogHeader_BlogId", IsUnique = true)]
public partial class BlogHeader
{
    [Key]
    public int Id { get; set; }

    public int BlogId { get; set; }

    [ForeignKey("BlogId")]
    [InverseProperty("BlogHeader")]
    public virtual Blog Blog { get; set; } = null!;
}
