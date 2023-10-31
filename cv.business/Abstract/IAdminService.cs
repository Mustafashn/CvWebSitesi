using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cv.entity.Concrete;

namespace cv.business.Abstract
{
    public interface IAdminService
    {
        void Add(Admin admin);
        void Delete(int AdminId);
        void Update(Admin admin);
        Admin GetByUserName(string Username);
        bool Login(Admin admin, string password, string username);

    }
}