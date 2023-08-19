﻿using System;
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
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            OrderAddForm orderAddForm = new OrderAddForm();
            orderAddForm.Show();
        }
    }
}
