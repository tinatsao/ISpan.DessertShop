using ISpan.DessertStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ISpan.DessertShop.TinaWinForms
{
	public partial class FormProduct : Form, IGridContainer
	{

		private ProductRepository repo;
		private List<ProductIndexVm> _productsIndexVm;
		private List<ProductUpdateEntity> _productsUpdate;

		public string ComboxText = string.Empty;
		public string SName => textBoxProductName.Text;
		public string SCategoryName => ComboxText;

		public FormProduct()
		{
			InitializeComponent();
			repo = new ProductRepository();
		}

		private void FormProduct_Load(object sender, EventArgs e)
		{
			Display();
			ComboBox1();
		}


		private IEnumerable<CategoryEntity> GetProductCategory()
		{
			//回傳自訂物件
			var data = new CategoryRepository().GetAll().Select(n => n); 
			return data;
		}
		public void Display()
		{
			_productsIndexVm = repo.Search(SName, SCategoryName).ToList();
			dataGridView1.DataSource = _productsIndexVm;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}
		
		private void comboBoxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboxText = comboBoxCategoryName.Text;

		}
		public void ComboBox1()
		{
			comboBoxCategoryName.Items.Add("");
			var data = new List<CategoryEntity>();
			foreach (var item in new CategoryRepository().GetAll())
			{
				data.Add(item);
				comboBoxCategoryName.Items.Add(item.Name);
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var frm = new FormProductCreate();
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int productId = _productsIndexVm[e.RowIndex].Id;
			string picture1 = _productsIndexVm[e.RowIndex].Picture1;
			string categoryName = _productsIndexVm[e.RowIndex].CategoryName;
			var frm = new FormProductEdit(productId, picture1, categoryName);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
