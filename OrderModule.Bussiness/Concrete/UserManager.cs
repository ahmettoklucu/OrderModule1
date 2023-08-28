using OrderModule.Bussiness.Abstract;
using OrderModule.DataAccess.Abstract;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
            
        }
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public User Get(int UserId)
        {
            return _userDal.Get(p=>p.Id==UserId);
        }

        public List<User> GetAll()
        {
           return _userDal.GetAll();
        }

        public List<User> GetUserByUserName(string userName)
        {
            return _userDal.GetAll(p=>p.Email.ToLower().Contains(userName.ToLower()));
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
