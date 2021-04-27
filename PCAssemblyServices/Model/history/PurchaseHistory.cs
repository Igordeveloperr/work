using PCAssemblyServices.Model.account;
using PCAssemblyServices.Model.basket;
using System.Collections.Generic;

namespace PCAssemblyServices.Model.history
{
    public class PurchaseHistory
    {
        public PurchaseHistory()
        {

        }
        public int Id { get; set; }
        public ICollection<ShopBasket> Histories { get; set; }
        public virtual User User { get; set; }
        public void ShowHistory()
        {

        }
    }
}
