using System.ComponentModel.DataAnnotations;
namespace TravelAgencyApp.Data.Domain
{
    public class TourPackage
    {
        public int Id { get; set; }

        public string PackageName { get; set; }
        [Required]
        public string Description { get; set; }

        public int Price { get; set; }

    }
}
