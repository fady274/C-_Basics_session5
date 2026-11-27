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
            Book B = new Book();
            B.Title = "C#";
            Console.WriteLine(B.Title);


            #endregion
        }
    }
}
