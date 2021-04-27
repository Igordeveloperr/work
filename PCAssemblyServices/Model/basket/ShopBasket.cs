using PCAssemblyServices.Model.account;
using PCAssemblyServices.Model.catalog.view;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PCAssemblyServices.Model.basket
{
    public class ShopBasket
    {
        [Key]
        public int Id { get; set; }
        public ICollection<ProductView> Products { get; set; }
        public int TotalPrice { get; set; }
        public virtual User User { get; set; }
        public void ShowProducts()
        {

        }
        public int CalculateOrderAmount()
        {
            return -1;
        }
        public void Clear()
        {

        }
        public void DeleteProduct(ProductView product)
        {

        }
        public void Buy()
        {

        }
    }
}
