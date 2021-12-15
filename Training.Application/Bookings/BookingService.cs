using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Repositories;

namespace Training.Application.Booking
{
    public class BookingService : IBookingService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IBookingRepository _bookingRepository;
        private readonly IUserRepository _userRepository;

        public BookingService(IBookRepository bookRepository, IBookingRepository bookingRepository, IUserRepository userRepository)
        {
            _bookRepository = bookRepository;
            _bookingRepository = bookingRepository;
            _userRepository = userRepository;
        }

        public void Create(BookingDto dto)
        {
            var booking = Map(dto);

            booking.Id = Guid.NewGuid();

            _bookingRepository.Create(booking);
        }

        public List<Core.Models.Booking> GetForUser(string dni)
        {
            return _bookingRepository.GetUserBookings(_userRepository.Get(dni).Id);
        }

        public void Update(BookingDto dto)
        {
            var booking = _bookingRepository.Get(_bookRepository.Get(dto.Isbn).Id, _userRepository.Get(dto.Dni).Id);

            booking.ReturnDate = dto.ReturnDate;

            _bookingRepository.Update(booking);
        }

        public void Delete(string isbn, string dni)
        {
            var booking = _bookingRepository.Get(_bookRepository.Get(isbn).Id, _userRepository.Get(dni).Id);

            booking.IsDeleted = true;

            _bookingRepository.Update(booking);
        }

        private Core.Models.Booking Map(BookingDto dto)
        {
            return new Core.Models.Booking
            {
                CreationDate = dto.CreationDate,
                IsDeleted = false,
                ReturnDate = dto.ReturnDate,
                Book = _bookRepository.Get(dto.Isbn).Id,
                User = _userRepository.Get(dto.Dni).Id
            };
        }
    }
}
