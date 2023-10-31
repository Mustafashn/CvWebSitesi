using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv.business.Abstract;
using cv.data.Abstract;
using cv.entity.Concrete;

namespace cv.business.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;
        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }
        public void Add(Experience entity)
        {
            _experienceDal.Add(entity);
        }

        public void Delete(Experience entity)
        {
            _experienceDal.Delete(entity);
        }

        public Experience GetById(int id)
        {
            return _experienceDal.GetById(id);
        }

        public List<Experience> ListAll()
        {
            return _experienceDal.ListAll();
        }

        public void Update(Experience entity)
        {
            _experienceDal.Update(entity);
        }
    }
}