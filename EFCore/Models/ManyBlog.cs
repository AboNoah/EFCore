using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models;

public partial class ManyBlog
{
    [Key]
    public int Id { get; set; }

    [InverseProperty("Blog")]
    public virtual ICollection<ManyPost> ManyPosts { get; set; } = new List<ManyPost>();
}
