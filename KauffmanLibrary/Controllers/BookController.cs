using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using KauffmanLibrary.Accessors;
using KauffmanLibrary.Models;

namespace KauffmanLibrary.Controllers
{ 

    [Route("api/books")]
    public class BookController : Controller
    {

        private readonly BookAccessor _bookAccessor;

        public BookController()
        {
            _bookAccessor = new BookAccessor();
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookAccessor.GetAllBooks();
        }

        [HttpPost]
        public string UpdateStatus([FromBody]string barcode, [FromBody] string name)
        {
            return "success";
        }
    }
}
