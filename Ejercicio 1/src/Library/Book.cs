using System;

namespace Ucu.Poo.Expert
{
    public class Book
    {

        public string Title { get; }
        public string Author { get; }
        public string Code { get; }

        /*
        Teniendo en cuenta que SRP dice que una clase debe ser creada
        para y solo para una tarea, manejar datos como la ubicacion
        dentro de la misma clase en la que creamos el libro, no seria
        correcto, por lo que comentamos los constructores de LibrarySector
        y LibraryShelve y creamos una clase LocateBooks la cual recibe
        el objeto Book que hayamos creado y le añade esas caracteristicas.

        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        */

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        /*
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        */
    }
}
