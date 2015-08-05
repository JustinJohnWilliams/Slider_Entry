using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Slider_Entry.ValueConverters
{
    public class DecimalToCurrencyStringConverter : IValueConverter
    {
        //from number to string
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            decimal val;
            if (!decimal.TryParse(value.ToString(), out val))
            {
                //not a valid number
                throw new Exception(
                    "IntToCurrencyStringConverter.ConvertBack expected a number in value. Received: {0}".With(value.ToString()));
            }

            return val.ToCurrency(0);
        }

        //from string to number
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var formattedString = value.ToString();
            if (!formattedString.Contains("$"))
            {
                //not in correct format
                return value;
            }

            var isNegative = formattedString.Contains("(") && formattedString.Contains(")");

            var charsToRemove = new[] { "$", ",", "(", ")" };

            foreach (var c in charsToRemove)
            {
                formattedString = formattedString.Replace(c, String.Empty);
            }

            if (string.IsNullOrEmpty(formattedString))
            {
                return 0;
            }

            var currency = System.Convert.ToDecimal(formattedString);

            return isNegative ? (-1 * currency) : currency;
        }
    }
}
