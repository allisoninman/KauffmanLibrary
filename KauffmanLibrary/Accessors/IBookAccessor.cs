using System;
using System.Collections.Generic;
using KauffmanLibrary.Models;

namespace KauffmanLibrary.Accessors
{
    public interface IBookAccessor
    {
        IEnumerable<Book> GetAllBooks();

        bool IsBookCheckedOut(string barcode);

        void AddLogEntry(string barcode, string name, string isCheckingOut);
    }  
}
