using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv.business.Concrete;
using cv.data.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace cv.webui.ViewComponents
{

    public class ExperiencesViewComponent : ViewComponent
    {
        ExperienceManager experienceManageranager = new ExperienceManager(new EfExperienceRepository());

        public IViewComponentResult Invoke()
        {
            return View(experienceManageranager.ListAll());
        }
    }
}