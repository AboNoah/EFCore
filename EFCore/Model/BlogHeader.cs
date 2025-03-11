namespace EFCore.Model
{
    // Principal (parent)
    public class ManyBlog
    {
        public int Id { get; set; }
        public ICollection<ManyPost> ManyPosts { get; } = new List<ManyPost>(); // Collection navigation containing dependents
    }

    // Dependent (child)
    public class ManyPost
    {
        public int Id { get; set; }
        public int BlogId { get; set; } // Required foreign key property
        public ManyBlog ManyBlog { get; set; } = null!; // Required reference navigation to principal
    }
}
