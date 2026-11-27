namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01

            //Book B = new Book();
            // B.password;
            // can't acsess the field because it is private(Syntax Error)
            #endregion

            #region َQ02
            //Book B = new Book();
            //Console.WriteLine(B.copiesInStock);
            // can acsess because it has internal acsess modifier (whole project)
            #endregion

            #region Q03
            //Book B = new Book();
            //B.Title = "C#";
            //Console.WriteLine(B.Title);


            #endregion

            #region Q04

            //Book B = new Book();
            //B.type = Genre.Science;
            //Console.WriteLine(B.type);
            #endregion

            #region Q05
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);


            #endregion

            #region Q6

            //int genreNumber = 1;
            //Console.WriteLine((Genre)genreNumber);

            #endregion

            #region Q07

            //Genre genre = Genre.Fiction;

            //string res = genre.ToString();
            //Console.WriteLine(res.GetType());

            #endregion

            #region Q08
            //string genreText = "Science";

            //Genre result = Enum.Parse<Genre>(genreText);
            //Console.WriteLine(result.GetType());
            //Console.WriteLine(result);

            #endregion

            #region Q09

            string genreText = "Mystery";
            bool isparsed = Enum.TryParse<Genre>(genreText, true, out Genre result);
            if (isparsed && Enum.IsDefined(typeof(Genre), result))
                Console.WriteLine("Done");
            else
                Console.WriteLine("Fails");

            #endregion
        }
    }
}
