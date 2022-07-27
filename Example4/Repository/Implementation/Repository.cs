using Example4.Models;
using Example4.Repository.Interface;

namespace Example4.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : BaseObject
    {
        private static List<T> _rep = new List<T>();

        public void Create(T entity)
        {
            _rep.Add(entity);
        }

        public void Delete(T entity)
        {
            _rep.Remove(entity);
        }

        public T Get(int id)
        {
            return _rep.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _rep;
        }

        public void Update(T entity)
        {
            var oldObject = _rep.FirstOrDefault(x => x.Id == entity.Id);
            var index = _rep.IndexOf(oldObject);
            _rep.Insert(index, entity);
        }
    }
}
