﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models.Dto
{
    //[NotMapped]
    public class BookDto
    { 
        public int Id { get; set; }
        public string Title { get; set; } 
        public string AuthorName { get; set; }

    }
   
}
