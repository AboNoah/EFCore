using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    // Principal (parent)
    public class Blog
    {
        public int Id { get; set; }
        public BlogHeader? Header { get; set; } // Reference navigation to dependent
    }
    // Dependent (child)
    public class BlogHeader
    {
        public int Id { get; set; }
        public int BlogId { get; set; } // Required foreign key property
        public Blog Blog { get; set; } = null!; // Required reference navigation to principal
    }
}
