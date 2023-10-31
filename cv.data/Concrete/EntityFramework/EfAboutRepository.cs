using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv.data.Abstract;
using cv.entity.Concrete;

namespace cv.data.Concrete.EntityFramework
{
    public class EfAboutRepository : EfGenericRepository<About>, IAboutDal
    {
        public About GetAbout()
        {
            using (var ctx = new CvContext())
            {
                return ctx.Abouts.Where(i => i.IsActive == true).First();
            }
        }
    }
}