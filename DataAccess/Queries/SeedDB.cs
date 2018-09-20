using System;
using System.Collections.Generic;
using WorkWithLinqQuery.Models;

namespace WorkWithLinqQuery.DataAccess.Queries
{
    public static class SeedDb
    {
        public static IInMemoryDatabase SeedDataBase()
        {
            return new InMemoryDatabase(LoadAuthors(), LoadBooks(), LoadReservation());
        }

        private static List<Book> LoadBooks()
        {
            return new List<Book>()
            {
                new Book() {Id = 1, Author = 1, Name = "Szkoła latania"},
                new Book() {Id = 2, Author = 1, Name = "Wielki turniej"},
                new Book() {Id = 3, Author = 1, Name = "Dzień śmiechały"},

                new Book() {Id = 4, Author = 2, Name = "Kontratyp"},
                new Book() {Id = 5, Author = 2, Name = "Hashtag"},
                new Book() {Id = 6, Author = 2, Name = "Joanna Chyłka. Tom 7. Testament"},
                new Book() {Id = 7, Author = 2, Name = "Kasacja"}
            };
        }

        private static List<Author> LoadAuthors()
        {
            return new List<Author>()
            {
                new Author() {Id = 1, Name = "Christa Janusz"},
                new Author() {Id = 2, Name = "Mróz Remigiusz"}
            };
        }

        private static List<ReservationItem> LoadReservation()
        {
            return new List<ReservationItem>()
            {
                new ReservationItem()
                {
                    Id = 1,
                    BookNumber = 1,
                    From = DateTime.Now.AddHours(1),
                    To = DateTime.Now.AddHours(48)
                },
                new ReservationItem()
                {
                    Id = 2,
                    BookNumber = 2,
                    From = DateTime.Now.AddHours(12),
                    To = DateTime.Now.AddHours(42)
                },
                new ReservationItem()
                {
                    Id = 2,
                    BookNumber = 6,
                    From = DateTime.Now.AddHours(2),
                    To = DateTime.Now.AddHours(3)
                }
            };
        }
    }
}