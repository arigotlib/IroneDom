using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Shops
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string adrres { get; set; }
        public string phonNumber { get; set; }
        public int MonthlyRent { get; set; }

        [Required(ErrorMessage = "")]
        public int amazonId { get; set; }
        public Amazon amazon  { get; set; }
    }
}
