using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv.data.Abstract;

namespace cv.data.Concrete.EntityFramework
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            using (var ctx = new CvContext())
            {
                ctx.Set<TEntity>().Add(entity);
                ctx.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var ctx = new CvContext())
            {
                ctx.Set<TEntity>().Remove(entity);
                ctx.SaveChanges();
            }
        }

        public TEntity GetById(int id)
        {
            using (var ctx = new CvContext())
            {
                return ctx.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> ListAll()
        {
            using (var ctx = new CvContext())
            {
                return ctx.Set<TEntity>().ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var ctx = new CvContext())
            {
                ctx.Set<TEntity>().Update(entity);
                ctx.SaveChanges();
            }
        }
    }
}