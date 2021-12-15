using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Contracts;

namespace Training.Core.Models
{
    public class Booking : IRemovable
    {
        public bool IsDeleted { get; set; }

        public Guid Id { get; set; }

        public Guid Book { get; set; }

        public Guid User { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}
