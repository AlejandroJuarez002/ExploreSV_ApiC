using System.ComponentModel.DataAnnotations;

namespace Exploresv.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }= default!;
    }
}
