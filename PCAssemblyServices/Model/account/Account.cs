namespace PCAssemblyServices.Model.account
{
    public abstract class Account
    {
        public string Name { get; }
        public string Password { get; }
        public AccountTypes AccountType { get; }
        public abstract bool SingIn();
    }
}
