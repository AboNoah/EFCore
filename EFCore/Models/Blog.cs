using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models;

public partial class Blog
{
    [Key]
    public int Id { get; set; }

    [InverseProperty("Blog")]
    public virtual BlogHeader? BlogHeader { get; set; }
}
