using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class ProductColor
    {
        public int Id { get; set; }
        public string name { get; set; }

        [ForeignKey("Product")]
        public int productId { get; set; }
        public virtual Product Product { get; set; }
    }
}
