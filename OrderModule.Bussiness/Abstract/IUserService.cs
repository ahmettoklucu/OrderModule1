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
        void Add(User user,int userId,out string messege);
        void Update(User user, int userId, out string messege);
        void Delete(User user, int userId, out string messege);
        bool EmailLogin(string Email,string password, out string Messege);
        bool PhoneLogin(string Phone,string password, out string Messege);
        bool UserNameLogin(string UserName, string password, out string Messege);
    }
}
