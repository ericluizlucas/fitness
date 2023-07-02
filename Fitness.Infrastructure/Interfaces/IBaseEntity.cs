using System.ComponentModel.DataAnnotations;

namespace Fitness.Infrastructure.Interfaces
{
    public interface IBaseEntity
    {
        [Key]
        int Id { get; set; }
    }
}