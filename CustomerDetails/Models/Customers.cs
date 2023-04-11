using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CustomerDetails.Models
{
    public class Customers : BaseEntity
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Address")]
        public string Address { get; set; } = string.Empty;
    }
}
