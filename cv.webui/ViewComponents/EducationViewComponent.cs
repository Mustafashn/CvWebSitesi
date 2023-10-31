using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv.business.Concrete;
using cv.data.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace cv.webui.ViewComponents
{
    public class EducationViewComponent : ViewComponent
    {
        EducationManager educationManager = new EducationManager(new EfEducationRepository());
        public IViewComponentResult Invoke()
        {
            return View(educationManager.ListAll());
        }
    }
}