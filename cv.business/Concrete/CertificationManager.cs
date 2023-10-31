using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv.business.Abstract;
using cv.data.Abstract;
using cv.entity.Concrete;

namespace cv.business.Concrete
{
    public class CertificationManager : ICertificationService
    {
        ICertificationDal _certificationDal;
        public CertificationManager(ICertificationDal certificationDal)
        {
            _certificationDal = certificationDal;
        }
        public void Add(Certification entity)
        {
            _certificationDal.Add(entity);
        }

        public void Delete(Certification entity)
        {
            _certificationDal.Delete(entity);

        }

        public Certification GetById(int id)
        {
            return _certificationDal.GetById(id);

        }

        public List<Certification> ListAll()
        {
            return _certificationDal.ListAll();
        }

        public void Update(Certification entity)
        {
            _certificationDal.Update(entity);
        }
    }
}