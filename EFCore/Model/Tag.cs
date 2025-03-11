using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
  
    public class TestPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<PostTag> PostTags { get; } = [];
    }

    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PostTag> PostTags { get; } = [];
    }

    public class PostTag
    {
        public int PostsId { get; set; }
        public int TagsId { get; set; }
        public TestPost TestPost { get; set; } = null!;
        public Tag Tag { get; set; } = null!;
    }
}
