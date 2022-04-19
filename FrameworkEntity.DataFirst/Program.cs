using FrameworkEntity.DataFirst.DAL;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


DbContextInitializer.Build();

using (var _context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
        Console.WriteLine($" p = {p.Name} : {p.Price}")
    );
}
