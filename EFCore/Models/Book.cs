﻿namespace EFCore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; } = null!;
    }
}
