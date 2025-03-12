using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models;

public partial class Tag
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [ForeignKey("TagsId")]
    [InverseProperty("Tags")]
    public virtual ICollection<TestPost> Posts { get; set; } = new List<TestPost>();
}
