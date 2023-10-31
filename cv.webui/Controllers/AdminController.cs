using System;
using System.IO;
using System.Threading.Tasks;
using cv.business.Concrete;
using cv.data.Concrete.EntityFramework;
using cv.entity.Concrete;
using cv.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace cv.webui.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceRepository());
        SkillManager skillManager = new SkillManager(new EfSkillRepository());
        EducationManager educationManager = new EducationManager(new EfEducationRepository());
        CertificationManager certificationManager = new CertificationManager(new EfCertificationRepository());
        ContactManager contactManager = new ContactManager(new EfContactRepository());
        InterestManager interestManager = new InterestManager(new EfInterestRepository());
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Experiences()
        {

            return View(experienceManager.ListAll());
        }
        public IActionResult ExperienceAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ExperienceAdd(ExperienceModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var experience = new Experience()
            {
                Title = model.Title,
                SubTitle = model.SubTitle,
                FirstDate = model.FirstDate,
                LastDate = model.LastDate,
                Description = model.Description
            };
            experienceManager.Add(experience);
            return RedirectToAction("Experiences");
        }
        [HttpPost]
        public IActionResult DeleteExperience(int ExperienceId)
        {
            var experience = experienceManager.GetById(ExperienceId);
            if (experience == null)
            {
                return NotFound();
            }
            experienceManager.Delete(experience);
            return RedirectToAction("Experiences");
        }
        [HttpGet]
        public IActionResult ExperienceEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = experienceManager.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new ExperienceModel()
            {
                ExperienceId = entity.ExperienceId,
                Title = entity.Title,
                SubTitle = entity.SubTitle,
                FirstDate = entity.FirstDate,
                LastDate = entity.LastDate,
                Description = entity.Description
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult ExperienceEdit(ExperienceModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = experienceManager.GetById(model.ExperienceId);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.ExperienceId = model.ExperienceId;
                entity.SubTitle = model.SubTitle;
                entity.LastDate = model.LastDate;
                entity.FirstDate = model.FirstDate;
                entity.Description = model.Description;
                entity.Title = model.Title;

                experienceManager.Update(entity);
                return RedirectToAction("Experiences");
            }
            return View();
        }
        public IActionResult Skills()
        {
            return View(skillManager.ListAll());
        }
        public IActionResult SkillAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SkillAdd(SkillModel model)
        {
            if (ModelState.IsValid)
            {
                var skill = new Skill()
                {
                    SkillName = model.SkillName,
                    SkillImage = model.SkillImage,
                    Perfection = model.Perfection
                };
                skillManager.Add(skill);
                return RedirectToAction("Skills");
            }
            return View();
        }

        [HttpPost]
        public IActionResult SkillDelete(int SkillId)
        {
            if (SkillId == 0)
            {
                return NotFound();
            }
            var skill = skillManager.GetById(SkillId);
            if (skill == null)
            {
                return NotFound();
            }
            skillManager.Delete(skill);
            return RedirectToAction("Skills");
        }
        public IActionResult SkillEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = skillManager.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new SkillModel()
            {
                SkillId = (int)id,
                SkillName = entity.SkillName,
                SkillImage = entity.SkillImage,
                Perfection = entity.Perfection
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult SkillEdit(SkillModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = skillManager.GetById(model.SkillId);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.SkillName = model.SkillName;
                entity.SkillImage = model.SkillImage;
                entity.Perfection = model.Perfection;

                skillManager.Update(entity);
                return RedirectToAction("Skills");
            }
            return View(model);
        }
        public IActionResult Educations()
        {
            return View(educationManager.ListAll());
        }
        public IActionResult EducationAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EducationAdd(EducationModel model)
        {
            if (ModelState.IsValid)
            {
                var education = new Education()
                {
                    Title = model.Title,
                    SubTitle = model.SubTitle,
                    FirstDate = model.FirstDate,
                    LastDate = model.LastDate,
                    GPA = model.GPA
                };
                educationManager.Add(education);
                return RedirectToAction("Educations");
            }
            return View();
        }
        [HttpPost]
        public IActionResult EducationDelete(int EducationId)
        {
            if (EducationId == 0)
            {
                return NotFound();
            }
            var education = educationManager.GetById(EducationId);
            if (education == null)
            {
                return NotFound();
            }
            educationManager.Delete(education);
            return RedirectToAction("Educations");
        }
        public IActionResult EducationEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = educationManager.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new EducationModel()
            {
                EducationId = (int)id,
                Title = entity.Title,
                SubTitle = entity.SubTitle,
                FirstDate = entity.FirstDate,
                LastDate = entity.LastDate,
                GPA = entity.GPA
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EducationEdit(EducationModel model)
        {
            if (ModelState.IsValid)
            {
                var education = educationManager.GetById(model.EducationId);
                if (education == null)
                {
                    return NotFound();
                }

                education.Title = model.Title;
                education.SubTitle = model.SubTitle;
                education.FirstDate = model.FirstDate;
                education.LastDate = model.LastDate;
                education.GPA = model.GPA;
                educationManager.Update(education);

                return RedirectToAction("Educations");
            }
            return View(model);
        }
        public IActionResult Certificates()
        {
            return View(certificationManager.ListAll());
        }
        public IActionResult CertificateEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = certificationManager.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new CertificateModel()
            {
                CertificationId = (int)id,
                Description = entity.Description,
                Date = entity.Date
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult CertificateEdit(CertificateModel model)
        {
            if (ModelState.IsValid)
            {
                var certificate = certificationManager.GetById(model.CertificationId);
                if (certificate == null)
                {
                    return NotFound();
                }
                certificate.Description = model.Description;
                certificate.Date = model.Date;
                certificationManager.Update(certificate);

                return RedirectToAction("Certificates");
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult CertificateDelete(int CertificationId)
        {
            if (CertificationId == 0)
            {
                return NotFound();
            }
            var certificate = certificationManager.GetById(CertificationId);
            if (certificate == null)
            {
                return NotFound();
            }
            certificationManager.Delete(certificate);
            return RedirectToAction("Certificates");
        }
        public IActionResult CertificateAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CertificateAdd(CertificateModel model)
        {
            if (ModelState.IsValid)
            {
                var certification = new Certification()
                {
                    Description = model.Description,
                    Date = model.Date
                };
                certificationManager.Add(certification);
                return RedirectToAction("Certificates");
            }
            return View();
        }
        public IActionResult Contacts()
        {
            return View(contactManager.ListAll());
        }
        public IActionResult Interests()
        {
            return View(interestManager.ListAll());
        }
        public IActionResult InterestAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InterestAdd(InterestModel model)
        {
            if (ModelState.IsValid)
            {
                var interest = new Interest()
                {
                    Description = model.Description
                };
                interestManager.Add(interest);
                return RedirectToAction("Interests");
            }
            return View(model);
        }
        public IActionResult InterestEdit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var entity = interestManager.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new InterestModel()
            {
                Description = entity.Description,
                InterestId = entity.InterestId,
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult InterestEdit(InterestModel model)
        {
            if (ModelState.IsValid)
            {
                var interest = interestManager.GetById(model.InterestId);
                if (interest == null)
                {
                    return NotFound();
                }
                interest.Description = model.Description;
                interestManager.Update(interest);

                return RedirectToAction("Interests");
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult InterestDelete(int InterestId)
        {
            if (InterestId == 0)
            {
                return NotFound();
            }
            var interest = interestManager.GetById(InterestId);
            if (interest == null)
            {
                return NotFound();
            }
            interestManager.Delete(interest);

            return RedirectToAction("Interests");

        }
        public IActionResult About()
        {
            return View(aboutManager.ListAll());
        }
        public IActionResult AboutEdit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var about = aboutManager.GetById(id);
            if (about == null)
            {
                return NotFound();
            }
            var model = new AboutModel()
            {
                AboutId = id,
                Name = about.Name,
                Surname = about.Surname,
                Description = about.Description,
                Address = about.Address,
                Mail = about.Mail,
                ImageUrl = about.ImageUrl,
                IsActive = about.IsActive
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AboutEdit(AboutModel model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var entity = aboutManager.GetById(model.AboutId);
                if (entity == null)
                {
                    return NotFound();
                }

                entity.Name = model.Name;
                entity.Surname = model.Surname;
                entity.Address = model.Address;
                entity.Description = model.Description;
                entity.IsActive = model.IsActive;
                entity.Mail = model.Mail;

                if (file != null)
                {
                    entity.ImageUrl = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\admin\\dist\\img\\AboutImg", entity.ImageUrl);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }

                aboutManager.Update(entity);
                return RedirectToAction("About");
            }
            return View(model);
        }
        public IActionResult AboutAdd()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AboutAdd(AboutModel model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var about = new About()
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    Description = model.Description,
                    ImageUrl = file.FileName,
                    IsActive = model.IsActive,
                    Address = model.Address,
                    Mail = model.Mail,
                };
                if (file != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\admin\\dist\\img\\AboutImg", about.ImageUrl);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                aboutManager.Add(about);
                return RedirectToAction("About");
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult AboutDelete(int AboutId)
        {
            if (AboutId == 0)
            {
                return NotFound();
            }
            var entity = aboutManager.GetById(AboutId);
            if (entity == null)
            {
                return NotFound();
            }
            aboutManager.Delete(entity);

            return RedirectToAction("About");
        }
    }
}