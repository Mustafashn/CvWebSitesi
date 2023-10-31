using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv.business.Abstract;
using cv.data.Abstract;
using cv.entity.Concrete;

namespace cv.business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void Add(About entity)
        {
            _aboutDal.Add(entity);

        }

        public void Delete(About entity)
        {
            _aboutDal.Delete(entity);

        }

        public About GetAbout()
        {
            return _aboutDal.GetAbout();
        }

        public About GetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> ListAll()
        {
            return _aboutDal.ListAll();
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}