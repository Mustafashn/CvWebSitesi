using cv.business.Concrete;
using cv.data.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace cv.webui.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());

        public IViewComponentResult Invoke()
        {
            return View(aboutManager.GetAbout());
        }

    }
}