using MyShop.Coree.Models;
using System.Linq;

namespace MyShop.Coree.Contracts

{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string Id);
        T Find(string Id);
        void Insert(T t);
        void Update(T t);
    }
}