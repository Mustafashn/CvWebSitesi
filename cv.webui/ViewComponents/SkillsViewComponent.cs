using cv.business.Concrete;
using cv.data.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace cv.webui.ViewComponents
{
    public class SkillsViewComponent : ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillRepository());
        public IViewComponentResult Invoke()
        {
            return View(skillManager.ListAll());
        }
    }
}