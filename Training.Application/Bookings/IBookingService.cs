using System.Collections.Generic;

namespace Training.Application.Booking
{
    public interface IBookingService
    {
        void Create(BookingDto dto);
        void Delete(string isbn, string dni);
        List<Core.Models.Booking> GetForUser(string dni);
        void Update(BookingDto dto);
    }
}