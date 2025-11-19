namespace Lecture08.Repositories
{
    using System;
    using System.Collections.Generic;
    using Lecture08.Models;
    using Lecture08.Utilities;

    class ArrayRepository<T> : IReopsitory<T> where T : IEntity{
        private T[] entities;
        private int cnt;
        private int nextId;

        public ArrayRepository(int len){
            entities = new T[len];
            cnt = 0 ;
            nextId = 1;

        }

        public int Count => cnt;

        public void Add(T entity){
            if(entity == null)
                throw new ArgumentNullException("entity to add can not be null");
            if(cnt == entities.Length)
                Helper.ResizeArray<T>(ref entities, entities.Length*2);
                // Array.Resize(ref entities,entities.Length*2); //we can use this prebuilt method instead of the method we built

            entity.Id = nextId++;
            entities[cnt++]= entity;
        }

        public T GetById(int id){
            for (int i = 0; i < cnt; i++)
            {
                if(entities[i].Id == id)
                    return entities[i];
            }
            // we can return the default value of T if not found 
            // return default(T);
            // or we can throw an exception 
            throw new KeyNotFoundException($"entity with id {id} not found");
        }

        public  IEnumerable<T> GetAll(){
            // if (cnt == 0)
                // throw new 
            var array = new T[cnt];
            Array.Copy(entities,array,cnt);
            return array;
        }

        public void Update(T updatedEntity){
            if(updatedEntity == null)
                throw new ArgumentNullException("entity to update can not be null");
            
            for (int i = 0; i < cnt; i++)
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
            
            for (int i = 0; i < cnt; i++)
            {
                if(entities[i].Id == entity.Id){
                    //shift elements to left
                    for (int j = i; j < cnt -1; j++)
                    {
                        entities[j] = entities[j+1];
                    }
                    entities[cnt -1] = default(T)!;
                    cnt--;
                    return;
                }
            }
            throw new KeyNotFoundException($"entity with id {entity.Id} not found");
        }
    }
}