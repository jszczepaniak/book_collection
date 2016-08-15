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

        public int bookId { get; set; }
        public string title { get; set; }
        public DateTime year { get; set; }
        public int authorId { get; set; }
        public string isbn { get; set; }
        public author Author { get; set; }

        //public book()
        //{

        //}
    public book(int cBookId, string cTitle, DateTime cYear, int cAuthorId, string cIsbn, author cAuthor)
    {
        bookId = cBookId;
        title = cTitle;
        cYear = year;
        authorId = cAuthorId;
        isbn = cIsbn;
        Author = cAuthor;
    }

}
}
