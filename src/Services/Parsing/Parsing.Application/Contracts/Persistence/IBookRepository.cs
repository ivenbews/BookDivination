using Parsing.Domain.Entities;

namespace Parsing.Application.Contracts.Persistence
{
    public interface IBookRepository:IAsyncRepository<Book>
    {
    }
}
