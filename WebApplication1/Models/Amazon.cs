using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Amazon
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
