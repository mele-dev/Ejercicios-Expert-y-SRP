using System;

namespace Ucu.Poo.Expert
{
    public class LocateBooks
    {

        public void ShelveBook(Book book, String sector, String shelve)
        {
            book.LibrarySector = sector;
            book.LibraryShelve = shelve;
        }

    }
}
