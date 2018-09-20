using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using WorkWithLinqQuery.Models;

namespace WorkWithLinqQuery.DataAccess.Queries
{
    public class InMemoryDatabase : IInMemoryDatabase
    {
        public IList<Author> Authors { get; }
        public IList<Book> Books { get;  }
        public IList<ReservationItem> Reservations { get; }

        public InMemoryDatabase()
        {
            Authors = new List<Author>();
            Books = new List<Book>();
            Reservations = new List<ReservationItem>();
        }
        public InMemoryDatabase(IList<Author> authors, IList<Book> books, IList<ReservationItem> reservations)
        {
            Authors = authors;
            Books = books;
            Reservations = reservations;
        }
    }
}