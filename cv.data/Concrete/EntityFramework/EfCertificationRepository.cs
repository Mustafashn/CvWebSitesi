using cv.data.Abstract;
using cv.entity.Concrete;

namespace cv.data.Concrete.EntityFramework
{
    public class EfCertificationRepository : EfGenericRepository<Certification>, ICertificationDal
    {

    }
}