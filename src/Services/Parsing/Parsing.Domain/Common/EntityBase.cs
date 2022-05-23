using System.ComponentModel.DataAnnotations;

namespace Parsing.Domain.Common
{
    public abstract class EntityBase
    {
        [Key] public int Id { get; set; }
    }

}
