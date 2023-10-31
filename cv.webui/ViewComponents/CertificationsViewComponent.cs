
using cv.business.Concrete;
using cv.data.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace cv.webui.ViewComponents
{
    public class CertificationsViewComponent : ViewComponent
    {
        CertificationManager certificationManager = new CertificationManager(new EfCertificationRepository());
        public IViewComponentResult Invoke()
        {
            return View(certificationManager.ListAll());
        }
    }
}