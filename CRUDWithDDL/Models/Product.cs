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
        public string Name { get; set; }
        public int  Price { get; set; }
        public int Qty { get; set; }

        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
        public virtual Category Categories { get; set; }


    }
}
