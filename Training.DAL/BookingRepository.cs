using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.DAL
{
    public class BookingRepository:IBookingRepository
    {
        private List<Booking> _bookings;

        public BookingRepository()
        {
            _bookings = new List<Booking>();
        }

        public void Create(Booking booking)
        {
            _bookings.Add(booking);
        }

        public Booking Get(Guid book, Guid user)
        {
            return _bookings.FirstOrDefault(b => b.Book == book && b.User == user);
        }

        public List<Booking> GetUserBookings(Guid userId)
        {
            return _bookings.Where(b => b.User == userId && !b.IsDeleted).ToList();
        }

        public void Update(Booking booking)
        {
            _bookings = _bookings.Where(x => x.Id != booking.Id).ToList();

            _bookings.Add(booking);
        }
    }
}
