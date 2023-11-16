using System.ComponentModel.DataAnnotations;
using University.Web.Validations;

namespace University.Web.Models.ViewModels
{
#nullable disable
    public class StudentCreateViewModel
    {
        [Required]
        public string NameFirstName { get; set; }
        [KalleAnka]
        public string NameLastName { get; set; }
        public string Email { get; set; }
        
        [CheckStreetNr(10)]
        public string AddressStreet { get; set; }
        public string AddressZipCode { get; set; }
        public string AddressCity { get; set; }
    }
}
