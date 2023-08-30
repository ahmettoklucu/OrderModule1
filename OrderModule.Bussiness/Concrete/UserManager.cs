using OrderModule.Bussiness.Abstract;
using OrderModule.Bussiness.Utilities;
using OrderModule.Bussiness.ValidationRules.FluentValidation;
using OrderModule.DataAccess.Abstract;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public string ComputeSHA256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public bool VerifySHA256Hash(string rawData, string hash)
        {
            string hashOfInput = ComputeSHA256Hash(rawData);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (comparer.Compare(hashOfInput, hash) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
            
        }
        public void Add(User user, int userId,out string messege)
        {
            messege = "";
            var User = _userDal.Get(p=>p.Id==userId);
            if (User.RoleId == 1)
            {
                user.Password = ComputeSHA256Hash(user.Password);
                _userDal.Add(user);
                messege = "Yeni Kullanıcı eklendi.";
            }
            else
            {
                messege = "Kullanıcı eklemek için yetkiniz bulunmamaktadir.";
            }
        }

        public void Delete(User user, int userId, out string messege)
        {
            messege = "";
            var User = _userDal.Get(p => p.Id == userId);
            if (User.RoleId == 1)
            {
                _userDal.Delete(user);
                messege = "Yeni Kullanıcı silindi.";
            }
            else
            {
                messege = "Kullanıcı silmek için yetkiniz bulunmamaktadir.";
            }
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

        public void Update(User user, int userId,out string messege)
        {
            messege = "";
            var User = _userDal.Get(p => p.Id == userId);
            if (User.RoleId == 1)
            {
                //ValidationTool.Validate(new SupplierValidator(), supplier);
                _userDal.Update(user);
                messege = "Yeni Kullanıcı güncellendi";
            }
            else
            {
                messege = "Kullanıcı güncellemek için yetkiniz bulunmamaktadir.";
            }
        }

        public bool EmailLogin(string Email, string password,out string Messege)
        {
            bool result = false;
            Messege = "";
            var User=_userDal.Get(p=>p.Email==Email);
            if (User!=null)
            {
                if (VerifySHA256Hash(password, User.Password)==false)
                {
                    Messege = "Şifre hatalı tekrar deneyiniz.";
                    result = false;
                }
                else
                {
                    result = true;
                    Messege = "Giriş başarili.";
                }

            }
            else 
            {
                Messege = "Bu Email Adresi sistemde bulunmamaktadir.";
                result = false; 
            }
            return result;
        }

        public bool PhoneLogin(string Phone, string password, out string Messege)
        {
            bool result = false;
            Messege = "";
            var User = _userDal.Get(p => p.Phone == Phone);
            if (User != null)
            {
                if (VerifySHA256Hash(password, User.Password) == false)
                {
                    Messege = "Şifre hatalı tekrar deneyiniz.";
                    result = false;
                }
                else
                {
                    result = true;
                    Messege = "Giriş başarili.";
                }

            }
            else
            {
                Messege = "Bu telefon sistemde bulunmamaktadir.";
                result = false;
            }
            return result;
        }

        public bool UserNameLogin(string UserName, string password, out string Messege)
        {
            bool result = false;
            Messege = "";
            var User = _userDal.Get(p => p.UserName == UserName);
            if (User != null)
            {
                if (VerifySHA256Hash(password, User.Password) == false)
                {
                    Messege = "Şifre hatalı tekrar deneyiniz.";
                    result = false;
                }
                else
                {
                    result = true;
                    Messege = "Giriş başarili.";
                }

            }
            else
            {
                Messege = "Bu Kullanıcı ismi sistemde bulunmamaktadir.";
                result = false;
            }
            return result;
        }
    }
}
