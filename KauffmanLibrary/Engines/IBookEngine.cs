using System.Collections.Generic;
using KauffmanLibrary.Models;

namespace KauffmanLibrary.Engines
{
    public interface IBookEngine
    {
        IEnumerable<Book> GetAllBooks();

        void UpdateStatus(string barcode, string name, string isCheckingOut);
    }
}
