using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CustomerDetails.Models
{
    public class Customers : BaseEntity
    {
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; } = string.Empty;

        [Display(Name = "Customer Description")]
        public string CustomerDescription { get; set; } = string.Empty;
    }
}
