﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Training.Application.Books;
using Training.Core.Models;

namespace Training.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var books= _bookService.Get();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Book book = _bookService.Get(id);

            return Ok(book);
        }

        [HttpPut]
        public IActionResult Put(Book book)
        {
            _bookService.Update(book);
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Book book)
        {
            _bookService.Create(book);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _bookService.Remove(id);

            return Ok();
        }

    }
}
