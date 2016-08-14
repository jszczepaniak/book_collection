using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_collection
{
    [Serializable()]
    class book
    {

        int bookId;
        string title;
        DateTime year;
        int authorId;
        string isbn;

        public book()
        {

        }
        public book(int cBookId, string cTitle, DateTime cYear, int cAuthorId, string cIsbn)
        {
            bookId = cBookId;
            title = cTitle;
            cYear = year;
            authorId = cAuthorId;
            isbn = cIsbn;
        }

    }
}
