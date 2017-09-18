using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookingAppStore.Models
{
    public class BookContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

    }

    public class BookDbInitializer: DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            context.Books.Add(new Book { Name = "Книга 1", Author = "Автор 1", Price = 220});
            context.Books.Add(new Book { Name = "Книга 2", Author = "Автор 2", Price = 160});
            context.Books.Add(new Book { Name = "Книга 3", Author = "Автор 3", Price = 100});

            base.Seed(context);
        }
    }
}