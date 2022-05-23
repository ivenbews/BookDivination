using AutoMapper;
using MediatR;
using Parsing.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parsing.Application.Features.Books.Queries.GetBooskListQuery
{
    public class GetBooksListQueryHandler : IRequestHandler<GetBooksListQuery, List<BookVm>>
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;

        public GetBooksListQueryHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<List<BookVm>> Handle(GetBooksListQuery request, CancellationToken cancellationToken)
        {
            var bookList = await _bookRepository.GetAllAsync();
            return _mapper.Map<List<BookVm>>(bookList);
        }
    }
}
