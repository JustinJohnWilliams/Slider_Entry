using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slider_Entry
{
    public static class DecimalExtensions
    {
        public static string ToCurrency(this decimal moneyValue, int digits = 2)
        {
            // Gets a NumberFormatInfo associated with the en-US culture.
            var nfi = new CultureInfo("en-US").NumberFormat;

            nfi.CurrencyDecimalDigits = Math.Min(Math.Abs(digits), 2);

            return moneyValue.ToString("C", nfi);
        }

        public static string ToCurrency(this decimal? moneyValue, int digits = 2)
        {
            var temp = moneyValue ?? 0M;

            return temp.ToCurrency(digits);
        }
    }
}
