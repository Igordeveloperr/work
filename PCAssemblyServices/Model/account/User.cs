using PCAssemblyServices.Model.dataBase;

namespace PCAssemblyServices.Model.account
{
    public class User : Account
    {
        public override bool SingIn()
        {
            //TODO: realize sing in (user)
            return false;
        }
        public bool SingUp()
        {
            AccountContext account = new AccountContext();
            account.Add(this);
            return false;
        }
    }
}
