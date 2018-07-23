using System.Collections.Generic;
using KauffmanLibrary.Accessors;
using KauffmanLibrary.Models;

namespace KauffmanLibrary.Engines
{
    public class BookEngine : IBookEngine
    {
        private readonly IBookAccessor _bookAccessor;

        public BookEngine(IBookAccessor bookAccessor)
        {
            _bookAccessor = bookAccessor;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookAccessor.GetAllBooks();
        }

        public void UpdateStatus(string barcode, string name, string isCheckingOut)
        {

        }
    }
}
