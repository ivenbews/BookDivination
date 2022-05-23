using Parsing.Domain.Common;
using System.Collections.Generic;

namespace Parsing.Domain.Entities
{
    public class Book:EntityBase
    {
        public string Title { get; set; }
        public string Annotation { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public int PageCount { get; set; }
        public IEnumerable<Page> Pages { get; set; }
    }
}
