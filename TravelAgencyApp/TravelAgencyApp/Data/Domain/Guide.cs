using System.ComponentModel.DataAnnotations;
namespace TravelAgencyApp.Data.Domain
{
    public class Guide
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        [Required]
        [Range(4, 60)]
        public string Language { get; set; }

    }
}
