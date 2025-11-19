namespace Lecture08.Repositories
{
    using Lecture08.Models;
    using System.Collections.Generic;
    
    interface IReopsitory<T> where T : IEntity
    {
        void Add(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T updatedEntity);
        void Delete(T enitiy);
        int Count { get; }
    }   
}