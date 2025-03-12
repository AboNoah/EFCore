using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models;

public partial class TestPost
{
    [Key]
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    [ForeignKey("PostsId")]
    [InverseProperty("Posts")]
    public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
}
