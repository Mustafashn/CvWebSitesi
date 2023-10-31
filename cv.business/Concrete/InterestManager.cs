using System;
using System.Collections.Generic;
using cv.business.Abstract;
using cv.data.Abstract;
using cv.entity.Concrete;

namespace cv.business.Concrete
{
    public class InterestManager : IInterestService
    {
        IInterestDal _interestDal;
        public InterestManager(IInterestDal interestDal)
        {
            _interestDal = interestDal;
        }
        public void Add(Interest entity)
        {
            _interestDal.Add(entity);
        }

        public void Delete(Interest entity)
        {
            _interestDal.Delete(entity);
        }

        public Interest GetById(int id)
        {
            return _interestDal.GetById(id);
        }

        public List<Interest> ListAll()
        {
            return _interestDal.ListAll();
        }

        public void Update(Interest entity)
        {
            _interestDal.Update(entity);
        }
    }
}