using Example4.Models;

namespace Example4.Repository.Interface
{
    public interface IRepository<T> where T : BaseObject
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
