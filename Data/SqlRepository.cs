using Microsoft.EntityFrameworkCore;
using RaffleApp.Contracts;
using RaffleApp.Domain;
using System.Linq;

namespace RaffleApp
{
    public class SqlRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly RaffleContext _context;
        internal DbSet<T> _dbSet;
        public SqlRepository(RaffleContext context)
        {
            _context = context;
            this._dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            this._dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void EmptyDatabase()
        {
            foreach (var entity in this._dbSet)
            {
                this._dbSet.Remove(entity);
            }
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return this._dbSet.AsQueryable();
        }
    }
}
