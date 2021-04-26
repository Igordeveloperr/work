using PCAssemblyServices.Model.catalog.view;
using System.Collections.Generic;

namespace PCAssemblyServices.Model.basket
{
    public class ShopBasket
    {
        public List<ProductView> Products { get; }
        public int TotalPrice { get; }
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
