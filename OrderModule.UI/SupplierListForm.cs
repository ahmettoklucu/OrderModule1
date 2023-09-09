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
    public partial class SupplierListForm : Form
    {
        public SupplierListForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _supplierService=new SupplierManager(new EfSupplierDal());
        }
        private ISupplierService _supplierService;
        private int SuppplierId;
        private int _userId;
        public void LoadSupplier()
        {
            dgwProduct.DataSource = _supplierService.GetAll();
        }
        private void ProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (SuppplierId != 0)
                {
                    SupplierUpdateForm form = new SupplierUpdateForm(_userId, SuppplierId);
                    form.Show();

                }
                else
                {
                    MessageBox.Show("Güncellemek için bir veri seçiniz!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
          
        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            SupplierAddForm form = new SupplierAddForm(_userId);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm(_userId);
            menu.Show();
        }

        private void SupplierListForm_Load(object sender, EventArgs e)
        {
            LoadSupplier();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (SuppplierId != 0)
                {
                    var DeleteSupplier = _supplierService.Get(SuppplierId);
                    _supplierService.Delete(DeleteSupplier);
                    LoadSupplier();
                }
                else
                {
                    MessageBox.Show("Silmek için bir veri seçiniz!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
