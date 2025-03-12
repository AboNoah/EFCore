using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models;

[Table("ManyPost")]
[Index("BlogId", Name = "IX_ManyPost_BlogId")]
public partial class ManyPost
{
    [Key]
    public int Id { get; set; }

    public int BlogId { get; set; }

    [ForeignKey("BlogId")]
    [InverseProperty("ManyPosts")]
    public virtual ManyBlog Blog { get; set; } = null!;
}
