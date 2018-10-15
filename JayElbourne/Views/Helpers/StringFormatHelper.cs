using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace JayElbourne.Views.Helpers
{
    public class StringFormatHelper
    {
        public string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;

            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        public string TitleCase(string value, bool runLowerCase)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            string adjustedValue = value;

            if (runLowerCase)
                value = value.ToLower();

            return textInfo.ToTitleCase(adjustedValue);
        }
    }
}
