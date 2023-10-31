using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv.data.Abstract;
using cv.entity.Concrete;

namespace cv.business.Concrete
{
    public class EducationManager : IEducationDal
    {
        IEducationDal _educationDal;
        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }
        public void Add(Education entity)
        {
            _educationDal.Add(entity);

        }

        public void Delete(Education entity)
        {
            _educationDal.Delete(entity);
        }

        public Education GetById(int id)
        {
            return _educationDal.GetById(id);
        }

        public List<Education> ListAll()
        {
            return _educationDal.ListAll();
        }

        public void Update(Education entity)
        {
            _educationDal.Update(entity);

        }
    }
}