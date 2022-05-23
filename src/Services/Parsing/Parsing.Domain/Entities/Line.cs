using Parsing.Domain.Common;

namespace Parsing.Domain.Entities
{
    public class Line:EntityBase
    {
        public int LineNumber { get; set; }
        public string Text { get; set; }
    }
}
