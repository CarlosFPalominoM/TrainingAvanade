using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Application.Booking
{
    public class BookingDto
    {
        public string Isbn { get; set; }

        public string Dni { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}
