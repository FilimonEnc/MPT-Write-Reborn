using DomainLair.DataBase.Entity;
using DomainLair.DataBase.Spetifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLair.DataBase
{
    public class Repository
    {
        private DataBaseContext context = new DataBaseContext();

        Repository()
        {
            context = new DataBaseContext();
        }

        public async static Task<int> Create<T>(T entity) where T : class, IEntity
        {
            var repo = new Repository();
            var dbSet = repo.context.Set<T>();
            if (dbSet.Contains(entity))
            {
                repo.context.Entry(entity).State = EntityState.Modified;

                return await repo.context.SaveChangesAsync();
            }
            dbSet.Add(entity);
            return await repo.context.SaveChangesAsync();

        }

        public async static Task<int> Create<T>(params T[] entities) where T : class, IEntity
        {
            int count = 0;
            foreach (var entity in entities)
            {
                count += await Create(entity);
            }
            return count;
        }

        public async static Task<int> Delete<T>(Func<T, bool> specification) where T : class, IEntity
        {
            var repo = new Repository();
            var dbSet = repo.context.Set<T>();

            dbSet.RemoveRange(Get(specification));

            return await repo.context.SaveChangesAsync();
        }

        public async static Task<int> Delete<T>(ISpecification<T> specification) where T : class, IEntity
        {
            return await Delete<T>(specification.IsSpecificatedBy);
        }

        public static IEnumerable<T> Get<T>(Func<T, bool> specification) where T : class, IEntity
        {
            var repo = new Repository();
            var dbSet = repo.context.Set<T>();
            
            return dbSet.AsNoTracking().Where(specification).ToList();
        }

        public static IEnumerable<T> Get<T>(ISpecification<T> specification) where T : class, IEntity
        {
            return Get<T>(specification.IsSpecificatedBy);
        }

        
    }

}
