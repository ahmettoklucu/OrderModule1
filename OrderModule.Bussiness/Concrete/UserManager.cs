using OrderModule.Bussiness.Abstract;
using OrderModule.Bussiness.Utilities;
using OrderModule.Bussiness.ValidationRules.FluentValidation;
using OrderModule.DataAccess.Abstract;
using OrderModule.DataAccess.Concrete;
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
        public void Add(User user,out string mesaj)
        {
            mesaj="";
            var UserName = _userDal.Get(p => p.UserName == user.UserName);
            if (UserName != null)
            {
                mesaj = "Kullanıcı adi sistemde kayıtlıdır.";
            }
            else if(_userDal.Get(p => p.Phone == user.Phone) != null)
            {
                mesaj = "Telefon numarası sistemde kayıtlıdır.";
            }else if(_userDal.Get(p => p.Email == user.Email) != null)
            {
                mesaj = "EMail sistemde kayıtlıdır.";
            }
            else
            {
                
                ValidationTool.Validate(new UserValidator(), user);
                user.Password = ComputeSHA256Hash(user.Password);
                _userDal.Add(user);
                mesaj = "Kullanıcı ekleme işlemi başarili";
            }
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
            return _userDal.GetAll(p=>p.UserName.ToLower().Contains(userName.ToLower()));
        }

        public void Update(User user,out string mesaj)
        {
            mesaj = "";
            if (_userDal.Get(p => p.UserName == user.UserName && p.Id != user.Id) != null)
            {
                mesaj = "Kullanıcı adi sistemde kayıtlıdır.";
            }
            else if (_userDal.Get(p => p.Phone == user.Phone && p.Id != user.Id) != null)
            {
                mesaj = "Telefon numarası sistemde kayıtlıdır.";
            }
            else if (_userDal.Get(p => p.Email == user.Email && p.Id != user.Id) != null)
            {
                mesaj = "EMail sistemde kayıtlıdır.";
            }
            else
            {
                mesaj = "Kullanıcı ekleme işlemi başarili";
                ValidationTool.Validate(new UserValidator(), user);
                user.Password = ComputeSHA256Hash(user.Password);
                _userDal.Update(user);
            }
        }

        public User EmailLogin(string Email, string password,out string Messege)
        {
            Messege = "";
            var User=_userDal.Get(p=>p.Email==Email);
            if (User!=null)
            {
                if (VerifySHA256Hash(password, User.Password)==false)
                {
                    Messege = "Şifre hatalı tekrar deneyiniz.";
                    User=null;
                }
                else
                {
                    Messege = "Giriş başarili.";
                    
                }

            }
            else 
            {
                Messege = "Bu Email Adresi sistemde bulunmamaktadir.";
            }
            return User;
        }

        public User PhoneLogin(string Phone, string password, out string Messege)
        {
            Messege = "";
            var User = _userDal.Get(p => p.Phone == Phone);
            if (User != null)
            {
                if (VerifySHA256Hash(password, User.Password) == false)
                {
                    Messege = "Şifre hatalı tekrar deneyiniz.";
                    User=null;
                }
                else
                {
                    Messege = "Giriş başarili.";
                }

            }
            else
            {
                Messege = "Bu telefon sistemde bulunmamaktadir.";
            }
            return User;
        }

        public User UserNameLogin(string UserName, string password, out string Messege)
        {
            Messege = "";
            var User = _userDal.Get(p => p.UserName == UserName);
            if (User != null)
            {
                if (VerifySHA256Hash(password, User.Password) == false)
                {
                    Messege = "Şifre hatalı tekrar deneyiniz.";
                    User = null;
                }
                else
                {
                    Messege = "Giriş başarili.";
                }

            }
            else
            {
                Messege = "Bu Kullanıcı ismi sistemde bulunmamaktadir.";
            }
            return User;
        }

        public List<User> GetUserByPhone(string Phone)
        {
            return _userDal.GetAll(p => p.Phone.ToLower().Contains(Phone.ToLower()));
        }

        public List<User> GetUserByEMail(string EMail)
        {
            return _userDal.GetAll(p => p.Email.ToLower().Contains(EMail.ToLower()));
        }
    }
}
