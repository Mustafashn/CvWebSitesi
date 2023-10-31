using System;
using System.Collections.Generic;

using cv.business.Abstract;
using cv.data.Abstract;
using cv.entity.Concrete;

namespace cv.business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void Add(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void Delete(Contact entity)
        {
            _contactDal.Delete(entity);

        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);

        }

        public List<Contact> ListAll()
        {
            return _contactDal.ListAll();

        }

        public void Update(Contact entity)
        {
            _contactDal.Update(entity);

        }
    }
}