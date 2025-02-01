using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDWithDDL.Models
{
    public class Category
    {
        [Key]
        [DisplayName("Category Id")]
        public int Id { get; set; }

        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
    }
}
