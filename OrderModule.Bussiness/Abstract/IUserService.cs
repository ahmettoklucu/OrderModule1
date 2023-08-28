using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        List<User> GetUserByUserName(string userName);
        User Get(int UserId);
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        bool EmailLogin(string Email,string password, out string Messege);
        bool PhoneLogin(string Phone,string password, out string Messege);
        bool UserNameLogin(string UserName, string password, out string Messege);
    }
}
