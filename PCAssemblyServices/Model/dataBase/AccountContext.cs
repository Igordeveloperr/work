using PCAssemblyServices.Model.account;
using System;
using System.Data.Entity;

namespace PCAssemblyServices.Model.dataBase
{
    public class AccountContext : DataBaseContext
    {
        public DbSet<User> Users { get; set; }
        public bool Insert(User acc) //TODO: оформить тупа обработку исключений
        {
            if (acc == null)
                throw new ArgumentNullException(nameof(acc));
            using (AccountContext db = new AccountContext())
            {
                db.Users.Add(acc);
                int success = db.SaveChanges();
                if (success > 0)
                    return true;
            }
            return false;
        }
        //public bool Receive()
        //{

        //}

    }
}
