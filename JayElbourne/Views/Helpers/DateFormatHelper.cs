using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JayElbourne.Views.Helpers
{
    public class DateFormatHelper
    {
        public string AsReadableDate(DateTime date)
        {
            return date.ToString("D");
        }
    }
}
