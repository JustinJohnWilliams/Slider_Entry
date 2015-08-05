using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slider_Entry
{
    public static class StringExtensions
    {
        public static string With(this string str, params object[] args)
        {
            return String.Format(str, args);
        }

        public static bool IsEmpty(this string str)
        {
            return String.IsNullOrEmpty(str);
        }

        public static bool IsNotEmpty(this string str)
        {
            return !String.IsNullOrEmpty(str);
        }
    }
}
