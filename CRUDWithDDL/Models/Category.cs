using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDWithDDL.Models
{
    public class Category
    {
        [Key]
        [DisplayName("Category Id")]
        [Required]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
    }
}
