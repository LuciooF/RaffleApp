using System.Linq;

namespace RaffleApp.Contracts
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        void Add(T entity);

        void EmptyDatabase();
    }
}
