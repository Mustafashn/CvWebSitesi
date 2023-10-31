using System;
using System.Collections.Generic;
using cv.business.Abstract;
using cv.data.Abstract;
using cv.entity.Concrete;

namespace cv.business.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;
        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }
        public void Add(Skill entity)
        {
            _skillDal.Add(entity);
        }

        public void Delete(Skill entity)
        {
            _skillDal.Delete(entity);

        }

        public Skill GetById(int id)
        {
            return _skillDal.GetById(id);

        }

        public List<Skill> ListAll()
        {
            return _skillDal.ListAll();
        }

        public void Update(Skill entity)
        {
            _skillDal.Update(entity);
        }
    }
}