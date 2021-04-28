using PCAssemblyServices.Model.account;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PCAssemblyServices.Model.dataBase
{
    public class AccountContext : DataBaseContext
    {
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// Добавляет пользователя в БД
        /// </summary>
        /// <param name="acc">Новый аккаунт</param>
        /// <exception cref="ArgumentNullException">В случае, если переданный в аргумент аккаунт равен null</exception>
        /// <returns>True - если успешно</returns>
        public bool Add(User acc) //TODO: оформить тупа обработку исключений
        {
            if (acc == null)
                throw new ArgumentNullException(nameof(acc));
            try
            {
                using (AccountContext db = new AccountContext())
                {
                    db.Users.Add(acc);
                    int success = db.SaveChanges();
                    if (success > 0)
                        return true;
                }
            }
            catch (Exception) { return false; }
            return false;
        }
        /// <summary>
        /// Возвращает найденного по id пользователя
        /// </summary>
        /// <param name="id">Id пользователя</param>
        /// <exception cref="NullReferenceException">Если пользователь не найдет</exception>
        /// <exception cref="ArgumentException">Если введен id < 0</exception>
        /// <returns></returns>
        public User ReceiveById(int id)
        {
            if (id < 0)
                throw new ArgumentException(nameof(id));

            using (AccountContext db = new AccountContext())
            {
                var findUser = db.Users.Find(id);
                if (findUser != null)
                    return findUser;
                else
                    throw new NullReferenceException("Пользователь не найдет");
            }
        }
        /// <summary>
        /// Возвращает авторизованного пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <exception cref="ArgumentException">Переданы некорректные логин или пароль</exception>
        /// <exception cref="NullReferenceException">Пользователь не найдет</exception>
        /// <returns>Только авторизованный пользователь</returns>
        public async Task<User> AuthorizationAsync(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Введены некорректные данные");
            User authUser = null;
            return await Task.Run(() =>
            {
                using (AccountContext db = new AccountContext())
                {
                    authUser = db.Users.Where(user => user.Name == login &&
                                                                           user.Password == password).FirstOrDefault();
                    if (authUser != null)
                        return authUser;
                    throw new NullReferenceException("Пользователь не найдет");
                }
            });
            
        }
    }
}
