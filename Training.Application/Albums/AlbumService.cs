using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Application.Base;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.Application.Albums
{
    public class AlbumService : ServiceBase, IAlbumService
    {
        private readonly IAlbumRepository _albumRepository;

        public AlbumService(IUnitOfWork unitOWork)
            : base(unitOWork)
        {
            _albumRepository = unitOWork.AlbumRepository;
        }

        public void Create(AlbumDto dto)
        {
            var album = Map(dto);

            album.Id = Guid.NewGuid();

            _albumRepository.Create(album);
            _unitOfWork.CommitTransaction();
        }

        public IEnumerable<AlbumDto> Get()
        {
            return _albumRepository.Get()
                .Select(MapEntity);
        }

        public AlbumDto Get(string code)
        {
            return MapEntity(_albumRepository.Get(code));
        }

        private Album Map(AlbumDto dto)
        {
            return new Album
            {
                Code = dto.Code,
                Name = dto.Name,
                Author = dto.Author
            };
        }

        private AlbumDto MapEntity(Album entity)
        {
            return new AlbumDto
            {
                Code = entity.Code,
                Name = entity.Name,
                Author = entity.Author
            };
        }
    }
}
