using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cv.data.Abstract
{
    public interface IGenericDal<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        List<TEntity> ListAll();
        TEntity GetById(int id);
    }
}