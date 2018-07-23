using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using KauffmanLibrary.Accessors;
using KauffmanLibrary.Engines;
using KauffmanLibrary.Models;

namespace KauffmanLibrary.Controllers
{ 

    [Route("api/books")]
    public class BookController : Controller
    {

        private readonly IBookEngine _bookEngine;

        public BookController(IBookEngine bookEngine)
        {
            _bookEngine = bookEngine;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookEngine.GetAllBooks();
        }

        [HttpPost]
        public string UpdateStatus([FromBody]string barcode, [FromBody] string name)
        {
            return "success";
        }
    }
}
