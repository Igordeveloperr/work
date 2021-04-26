using PCAssemblyServices.Model.basket;
using PCAssemblyServices.Model.history;

namespace PCAssemblyServices.Model.account
{
    public abstract class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public AccountTypes AccountType { get; set; }
        public virtual PurchaseHistory History { get; set; }
        public virtual ShopBasket Basket { get; set; }
        public abstract bool SingIn();
    }
}
