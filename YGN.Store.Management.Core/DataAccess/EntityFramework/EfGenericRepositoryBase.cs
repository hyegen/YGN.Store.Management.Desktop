//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Runtime.Remoting.Contexts;
//using System.Text;
//using System.Threading.Tasks;
//using YGN.Store.Management.Core.Entities;


//namespace YGN.Store.Management.Core.DataAccess.EntityFramework
//{
//    public class EfGenericRepositoryBase<TEntity, TContext>
//       where TEntity : class, IEntity, new()
//       where TContext : DbContext, new()
//    {
//        public void Add(TEntity entity)
//        {
//            using (TContext context = new TContext())
//            {
//                var genericAdd = context.Entry(entity);
//                genericAdd.State = EntityState.Added;
//                context.SaveChanges();
//            }
//        }
//        public void Update(TEntity entity)
//        {
//            using (TContext context = new TContext())
//            {
//                var genericAdd = context.Entry(entity);
//                genericAdd.State = EntityState.Modified;
//                context.SaveChanges();
//            }
//        }
//        public void Delete(TEntity entity)
//        {
//            using (TContext context = new TContext())
//            {
//                var genericAdd = context.Entry(entity);
//                genericAdd.State = EntityState.Deleted;
//                context.SaveChanges();
//            }
//        }
//        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
//        {
//            using (TContext context = new TContext())
//            {
//                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();

//            }
//        }
//        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
//        {
//            using (TContext context = new TContext())
//            {
//                return context.Set<TEntity>().SingleOrDefault(filter);
//            }
//        }

//        public void UpdateRelatedEntityCollection<TEntity>(IEnumerable<TEntity> existingEntities, IEnumerable<TEntity> updatedEntities) 
//        {
//            using (TContext context = new TContext())
//            {
//                var addedEntities = updatedEntities.Except(existingEntities, x => x.Id);

//                var deletedEntities = existingEntities.Except(updatedEntities, x => x.Id);

//                var modifiedEntities = updatedEntities.Except(addedEntities, x => x.Id);

//                addedEntities.ToList<TEntity>().ForEach(x => context.Entry(x).State = EntityState.Added);

//                deletedEntities.ToList<TEntity>().ForEach(x => context.Entry(x).State = EntityState.Deleted);

//                foreach (var entity in modifiedEntities)
//                {
//                    var existingEntity = context.Set<TEntity>().Find(entity.Id);

//                    if (existingEntity != null)
//                    {
//                        var contextEntry = context.Entry(existingEntity);
//                        contextEntry.CurrentValues.SetValues(entity);
//                    }
//                }
//            }

//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Linq.Expressions;
//using YGN.Store.Management.Core.Entities;

//namespace YGN.Store.Management.Core.DataAccess.EntityFramework
//{
//    public class EfGenericRepositoryBase<TEntity, TContext>
//       where TEntity : class, IEntity, new()
//       where TContext : DbContext, new()
//    {
//        public void Add(TEntity entity)
//        {
//            using (TContext context = new TContext())
//            {
//                var genericAdd = context.Entry(entity);
//                genericAdd.State = EntityState.Added;
//                context.SaveChanges();
//            }
//        }

//        public void Update(TEntity entity)
//        {
//            using (TContext context = new TContext())
//            {
//                var genericAdd = context.Entry(entity);
//                genericAdd.State = EntityState.Modified;
//                context.SaveChanges();
//            }
//        }

//        public void Delete(TEntity entity)
//        {
//            using (TContext context = new TContext())
//            {
//                var genericAdd = context.Entry(entity);
//                genericAdd.State = EntityState.Deleted;
//                context.SaveChanges();
//            }
//        }

//        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
//        {
//            using (TContext context = new TContext())
//            {
//                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
//            }
//        }

//        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
//        {
//            using (TContext context = new TContext())
//            {
//                return context.Set<TEntity>().SingleOrDefault(filter);
//            }
//        }

//        public void UpdateRelatedEntityCollection<T>(IEnumerable<T> existingEntities, IEnumerable<T> updatedEntities) where T : class, IEntity, new()
//        {
//            using (TContext context = new TContext())
//            {
//                var addedEntities = updatedEntities.AsQueryable().Except(existingEntities.AsQueryable(), new EntityComparer<T>());
//                var deletedEntities = existingEntities.AsQueryable().Except(updatedEntities.AsQueryable(), new EntityComparer<T>());
//                var modifiedEntities = updatedEntities.AsQueryable().Except(addedEntities, new EntityComparer<T>());

//                addedEntities.ToList().ForEach(x => context.Entry(x).State = EntityState.Added);
//                deletedEntities.ToList().ForEach(x => context.Entry(x).State = EntityState.Deleted);

//                foreach (var entity in modifiedEntities)
//                {
//                    var existingEntity = context.Set<T>().Find(entity.Id);

//                    if (existingEntity != null)
//                    {
//                        var contextEntry = context.Entry(existingEntity);
//                        contextEntry.CurrentValues.SetValues(entity);
//                    }
//                }

//                context.SaveChanges();
//            }
//        }
//    }

//    public class EntityComparer<T> : IEqualityComparer<T> where T : IEntity
//    {
//        public bool Equals(T x, T y)
//        {
//            return x.Id == y.Id;
//        }

//        public int GetHashCode(T obj)
//        {
//            return obj.Id.GetHashCode();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using YGN.Store.Management.Core.Entities;

namespace YGN.Store.Management.Core.DataAccess.EntityFramework
{
    public class EfGenericRepositoryBase<TEntity, TContext>
       where TEntity : class, IEntity, new()
       where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var genericAdd = context.Entry(entity);
                genericAdd.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var genericAdd = context.Entry(entity);
                genericAdd.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var genericAdd = context.Entry(entity);
                genericAdd.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
        public void UpdateRelatedEntities<T>(IEnumerable<T> existingEntities, IEnumerable<T> updatedEntities, DbContext context) where T : class, IEntity, new()
        {
            var addedEntities = updatedEntities.Except(existingEntities, new EntityComparer<T>()).ToList();
            var deletedEntities = existingEntities.Except(updatedEntities, new EntityComparer<T>()).ToList();

            foreach (var addedEntity in addedEntities)
            {
                context.Set<T>().Add(addedEntity);
            }

            foreach (var deletedEntity in deletedEntities)
            {
                context.Set<T>().Remove(deletedEntity);
            }

            foreach (var updatedEntity in updatedEntities)
            {
                var existingEntity = existingEntities.FirstOrDefault(e => e.Id == updatedEntity.Id);
                if (existingEntity != null)
                {
                    context.Entry(existingEntity).CurrentValues.SetValues(updatedEntity);
                }
            }
        }
    }
    public class EntityComparer<T> : IEqualityComparer<T> where T : IEntity
    {
        public bool Equals(T x, T y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(T obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
