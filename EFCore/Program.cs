// See https://aka.ms/new-console-template for more information
using EFCore;
using EFCore.Models;
using EFCore.Data;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        var _context = new ApplicationDBContext();
        //var stok = _context.Stocks.Find(100);
        //Console.WriteLine($"ID:{stok.Id} , Name: {stok.FirstName}");
        //Console.ReadLine();
        ////
        //var st = _context.Stocks.Single(m => m.Id == 100);
        //Console.WriteLine($"ID:{st.Id} , Name: {st.FirstName}");
        //Console.ReadLine();    
        //var stD = _context.Stocks.SingleOrDefault(m => m.Id == 100);
        //Console.WriteLine($"ID:{stD.Id} , Name: {stD.FirstName}");
        //Console.ReadLine();
        //var stF = _context.Stocks.First(m => m.Id > 101);
        //Console.WriteLine($"ID:{stF.Id} , Name: {stF.FirstName}");
        //Console.ReadLine();
        //var stFD = _context.Stocks.First(m => m.Id > 101);
        //Console.WriteLine($"ID:{stFD.Id} , Name: {stFD.FirstName}");
        //Console.ReadLine();
        ////var stL = _context.Stocks.OrderBy(m=>m.FirstName).Last();
        ////Console.WriteLine($"ID:{stL.Id} , Name: {stL.FirstName}");
        ////Console.ReadLine();
        //var stLD = _context.Stocks.OrderBy(m => m.Id).LastOrDefault();
        //Console.WriteLine($"ID:{stLD.Id}  , Name:  {stLD.FirstName}");
        //Console.ReadLine();
        //var stock = _context.Stocks.ToList();
        //foreach (var St in stock)
        //    Console.WriteLine(St.FirstName);
        //Console.ReadLine();
        //
        //var stocks = _context.Stocks.Where(m=>m.Id>500 && m.FirstName.StartsWith("Z")).ToList();
        //foreach (var St in stocks)
        //    Console.WriteLine($"id:{St.Id},{St.FirstName}");
        //Console.ReadLine(); 

        //var stocks = _context.Stocks.All(m=>m.Id>0 );
        //    Console.WriteLine(stocks);
        //Console.ReadLine();

        //var stocks = _context.Stocks.Where(m => m.Id > 500 ).ToList().Prepend(new Stock { Id=500,FirstName="Saleh"});
        //foreach (var St in stocks)
        //    Console.WriteLine($"id:{St.Id},{St.FirstName}");
        //Console.ReadLine();   

        //var stocks = _context.Stocks.Average(m => m.Id);
        //    Console.WriteLine($"id:{stocks}");
        //Console.ReadLine();  
        //var stocks = _context.Stocks.Count();
        //    Console.WriteLine($"id:{stocks}");
        //Console.ReadLine();
        //var stocks = _context.Stocks.Sum(m=>m.Id);
        //Console.WriteLine($"id:{stocks}");
        //Console.ReadLine();       
        //var stocks = _context.Stocks.Min(m=>m.FirstName);
        //Console.WriteLine($"id:{stocks}");
        //Console.ReadLine();

        //var stocks = _context.Stocks.Where(m => m.Id > 500).ToList().OrderBy(m=>m.FirstName).ThenByDescending(m=>m.FirstName);
        //foreach (var St in stocks)
        //    Console.WriteLine($"id:{St.Id},{St.FirstName}");
        //Console.ReadLine();
        //var stocks = _context.Stocks.Where(m => m.Id > 500).Select(m => new  {StockId=m.Id,Name=m.FirstName }).ToList().OrderBy(m=>m.Name).ThenByDescending(m=>m.Name);
        //foreach (var St in stocks)
        //    Console.WriteLine($"id:{St.StockId},{St.Name}");
        //Console.ReadLine();
        //var stocksD = _context.Stocks.Where(m => m.Id > 500).Select(m => new  {Name=m.FirstName }).Distinct().ToList();
        //foreach (var St in stocksD)
        //    Console.WriteLine($"id:{St.Name}");
        //Console.ReadLine(); 
        //var stockss = _context.Stocks.Where(m => m.Id > 500).Select(m => new  {m.Id }).Skip(20).Take(2).ToList();
        //foreach (var St in stockss)
        //    Console.WriteLine($"id:{St.Id}");
        //Console.ReadLine();
        var stockss = _context.Stocks.Where(m => m.Id > 0).GroupBy(m=>m.Gender).Select(m => new  {Gender=m.Key,Count=m.Count() }).ToList();
        foreach (var St in stockss)
            Console.WriteLine($"id:{St.Count},{St.Gender}");
        Console.ReadLine();
    }
}











// استدعاء دالة SeedData
        //SeedData(_context);
        // التأكد من أن البيانات تم إدراجها
        //RetrieveData(_context);
    //static void SeedData(ApplicationDBContext context)
    //{
    //    // التأكد من أن قاعدة البيانات موجودة
    //    context.Database.EnsureCreated();

    //    // التحقق مما إذا كانت البيانات قد أُدرجت مسبقًا
    //    if (!context.TestPosts.Any() && !context.Tags.Any())
    //    {
    //        // إنشاء منشورات
    //        var post1 = new TestPost { Title = "EF Core Guide" };
    //        var post2 = new TestPost { Title = "ASP.NET Core Best Practices" };

    //        // إنشاء وسوم
    //        var tag1 = new Tag { Name = "C#" };
    //        var tag2 = new Tag { Name = "Entity Framework" };

    //        // إضافة البيانات إلى السياق
    //        context.TestPosts.AddRange(post1, post2);
    //        context.Tags.AddRange(tag1, tag2);
    //        context.SaveChanges(); // حفظ البيانات الأساسية

    //        // إنشاء العلاقات Many-to-Many
    //        var postTag1 = new PostTag { PostsId = post1.Id, TagsId = tag1.Id };
    //        var postTag2 = new PostTag { PostsId = post1.Id, TagsId = tag2.Id };
    //        var postTag3 = new PostTag { PostsId = post2.Id, TagsId = tag1.Id };

    //        context.PostTags.AddRange(postTag1, postTag2, postTag3);
    //        context.SaveChanges(); // حفظ العلاقات

    //        Console.WriteLine("✅ البيانات أُدرجت بنجاح!");
    //    }
    //    else
    //    {
    //        Console.WriteLine("⚠️ البيانات موجودة بالفعل، لا حاجة للإدراج.");
    //    }
    //}

    //static void RetrieveData(ApplicationDBContext context)
    //{
    //    var postsWithTags = context.TestPosts
    //        .Include(p => p.PostTags)
    //        .ThenInclude(pt => pt.Tag)
    //        .ToList();

    //    foreach (var post in postsWithTags)
    //    {
    //        Console.WriteLine($"📝 المنشور: {post.Title}");
    //        foreach (var postTag in post.PostTags)
    //        {
    //            Console.WriteLine($"   🏷 الوسم: {postTag.Tag.Name}");
    //        }
    //    }
    //}