using cv.entity.Concrete;

namespace cv.business.Abstract
{
    public interface IAboutService : IService<About>
    {
        About GetAbout();

    }
}