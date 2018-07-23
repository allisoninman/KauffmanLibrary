using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KauffmanLibrary.Accessors;
using KauffmanLibrary.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
    }
}
