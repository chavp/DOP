using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DOP.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAuthor()
        {
            var sugoku = new Author { FirstName = "Sun", LastName = "Goku", Books = 101 };
            System.Console.WriteLine($"Fullname: {sugoku.FullName}");
            System.Console.WriteLine($"IsProlific: {sugoku.IsProlific}");
        }

        [TestMethod]
        public void TestAuthorData()
        {
            var sugoku = new AuthorData { FirstName = "Sun", LastName = "Goku", Books = 101 };
            System.Console.WriteLine($"Fullname: {NameCalculation.FullName(sugoku)}");
            System.Console.WriteLine($"IsProlific: {AuthorRating.IsProlific(sugoku)}");
        }
    }

    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Books { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public bool IsProlific => Books > 0;
    }

    public struct AuthorData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Books { get; set; }
    }

    public static class NameCalculation
    {
        public static string FullName(AuthorData data)
        {
            return $"{data.FirstName} {data.LastName}";
        }
    }
    public static class AuthorRating
    {
        public static bool IsProlific(AuthorData data)
        {
            return data.Books > 100;
        }
    }

}
