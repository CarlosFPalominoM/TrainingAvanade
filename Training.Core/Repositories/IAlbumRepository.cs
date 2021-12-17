﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;

namespace Training.Core.Repositories
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> Get();
        Album Get(string code);
        void Create(Album album);
        void Update(Album album);
    }
}