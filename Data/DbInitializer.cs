using Microsoft.EntityFrameworkCore;
using Coborzan_Tudor_Lab2_M.Models;

namespace Coborzan_Tudor_Lab2_M.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Coborzan_Tudor_Lab2_MContext
           (serviceProvider.GetRequiredService
            <DbContextOptions<Coborzan_Tudor_Lab2_MContext>>()))
            {
                if (context.Book.Any())
                {
                    return; // BD a fost creata anterior
                }
                context.Book.AddRange(
                new Book
                {
                    Title = "Baltagul"
                },
               
                new Book
                {
                    Title = "Enigma Otiliei"
                },
               
                new Book
                {
                    Title = "Maytrei"}
               
                );

                context.Genre.AddRange(
               new Genre { Name = "Roman" },
               new Genre { Name = "Nuvela" },
               new Genre { Name = "Poezie" }
                );
                context.Customer.AddRange(
                new Customer
                {
                    Name = "Popescu Marcela",
                    Adress = "Str. Plopilor, nr. 24",
                    BirthDate = DateTime.Parse("1979-09-01")
                },
                new Customer
                {
                    Name = "Mihailescu Cornel",
                    Adress = "Str. Bucuresti, nr. 45, ap. 2",BirthDate=DateTime.Parse("1969 - 07 - 08")}
               
                );

                context.SaveChanges();
            }
        }
    }
}
