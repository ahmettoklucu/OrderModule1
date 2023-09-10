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
    public partial class UserListForm : Form
    {
        private int _userId1;
        private int _UserId;
        public UserListForm(int userId)
        {
            InitializeComponent();
            _UserId = userId;
            _userService=new UserManager(new EfUserDal());
        }
        private IUserService _userService;
        private void UserListForm_Load(object sender, EventArgs e)
        {
            LoadUser();
        }
        public void LoadUser()
        {
            dgwProduct.DataSource = _userService.GetAll();
        }
        private void ProductAdd_Click(object sender, EventArgs e)
        {
           UserAddForm userAddForm = new UserAddForm(_UserId);
           userAddForm.Show();
        }
        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _userId1 = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value.ToString());
        }
        private void ProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_userId1 != 0)
                {
                    UserUpdateForm userUpdateForm = new UserUpdateForm(_UserId, _userId1);
                    userUpdateForm.Show();
                }
                else
                {
                    MessageBox.Show("Güncellemek için bir veri seçiniz!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(_UserId);
            menuForm.Show();
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbxProductName.Text))
                {
                    dgwProduct.DataSource = _userService.GetUserByUserName(tbxProductName.Text);
                }
                else
                {
                    LoadUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbxProductName.Text))
                {
                    dgwProduct.DataSource = _userService.GetUserByEMail(textBox2.Text);
                }
                else
                {
                    LoadUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbxProductName.Text))
                {
                    dgwProduct.DataSource = _userService.GetUserByPhone(textBox1.Text);
                }
                else
                {
                    LoadUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_userId1 != 0)
            {
                var DeleteUser = _userService.Get(_userId1);
                _userService.Delete(DeleteUser);
                LoadUser();
            }
            else
            {
                MessageBox.Show("Silmek için bir veri seçiniz!!");
            }
        }
    }
}
