using System;

namespace firstDay
{
    class Book
    {
        String ISBN { get; set; }
        int id { get; set; }
        public enum type { Printed = 1, NotPrinted = 2};
        int numOfPages { get; set; }
        String author { get; set; }
        String nameOfBook { get; set; }
        int yearOfProduction { get; set; }
        int yearOfBook { get; set; }
        //we can`t change type of book, that`s why set is unavailable
        type typeOfBook { get; }
        public Book(type typeOfBook, int numOfPages = 0, String author = null, String nameOfBook = "", int yearOfProduction = 0, int yearOfBook = 0) {
            this.typeOfBook = typeOfBook;
            this.numOfPages = numOfPages;
            this.author = author;
            this.yearOfBook = yearOfBook;
            this.nameOfBook = nameOfBook;
            this.yearOfProduction = yearOfProduction;
            validateData();
        }
        void validateData() 
        {
        }

    }
}
