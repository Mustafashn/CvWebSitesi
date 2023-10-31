using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv.data.Abstract;
using cv.entity.Concrete;

namespace cv.data.Concrete.EntityFramework
{
    public class EfEducationRepository : EfGenericRepository<Education>, IEducationDal
    {

    }
}