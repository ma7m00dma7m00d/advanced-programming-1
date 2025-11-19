namespace Lecture08.Repositories
{
    using Lecture08.Models;
    using System;
    using System.Collections.Generic;
    
    class ListRepository<T> : IReopsitory<T> where T : IEntity{
        private List<T> entities;
        private int nextId;

        public ListRepository(){
            entities = new List<T>();
            nextId = 1;
        }

        public int Count => entities.Count;

        public void Add(T entity){
            if(entity == null)
                throw new ArgumentNullException("entity to add can not be null");

            entity.Id = nextId++;
            entities.Add(entity);
        }

        public T GetById(int id){
            foreach (var entity in entities)
            {
                if(entity.Id == id)
                    return entity;
            }
            throw new KeyNotFoundException($"entity with id {id} not found");
        }

        public IEnumerable<T> GetAll(){
            return new List<T>(entities);
        }

        public void Update(T updatedEntity){
            if(updatedEntity == null)
                throw new ArgumentNullException("entity to update can not be null");
            
            for (int i = 0; i < entities.Count; i++)
            {
                if(entities[i].Id == updatedEntity.Id){
                    entities[i] = updatedEntity;
                    return;
                }
            }
            throw new KeyNotFoundException($"entity with id {updatedEntity.Id} not found");
        }

        public void Delete(T entity){
            if(entity == null)
                throw new ArgumentNullException("entity to delete can not be null");
            
            bool removed = entities.Remove(entity);
            if(!removed){
                throw new KeyNotFoundException($"entity with id {entity.Id} not found");
            }
        }
    }
}