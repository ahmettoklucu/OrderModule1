using OrderModule.Bussiness.Abstract;
using OrderModule.Bussiness.Concrete;
using OrderModule.DataAccess.Concrete;
using OrderModule.Entities.Concrete;
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
    public partial class UserAddForm : Form
    {
        private int _userId;
        public UserAddForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _userService = new UserManager(new EfUserDal());
        }
        private IUserService _userService;

        private void ProductAdded_Click(object sender, EventArgs e)
        {
            try
            {
                string mesaj;
                if (tbxPassword.Text != tbxPasswordRepeat.Text)
                {
                    MessageBox.Show("Paralolar bir biri ile uyuşmamaktadir.");
                }
                else
                {
                    _userService.Add(new User
                    {
                        Password=tbxPassword.Text,
                        UserName=tbxUserName.Text,
                        Email=tbxEmail.Text,
                        Phone=tbxPhone.Text,
                    },out mesaj);
                    MessageBox.Show(mesaj);
                }
            }
            catch (Exception ex)
            {
            
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            UserListForm userListForm = new UserListForm(_userId);
            userListForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(_userId);
            menuForm.Show();
        }

        private void UserAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
