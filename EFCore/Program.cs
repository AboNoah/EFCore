// See https://aka.ms/new-console-template for more information
using EFCore;
using EFCore.Model;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        var _context = new ApplictionDBContext();
        // استدعاء دالة SeedData
        SeedData(_context);
        // التأكد من أن البيانات تم إدراجها
        RetrieveData(_context);
    }
    static void SeedData(ApplictionDBContext context)
    {
        // التأكد من أن قاعدة البيانات موجودة
        context.Database.EnsureCreated();

        // التحقق مما إذا كانت البيانات قد أُدرجت مسبقًا
        if (!context.TestPosts.Any() && !context.Tags.Any())
        {
            // إنشاء منشورات
            var post1 = new TestPost { Title = "EF Core Guide" };
            var post2 = new TestPost { Title = "ASP.NET Core Best Practices" };

            // إنشاء وسوم
            var tag1 = new Tag { Name = "C#" };
            var tag2 = new Tag { Name = "Entity Framework" };

            // إضافة البيانات إلى السياق
            context.TestPosts.AddRange(post1, post2);
            context.Tags.AddRange(tag1, tag2);
            context.SaveChanges(); // حفظ البيانات الأساسية

            // إنشاء العلاقات Many-to-Many
            var postTag1 = new PostTag { PostsId = post1.Id, TagsId = tag1.Id };
            var postTag2 = new PostTag { PostsId = post1.Id, TagsId = tag2.Id };
            var postTag3 = new PostTag { PostsId = post2.Id, TagsId = tag1.Id };

            context.PostTags.AddRange(postTag1, postTag2, postTag3);
            context.SaveChanges(); // حفظ العلاقات

            Console.WriteLine("✅ البيانات أُدرجت بنجاح!");
        }
        else
        {
            Console.WriteLine("⚠️ البيانات موجودة بالفعل، لا حاجة للإدراج.");
        }
    }

    static void RetrieveData(ApplictionDBContext context)
    {
        var postsWithTags = context.TestPosts
            .Include(p => p.PostTags)
            .ThenInclude(pt => pt.Tag)
            .ToList();

        foreach (var post in postsWithTags)
        {
            Console.WriteLine($"📝 المنشور: {post.Title}");
            foreach (var postTag in post.PostTags)
            {
                Console.WriteLine($"   🏷 الوسم: {postTag.Tag.Name}");
            }
        }
    }
}