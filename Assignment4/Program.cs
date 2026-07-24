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

            #region Question06

            ///*
            // Q6. Build the same sentence as above, 
            //but using string interpolation ($"...").
            // */
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine($"Book: {title}, Pages: {pages}");

            #endregion

            #region Question07

            ///*
            // Q7. Build the same sentence again, but using string.Format().
            // */

            //string title = "Clean Code";
            //int pages = 464;
            //string format = string.Format("Book: {0} , Pages: {1}",title,pages);
            //Console.WriteLine(format);


            #endregion.

            #region Question08

            ///*
            // Q8. Declare a nullable integer int? pages = null;.
            //Use the Null Coalescing Operator (??) to print pages or 0 if it is null.
            // */

            //int? pages = null;
            //Console.WriteLine(pages??0);

            #endregion

            #region Question09

            ///*
            // Q9. Declare a nullable reference string? author = null;.
            //Use the Null Propagation Operator (?.) to safely access and print author.Length.
            // */

            //string? author = null;
            //Console.WriteLine(author?.Length);

            #endregion

        }
    }
}
