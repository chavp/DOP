using DOP.Tests.Datas;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOP.Tests.Funcs
{
    public static class NameCalculation
    {
        public static string FullName(this AuthorData data)
        {
            return $"{data.FirstName} {data.LastName}";
        }
    }
}
