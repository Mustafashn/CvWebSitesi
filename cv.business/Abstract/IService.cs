using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace cv.business.Abstract
{
    public interface IService<TEntity>
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        List<TEntity> ListAll();
        TEntity GetById(int id);
    }
}