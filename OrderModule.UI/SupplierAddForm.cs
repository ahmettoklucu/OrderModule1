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
    public partial class SupplierAddForm : Form
    {
        public SupplierAddForm()
        {
            InitializeComponent();
            _supplierService =new SupplierManager(new EfSupplierDal());
        }
        private ISupplierService _supplierService;
        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            SupplierListForm form = new SupplierListForm();
            form.Show();
        }

        private void ProductAdded_Click(object sender, EventArgs e)
        {
        }
    }
}
