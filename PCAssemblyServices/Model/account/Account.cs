using PCAssemblyServices.Model.basket;
using PCAssemblyServices.Model.history;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PCAssemblyServices.Model.account
{
    public abstract class Account
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public AccountTypes AccountType { get; set; }
        public virtual  ICollection<PurchaseHistory> History { get; set; }
        public virtual ICollection<ShopBasket> Basket { get; set; }
        public abstract bool SingIn();
    }
}
