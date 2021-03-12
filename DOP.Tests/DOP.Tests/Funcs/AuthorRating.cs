using DOP.Tests.Datas;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOP.Tests.Funcs
{
    public static class AuthorRating
    {
        public static bool IsProlific(this AuthorData data)
        {
            return data.Books > 100;
        }
    }
}
