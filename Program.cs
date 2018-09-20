using System;
using System.Collections.Generic;
using System.Linq;
using WorkWithLinqQuery.DataAccess.Queries;
using WorkWithLinqQuery.Models;

namespace WorkWithLinqQuery
{
    class Program
    {
        // setup
        private static IInMemoryDatabase Database { get; } = SeedDb.SeedDataBase();
        private static List<Author> AllAuthors { get; } = Database.Authors.ToList();
        private static List<Book> AllBooks { get; } = Database.Books.ToList();
        private static List<ReservationItem> AllReservation { get; } = Database.Reservations.ToList();


        static void Main(string[] args)
        {
            Query1();

            // ShowAllReservations(allReservation);

            // ShowAllBooks(allBooks);

            // ShowAllAuthors(allAuthors);


            Console.ReadKey();
        }

        private static void Query2()
        {
         //  var test = AllAuthors.Join()
        }

        // wypisz zarezerwowane ksiązki
        private static void Query1()
        {
            var listOfReservationBook = new List<Book>();

            AllReservation.ForEach(p =>
            {
                var reservedBooks = AllBooks.Where(a => a.Id == p.BookNumber).Select(b => b);

                foreach (var book in reservedBooks)
                {
                    listOfReservationBook.Add(book);
                }

            });

            foreach (var book in listOfReservationBook)
            {
                Console.WriteLine($"Nazwa: {book.Name}");
            }
//            AllBooks.ForEach(p =>
//            {
//                var reservationItem = AllReservation.FirstOrDefault(d => d.BookNumber == p.Id);
//
//                if (reservationItem != null)
//                {
//                    var reservatedbook = AllBooks.FirstOrDefault(k => k.Id == reservationItem.Id);
//
//                    if (reservatedbook != null)
//                    {
//                        var author = AllAuthors.FirstOrDefault(a => a.Id == reservatedbook.Author);
//
//                        if (author != null)
//                        {
//                            listOfReservationBook.Add(new {Author = author.Name, Name = reservatedbook.Name});
//                        }
//                    }
//                }
//            });
//
//            Console.WriteLine("Lista zarezerwowanych książek");
//
//            foreach (var item in listOfReservationBook)
//            {
//                Console.WriteLine($"Author: {item.Author}, Name: {item.Name}");
//            }
        }

        private static void ShowAllReservations(List<ReservationItem> allReservation)
        {
            Console.WriteLine("Lista rezerwacji:");

            foreach (var item in allReservation)
            {
                Console.WriteLine($"ID: {item.Id}, Ksiażka ID: {item.BookNumber}, Od: {item.From}, Do: {item.To}");
            }
        }

        private static void ShowAllAuthors(List<Author> allAuthors)
        {
            Console.WriteLine("Lista Autorów: ");

            foreach (var item in allAuthors)
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}");
            }
        }

        private static void ShowAllBooks(List<Book> allBooks)
        {
            Console.WriteLine("Lista książek");

            foreach (var item in allBooks)
            {
                Console.WriteLine($"ID: {item.Id}, Author: {item.Author}, Name: {item.Name}");
            }
        }
    }
}