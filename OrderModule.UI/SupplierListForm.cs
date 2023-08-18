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
        public SupplierListForm()
        {
            InitializeComponent();
        }

        private void ProductUpdate_Click(object sender, EventArgs e)
        {
            SupplierUpdateForm form = new SupplierUpdateForm();
            form.Show();
        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            SupplierAddForm form = new SupplierAddForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
        }
    }
}
