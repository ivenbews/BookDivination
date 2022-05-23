using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing.Application.Features.Books.Queries.GetBooskListQuery
{
    public class GetBooksListQuery : IRequest<List<BookVm>>
    {
    }
}
