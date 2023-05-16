using ISpan.DessertStore.SqlDataLayer.EF_model;
using ISpan.DessertStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Data.SqlClient;

namespace ISpan.DessertShop.TinaWinForms
{
	public partial class FormProductEdit : Form
	{
		Product product = new Product();
		System.Drawing.Image _img;
		public string fileName;
		private readonly int productID;
		private readonly string picture1;
		private readonly string categoryNameSelect;

		public int categoryId => ((CategoryEntity)comboBoxCategoryId.SelectedItem).Id;

		string a = string.Empty;

		public FormProductEdit(int productID,string picture1,string categoryNameSelect)
		{
			InitializeComponent();
			this.productID = productID;
			this.picture1 = picture1;
			if(picture1!=null) this.pictureBox1.Image=Image.FromFile(Application.StartupPath + "\\picture\\"+picture1);

			this.categoryNameSelect = categoryNameSelect;



			this.Load += FormProductEdit_Load;
		}

		private void FormProductEdit_Load(object sender, EventArgs e)
		{
			// 初始化下拉清單內容
			List<CategoryEntity> categories = GetCategories();
			// 在最前面加一個空白項
			categories.Insert(0, new CategoryEntity { Id = -1, Name = "select..." });

			comboBoxCategoryId.DataSource = categories;
			comboBoxCategoryId.ValueMember = "Id";
			comboBoxCategoryId.DisplayMember = "Name";
			//comboBoxCategoryId.SelectedIndex = 0;

			var selectedCategoryId = (comboBoxCategoryId.DataSource as List<CategoryEntity>)
				.FirstOrDefault(m => m.Name == categoryNameSelect);
			if (selectedCategoryId != null) comboBoxCategoryId.SelectedItem = selectedCategoryId;

			var product = new ProductRepository().GetProduct(productID);
			BindForm(product);

			fileName = picture1;
		}

		private List<CategoryEntity> GetCategories()
		{
			var data = new CategoryRepository().GetAll()
				.Select(n => n);
			return data.ToList();

			//dataGridView1.DataSource = data.ToList();
		}

		private void BindForm(ProductUpdateEntity product)
		{
			textBoxSellerID.Text = product.SellerID.ToString();
			textBoxProductName.Text = product.ProductName;
			radioButtonUp.Checked = product.ProductStatus;
			textBoxProductFlavor.Text = product.ProductFlavor;
			textBoxProductSize.Text = product.ProductSize;
			textBoxProductUnit.Text = product.ProductUnit;
			textBoxDescription.Text = product.Description;
			textBoxUnitPrice.Text = product.UnitPrice.ToString();
			textBoxUnitsInStock.Text = product.UnitsInStock.ToString();

		}
		private void comboBoxCategoryId_SelectedIndexChanged(object sender, EventArgs e)
		{
			//categoryId = ((CategoryEntity)comboBoxCategoryId.SelectedItem).Id;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var model = GetModel();
			new ProductRepository().Update(model);
			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

		private ProductUpdateEntity GetModel() => new ProductUpdateEntity
		{
			Id = this.productID,
			SellerID = this.SellerID,
			CategoryID = this.categoryId,
			ProductName = textBoxProductName.Text,
			ProductStatus = radioButtonUp.Checked,
			Picture1 = fileName,
			ProductFlavor = textBoxProductFlavor.Text,
			UnitPrice = this.UnitPrice,
			ProductSize = textBoxProductSize.Text,
			ProductUnit = textBoxProductUnit.Text,
			Description = textBoxDescription.Text,
			UnitsInStock = Convert.ToInt32(textBoxUnitsInStock.Text),
			//textBoxUnitPrice.Text = product.UnitPrice.ToString();
		};


		private void buttonDelete_Click(object sender, EventArgs e)
		{
			try
			{
				new ProductRepository().Delete(this.productID);
			}
			catch (SqlException ex)
			{
				if (ex.Message.Contains("FK_OrderDetails_Products"))
				{
					MessageBox.Show("您刪除的產品已被訂購，不可刪除","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
				}
			}
			//new ProductRepository().Delete(this.productID);
			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

		private int SellerID
	=> int.TryParse(textBoxSellerID.Text, out int sellerID)
			? sellerID
			: 0;
		private int? CategoryID
			=> int.TryParse(comboBoxCategoryId.Text, out int categoryID)
				? categoryID
				: (int?)null;
		private int? UnitsInStock
			=> int.TryParse(textBoxUnitsInStock.Text, out int unitsInStock)
				? unitsInStock
				: (int?)null;
		private decimal UnitPrice
			=> decimal.TryParse(textBoxUnitPrice.Text, out decimal unitPrice)
				? unitPrice
				: 0;

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();//匯入圖片

			openFileDialog.Filter = "All Files|*.*";

			openFileDialog.ShowDialog();

			if (openFileDialog.FileName != string.Empty) _img = new Bitmap(openFileDialog.FileName);
			fileName = openFileDialog.FileName;
			fileName = Path.GetFileName(fileName);

			this.pictureBox1.Image = _img;
		}
	}
}
