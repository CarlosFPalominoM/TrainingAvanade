using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;

namespace Training.Core.Repositories
{
    public interface IBookingRepository
    {
        List<Booking> GetUserBookings(Guid user);
        void Create(Booking booking);
        void Update(Booking book);
        Booking Get(Guid book, Guid user);
    }
}
