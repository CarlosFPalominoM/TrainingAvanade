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
            _trainingDbContext.Add(album);
        }

        public IEnumerable<Album> Get()
        {
            return _trainingDbContext.Albums.Where(a => !a.IsDeleted);
        }

        public Album Get(string code)
        {
            return _trainingDbContext.Albums.FirstOrDefault(a => a.Code == code && !a.IsDeleted);
        }

        public void Update(Album album)
        {
            _trainingDbContext.Update(album);
        }
    }
}
