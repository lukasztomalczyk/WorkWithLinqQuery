using System.Collections.Generic;
using WorkWithLinqQuery.Models;

namespace WorkWithLinqQuery.DataAccess.Queries
{
    public interface IInMemoryDatabase
    {
        IList<Author> Authors { get; }
        IList<Book> Books { get; }
        IList<ReservationItem> Reservations { get; }
    }
}