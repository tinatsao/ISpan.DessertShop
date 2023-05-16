using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.DessertShop.TinaWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonMaintainCategory_Click(object sender, EventArgs e)
        {
            FormCategoryEdit frm = new FormCategoryEdit();
            frm.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void buttonMaintainProduct_Click(object sender, EventArgs e)
        {
            FormProduct frm = new FormProduct();
            frm.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void buttonMaintainOrders_Click(object sender, EventArgs e)
        {
            FormOrder frm = new FormOrder();
            frm.TopLevel = false;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }
    }
}
