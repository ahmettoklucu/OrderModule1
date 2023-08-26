using OrderModule.Bussiness.Abstract;
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
    public partial class SupplierUpdateForm : Form
    {
        private int _supplierıd;
        private ISupplierService _supplierService;
        public SupplierUpdateForm(int suppplierId)
        {
            InitializeComponent();
            _supplierıd = suppplierId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        public void LoadSuplier()
        {
            var UpdateSupplier = _supplierService.Get(_supplierıd);
            

        }
        private void ProductAdded_Click(object sender, EventArgs e)
        {

        }
    }
}
