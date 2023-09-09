using LoginScreen;
using OrderModule.Bussiness.Abstract;
using OrderModule.Bussiness.Concrete;
using OrderModule.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderModule.UI
{
    public partial class LoginForm : Form
    {
        private LoginScreen.TLoginType LoginType;
        public LoginForm()
        {
            InitializeComponent();
            _userService=new UserManager(new EfUserDal());
        }
        private IUserService _userService;
        private void screenLogin1_OnClickEnterButton(LoginScreen.TLoginType LoginType)
        {
            string HataMesaji;
            if (LoginType == TLoginType.KullaniciAdi)
            {

                var user= _userService.UserNameLogin(screenLogin1.KullaniciAdi, screenLogin1.Sifre,out HataMesaji);
                if (user != null)
                {
                    MessageBox.Show(HataMesaji);
                    MenuForm menuForm = new MenuForm(user.Id);
                    menuForm.Show();
                }
                else
                {
                    MessageBox.Show(HataMesaji);
                }
                
            }
            else if (LoginType == TLoginType.Mail)
            {
                var user = _userService.EmailLogin(screenLogin1.Email, screenLogin1.Sifre, out HataMesaji);
                if (user != null)
                {
                    MessageBox.Show(HataMesaji);
                    MenuForm menuForm = new MenuForm(user.Id);
                    menuForm.Show();
                }
                else
                {
                    MessageBox.Show(HataMesaji);
                }
            }
            else
            {
                var user = _userService.PhoneLogin(screenLogin1.Phone, screenLogin1.Sifre, out HataMesaji);
                if (user != null)
                {
                    MessageBox.Show(HataMesaji);
                    MenuForm menuForm = new MenuForm(user.Id);
                    menuForm.Show();
                }
                else
                {
                    MessageBox.Show(HataMesaji);
                }
            }

        }

        private void screenLogin1_OnChangeLoginType(LoginScreen.TLoginType LoginType)
        {
            this.LoginType = LoginType;
           
        }
    }
}
