using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDWithDDL.Models
{
    public class Product
    {
        [Key]
        [DisplayName("Product ID")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required]
        public string Name { get; set; }
        [Required]
        public int  Price { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]

        [ForeignKey("Categories")]
       
        public int CategoryId { get; set; }
        [Required]
        public virtual Category Categories { get; set; }


    }
}
