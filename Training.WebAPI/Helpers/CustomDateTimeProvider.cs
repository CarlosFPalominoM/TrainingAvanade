using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training.WebAPI.Helpers
{
    public class CustomDateTimeProvider : ICustomDateTimeProvider
    {
        public DateTime GetCurrentSystemDate()
        {
            return DateTime.Now;
        }
    }
}
