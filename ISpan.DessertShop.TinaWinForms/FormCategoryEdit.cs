using ISpan.DessertStore.SqlDataLayer;
using ISpan.DessertStore.SqlDataLayer.EF_model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ISpan.DessertShop.TinaWinForms.FormCategoryEdit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ISpan.DessertShop.TinaWinForms
{
	public interface IGridContainer
	{
		void Display();
	}

	public partial class FormCategoryEdit : Form, IGridContainer
	{
		private int categoryId;
		private CategoryRepository repo;
		private List<CategoryEntity> _categories;
		public string SName => textBoxSName.Text;
		public string SDisplayOrder => textBoxSDisplayOrder.Text;

		public FormCategoryEdit()
		{
			InitializeComponent();
			repo = new CategoryRepository();
			
			Load += FormCategoryEdit_Load;
		}

		private CategoryEntity GetModel()
		 => new CategoryEntity
		 {
			 Name = textBoxName.Text,
			 DisplayOrder = Convert.ToInt32(textBoxDisplayOrder.Text),
		 };
		private void FormCategoryEdit_Load(object sender, EventArgs e)
		{
			Display();
			CategoryEntity category = new CategoryRepository().GetCategory(categoryId);
			if (category == null)
			{
				//MessageBox.Show("record not found.");
				//this.DialogResult = DialogResult.Cancel;
				//return;
			}
			else
			{
				textBoxSName.Text = category.Name;
				textBoxSDisplayOrder.Text = category.DisplayOrder.ToString();
			}
		}

		public void Display()
		{
			_categories = repo.Search(SName, SDisplayOrder).ToList();
			dataGridView1.DataSource = _categories;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			categoryId = _categories[e.RowIndex].Id;

			CategoryEntity category = new CategoryRepository().GetCategory(categoryId);

			if (category == null)
			{
				MessageBox.Show("record not found.");
				this.DialogResult = DialogResult.Cancel;
				return;
			}
			else
			{
				textBoxName.Text = category.Name;
				textBoxDisplayOrder.Text = category.DisplayOrder.ToString();
			}

		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var category = new CategoryEntity
			{
				Id = categoryId,
				Name = textBoxName.Text,
				DisplayOrder = Convert.ToInt32(textBoxDisplayOrder.Text),

			//ModifiedTime = DateTime.Now
			};

			int rowsAffected = new CategoryRepository().Update(category);

			// 如果傳回筆數是1,表示有正確更新一筆
			if (rowsAffected > 0)
			{
				MessageBox.Show("記錄已更新");
			}
			else
			{
				MessageBox.Show("記錄沒有被異動,可能記錄已經被刪除");
			}
			//textBoxSName.Text = string.Empty;
			//textBoxSDisplayOrder.Text=string.Empty;
			Display();
			//FormCategoryEdit_Load(this, EventArgs.Empty);
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			try
			{
				new CategoryRepository().Create(GetModel());
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗\r\n" + ex.Message);
			}

			IGridContainer container = this.Owner as IGridContainer;

			if (container != null) container.Display();
			textBoxSName.Text = string.Empty;
			textBoxSDisplayOrder.Text = string.Empty;
			Display();
			//this.DialogResult = DialogResult.OK;
		}


		private void buttonDelete_Click(object sender, EventArgs e)
		{
			new CategoryRepository().Delete(this.categoryId);
			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();
			textBoxSName.Text = string.Empty;
			textBoxSDisplayOrder.Text = string.Empty;
			Display();
		}
	}
}
