using System.Data.Entity;

namespace PCAssemblyServices.Model.dataBase
{
    public abstract class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("DbConnectionString")
        {
        }

        //public abstract bool Insert<T>(T item);
        //public abstract bool Remove<T>(T item);
        //public abstract bool Edit<T>(T old, T future);
        //public abstract T Receive<T>();
    }
}
