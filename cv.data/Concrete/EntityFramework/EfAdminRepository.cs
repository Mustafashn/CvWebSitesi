using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using cv.data.Abstract;
using cv.entity.Concrete;

namespace cv.data.Concrete.EntityFramework
{
    public class EfAdminRepository : IAdminDal
    {
        public void Add(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void Delete(int AdminId)
        {
            throw new NotImplementedException();
        }

        public Admin GetByUserName(string Username)
        {
            using (var context = new CvContext())
            {
                return context.Admins.Where(i => i.UserName == Username).FirstOrDefault();
            }
        }

        public bool Login(Admin admin, string password, string username)
        {
            using (var context = new CvContext())
            {
                var user = context.Admins.Where(i => i.AdminId == admin.AdminId).FirstOrDefault();
                if (user.Password == password && user.UserName == username)
                {
                    return true;
                }
                return false;
            }
        }

        public void Update(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}