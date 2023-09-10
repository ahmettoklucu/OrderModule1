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
        List<User> GetUserByPhone(string Phone);
        List<User> GetUserByEMail(string EMail);
        User Get(int UserId);
        void Add(User user,out string Mesaj);
        void Update(User user, out string Mesaj);
        void Delete(User user);
        User EmailLogin(string Email,string password, out string Messege);
        User PhoneLogin(string Phone,string password, out string Messege);
        User UserNameLogin(string UserName, string password, out string Messege);
    }
}
