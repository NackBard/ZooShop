using System.ComponentModel.DataAnnotations;

namespace MyEShop.Models
{
    public class Products
    {
        [Key]
        public int ID_Product { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Tree_Picture { get; set; }
    }
}
