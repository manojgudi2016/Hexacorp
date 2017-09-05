using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace EFCrudOperationDemoApp.BO
{
    public class GenericBO<T> where T:class
    {
        private EFDemoDbEntities context = new EFDemoDbEntities();
        DbSet es;
        public GenericBO()
        {
            es = context.Set<T>();
        }
        public T GetDetails(int id)
        {
            return (T) es.Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return (IEnumerable<T>) es;
        }
        public T Insert(T entity)
        {
            es.Add(entity);
            context.SaveChanges();
            //Send welcome message to emp by email...
            return entity;
        }
        public void Update(T emp)
        {
            context.Entry(emp).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            T entity = (T) es.Find(id);
            es.Remove(entity);
            context.SaveChanges();
        }
        protected void Dispose(bool disposing)
        {
            context.Dispose();
            //base.Dispose(disposing);
        }
    }
}