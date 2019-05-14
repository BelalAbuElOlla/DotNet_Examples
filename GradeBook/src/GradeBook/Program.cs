using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("LiveBook");
            book.addGrade(55.5);
            book.addGrade(20.0);
            book.addGrade(10.0);
            book.showStatistics();
        }
    }
}
