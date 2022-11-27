using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._11._2022
{
    internal static class CustomContains
    {
        public static bool Contains(this string cumle, string search)
        {

            string toLower = cumle.ToLower();

            string whiteSpace = " ";

            String.IsNullOrWhiteSpace(whiteSpace);

            bool start = toLower.StartsWith(search);

            bool end = toLower.EndsWith(search);

            string[] arrayString = toLower.Split();

            foreach (var item in arrayString)
            {
                if (item == search)
                {
                    return true;
                }
                else if (item.ToUpper() == search.ToUpper())
                {
                    return true;
                }
                else if (item.StartsWith(search))
                {
                    return true;
                }
                else if (item.EndsWith(search))
                {
                    return true;
                }
                else if (start)
                {
                    return true;
                }
                else if (end)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
