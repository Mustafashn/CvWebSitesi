using cv.entity.Concrete;

namespace cv.data.Abstract
{
    public interface IAboutDal : IGenericDal<About>
    {
        About GetAbout();
    }
}