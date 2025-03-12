using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models;

public partial class Order
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public long OrderNo { get; set; }

    public double Amount { get; set; }
}
