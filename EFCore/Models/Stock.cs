using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models;

//[Keyless]
public partial class Stock
{
    [Key]
    [Column("id")]
    public int? Id { get; set; }

    [Column("first_name")]
    [StringLength(512)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [Column("last_name")]
    [StringLength(512)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [Column("email")]
    [StringLength(512)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("gender")]
    [StringLength(512)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("ip_address")]
    [StringLength(512)]
    [Unicode(false)]
    public string? IpAddress { get; set; }
}
