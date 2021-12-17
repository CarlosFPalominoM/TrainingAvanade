using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.Application.Albums;

namespace Training.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var albums = _albumService.Get();

            return Ok(albums);
        }

        [HttpGet("{code}")]
        public IActionResult Get(string code)
        {
            var album = _albumService.Get(code);

            return Ok(album);
        }

        [HttpPost]
        public IActionResult Post(AlbumDto album)
        {
            _albumService.Create(album);

            return Ok();
        }
    }
}
