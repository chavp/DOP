using System;
using System.Collections.Generic;
using System.Text;

namespace DOP.Tests.Models
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Books { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public bool IsProlific => Books > 0;
    }
}
