namespace s5_assi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            #region Q1
            /*Console.WriteLine(book.Password);*/ //won't work because it's private (can be accessed only within the class)
            #endregion
            #region Q2
            /*Console.WriteLine(book.copiesInStock);*/// works because it's internal (can be accessed within the same project)
            #endregion
            #region Q3
            //Console.Write("Enter book's title: ");
            //book.Title = Console.ReadLine();
            //Console.WriteLine($"Book's title: {book.Title}");
            #endregion
            #region Q4
            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre);
            #endregion
            #region Q5
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);
            #endregion
            #region Q6
            //int genreNumber = 1;
            //Console.WriteLine((Genre)genreNumber);
            #endregion
            #region Q7
            //Genre genre = Genre.Fiction;
            //Console.WriteLine(genre.ToString());
            #endregion
            #region Q8
            //string genreText = "Science";
            //Genre temp= (Genre)Enum.Parse(typeof(Genre), genreText);    
            //Console.WriteLine(temp);
            #endregion
            #region Q9
            string genreText = "Mystery";
            Genre temp;
            bool isParsed=Enum.TryParse(genreText,true, out temp);    
            if (isParsed)
            {
                Console.WriteLine(temp);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion
        }
    }
}
