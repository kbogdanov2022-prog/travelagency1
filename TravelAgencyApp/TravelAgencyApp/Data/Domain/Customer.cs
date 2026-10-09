using System.ComponentModel.DataAnnotations;

namespace TravelAgencyApp.Data.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }        
        [Required]
        [Range(4,60)]
        public string Email { get; set; }   
         
        public string PhoneNumber { get; set; }

    }
}
