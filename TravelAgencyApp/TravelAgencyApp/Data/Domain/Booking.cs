using System.ComponentModel.DataAnnotations;
namespace TravelAgencyApp.Data.Domain
{
    public class Booking
    {
        public int Id { get; set; }
       
        public string   BookingDate { get; set; }
        [Required]
        public int CustomerId { get; set; }

        public int TourPackageId { get; set; }

    }
}
