using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.DAL.Base;
using Training.Core.Repositories;
using Training.Core.Models;
using Training.DAL.Context;

namespace Training.DAL.Implementations
{
    public class AlbumRepository : RepositoryBase, IAlbumRepository
    {
        public AlbumRepository(TrainingDbContext trainingDbContext)
            : base(trainingDbContext)
        { }

        public void Create(Album album)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Album> Get()
        {
            throw new NotImplementedException();
        }

        public Album Get(string code)
        {
            throw new NotImplementedException();
        }

        public void Update(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
