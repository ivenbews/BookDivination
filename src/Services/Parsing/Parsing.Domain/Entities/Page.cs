using Parsing.Domain.Common;
using System.Collections.Generic;

namespace Parsing.Domain.Entities
{
    public class Page:EntityBase
    {
        public int PageNumber { get; set; }
        public ICollection<Line> Lines { get; set; }
    }
}
