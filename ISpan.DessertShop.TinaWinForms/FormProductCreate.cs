using ISpan.DessertStore.SqlDataLayer;
using ISpan.DessertStore.SqlDataLayer.EF_model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ISpan.DessertShop.TinaWinForms
{
    public partial class FormProductCreate : Form
    {
		public FormProductCreate()
        {
            InitializeComponent();
			comboBoxCategoryId.DropDownStyle = ComboBoxStyle.DropDownList;
			this.Load += FormProductCreate_Load;
		}

		public int categoryId;
		Product product = new Product();
		System.Drawing.Image _img;
		public string fileName;

		private void FormProductCreate_Load(object sender, EventArgs e)
		{
			// 初始化下拉清單內容
			List<CategoryEntity> categories = GetCategories();
			// 在最前面加一個空白項
			categories.Insert(0, new CategoryEntity { Id = -1, Name = "select..." });

			comboBoxCategoryId.DataSource = categories;
			comboBoxCategoryId.ValueMember = "Id";
			comboBoxCategoryId.DisplayMember = "Name";

			var selectedMember = (comboBoxCategoryId.DataSource as List<CategoryEntity>)
					.FirstOrDefault(m => m.Id == 8);
			if (selectedMember != null) comboBoxCategoryId.SelectedItem = selectedMember;

			comboBoxCategoryId.SelectedIndex = 0;
		}

		private List<CategoryEntity> GetCategories()
		{
			var data = new CategoryRepository().GetAll()
				.Select(n => n);
			return data.ToList();

			//dataGridView1.DataSource = data.ToList();
		}
		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				new ProductRepository().Create(GetModel());
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗\r\n" + ex.Message);
			}

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


		private ProductIndexVm GetModel() => new ProductIndexVm
		{

			SellerID = this.SellerID,
			CategoryID = categoryId,
			ProductName = textBoxProductName.Text,
			ProductStatus = radioButtonUp.Checked,
			Picture1 = fileName,
			ProductFlavor = textBoxProductFlavor.Text,
			UnitPrice = this.UnitPrice,
			ProductSize = textBoxProductSize.Text,
			ProductUnit = textBoxProductUnit.Text,
			Description = textBoxDescription.Text,
			UnitsInStock = (int)UnitsInStock
		};


		private void comboBoxCategoryId_SelectedIndexChanged(object sender, EventArgs e)
		{
			categoryId = ((CategoryEntity)comboBoxCategoryId.SelectedItem).Id;
			//MessageBox.Show(categoryId.ToString());
		}

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

		private void buttonDemo_Click(object sender, EventArgs e)
		{
			textBoxProductName.Text = "可可雪球手工餅乾";
            textBoxProductFlavor.Text = "巧克力";
            textBoxProductSize.Text = "無";
            textBoxProductUnit.Text = "包";
            textBoxUnitsInStock.Text = "20";
			textBoxUnitPrice.Text = "100";
            textBoxDescription.Text = $@"雪白的糖粉下，包覆的是「核桃巧克力酥餅」以大量核桃碎粒，取代傳統酥餅的大量油脂，天然健康同時，達到酥鬆的口感，帶出堅果濃而不膩的香氣再加入大量比利時可可粉製成餅乾其實濃郁的核桃香氣才是讓你一口接一口的原因！苦甜的可可味，包覆上糖粉創造很美妙的對比每一次咀嚼都能享受到不同的甜度這種層次感，就是冬季滋味的表現！";

        }
	}
}
