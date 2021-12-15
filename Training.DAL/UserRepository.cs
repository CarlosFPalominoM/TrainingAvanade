using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.DAL
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users;

        public UserRepository()
        {
            _users = new List<User>();

            for (int i = 0; i < 5; i++)
                _users.Add(new User { Id = Guid.NewGuid(), Dni = $"123457{i}-A", Name = $"Nombre Apellido {i}", Address = $"Calle Training, nº {i}" });
        }

        public User Get(string dni)
        {
            return _users.FirstOrDefault(u=>u.Dni == dni);
        }
    }
}
