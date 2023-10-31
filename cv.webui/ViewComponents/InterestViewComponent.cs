using cv.business.Concrete;
using cv.data.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace cv.webui.ViewComponents
{
    public class InterestViewComponent : ViewComponent
    {
        InterestManager interestManager = new InterestManager(new EfInterestRepository());
        public IViewComponentResult Invoke()
        {
            return View(interestManager.ListAll());
        }

    }
}