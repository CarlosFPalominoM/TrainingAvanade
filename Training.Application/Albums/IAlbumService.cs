using System.Collections.Generic;

namespace Training.Application.Albums
{
    public interface IAlbumService
    {
        void Create(AlbumDto dto);
        IEnumerable<AlbumDto> Get();
        AlbumDto Get(string code);
    }
}