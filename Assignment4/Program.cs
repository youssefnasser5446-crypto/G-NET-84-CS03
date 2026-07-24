using System.Text;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            ///*
            //  Q1. Declare string title = "clean code";.
            // Call title.ToUpper() and store it in a new variable upperTitle.
            //Print both title and upperTitle to show that title did not change.
            // */

            //string title = "clean code";
            //string titleUpper = title.ToUpper();
            //Console.WriteLine($"title  is {title} , title upper is {titleUpper}");

            #endregion

            #region Question02

            ///*
            //  Q2. Declare two separate string variables,
            //both set to the literal "Clean Code". Use ReferenceEquals()
            //to check if they point to the same object in memory.
            // */

            //string str1 = "Clean Code";
            //string str2 = "Clean Code";
            //Console.WriteLine($"is Equel reference ? {Object.ReferenceEquals(str1,str2)}");//true
            #endregion

            #region Question03

            ///*
            // Q3. Create a StringBuilder, Append() the text "Book List",
            //then Append() " - Updated" onto the same object. Print the final result.
            // */

            //StringBuilder sb = new StringBuilder();

            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb);

            #endregion

            #region Question04

            ///*
            //  Q4. Using the StringBuilder from the question above,
            //use Replace() to change "Book List" into "Library". Print the result.
            // */

            //StringBuilder sb = new StringBuilder();

            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb);

            #endregion

            #region Question05

            ///*
            // Q5. Given string title = "Clean Code"; 
            //and int pages = 464;, build the sentence "Book: Clean Code,
            //Pages: 464" using the + operator.
            // */

            //string title = "Clean Code"; 
            //int pages = 464;

            //Console.WriteLine("Book: "+ title +", Pages: "+ pages);

            #endregion
        }
    }
}
