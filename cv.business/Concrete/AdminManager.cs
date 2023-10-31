using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv.business.Abstract;
using cv.data.Abstract;
using cv.entity.Concrete;

namespace cv.business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public void Add(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void Delete(int AdminId)
        {
            throw new NotImplementedException();
        }

        public Admin GetByUserName(string UserName)
        {
            return _adminDal.GetByUserName(UserName);
        }

        public bool Login(Admin admin, string password, string username)
        {
            return _adminDal.Login(admin, password, username);
        }

        public void Update(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}