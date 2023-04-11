using CustomerDetails.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace CustomerDetails.Models
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}