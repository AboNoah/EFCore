namespace EFCore.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? NationalityId { get; set; }

        public virtual Nationality? Nationality { get; set; } = null!;
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
