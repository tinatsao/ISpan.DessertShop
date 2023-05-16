namespace ISpan.DessertShop.TinaWinForms
{
	partial class FormProduct
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxProductName = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.comboBoxCategoryName = new System.Windows.Forms.ComboBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.categoryEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productEntityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.formCategoryEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.categoryEntityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.productEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.categoryEntityBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Picture1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitsInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sellerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.productUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.picture1DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.productFlavorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitsInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitsOnOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uploadDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastModifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryEntityBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productEntityBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.formCategoryEditBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryEntityBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productEntityBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryEntityBindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ProductName,
            this.CategoryName,
            this.Picture1,
            this.UnitPrice,
            this.ProductUnit,
            this.UnitsInStock,
            this.ProductStatus,
            this.Description,
            this.categoryIDDataGridViewTextBoxColumn,
            this.sellerIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.productStatusDataGridViewCheckBoxColumn,
            this.productUnitDataGridViewTextBoxColumn,
            this.picture1DataGridViewImageColumn,
            this.productFlavorDataGridViewTextBoxColumn,
            this.productSizeDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.unitsInStockDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitsOnOrderDataGridViewTextBoxColumn,
            this.uploadDateDataGridViewTextBoxColumn,
            this.lastModifiedDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.productEntityBindingSource1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Location = new System.Drawing.Point(21, 56);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(985, 504);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(348, 25);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "商品類別:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "商品名稱:";
			// 
			// textBoxProductName
			// 
			this.textBoxProductName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBoxProductName.Location = new System.Drawing.Point(102, 21);
			this.textBoxProductName.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxProductName.Name = "textBoxProductName";
			this.textBoxProductName.Size = new System.Drawing.Size(181, 29);
			this.textBoxProductName.TabIndex = 5;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonSearch.Location = new System.Drawing.Point(916, 20);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(90, 30);
			this.buttonSearch.TabIndex = 11;
			this.buttonSearch.Text = "搜尋";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// comboBoxCategoryName
			// 
			this.comboBoxCategoryName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryEntityBindingSource, "Name", true));
			this.comboBoxCategoryName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBoxCategoryName.FormattingEnabled = true;
			this.comboBoxCategoryName.Location = new System.Drawing.Point(429, 22);
			this.comboBoxCategoryName.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxCategoryName.Name = "comboBoxCategoryName";
			this.comboBoxCategoryName.Size = new System.Drawing.Size(181, 28);
			this.comboBoxCategoryName.TabIndex = 12;
			this.comboBoxCategoryName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoryName_SelectedIndexChanged);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAdd.Location = new System.Drawing.Point(916, 579);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(90, 30);
			this.buttonAdd.TabIndex = 13;
			this.buttonAdd.Text = "新增...";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// categoryEntityBindingSource
			// 
			this.categoryEntityBindingSource.DataSource = typeof(ISpan.DessertStore.SqlDataLayer.CategoryEntity);
			// 
			// productEntityBindingSource1
			// 
			this.productEntityBindingSource1.DataSource = typeof(ISpan.DessertStore.SqlDataLayer.ProductIndexVm);
			// 
			// formCategoryEditBindingSource
			// 
			this.formCategoryEditBindingSource.DataSource = typeof(ISpan.DessertShop.TinaWinForms.FormCategoryEdit);
			// 
			// categoryEntityBindingSource1
			// 
			this.categoryEntityBindingSource1.DataSource = typeof(ISpan.DessertStore.SqlDataLayer.CategoryEntity);
			// 
			// productEntityBindingSource
			// 
			this.productEntityBindingSource.DataSource = typeof(ISpan.DessertStore.SqlDataLayer.ProductIndexVm);
			// 
			// categoryEntityBindingSource2
			// 
			this.categoryEntityBindingSource2.DataSource = typeof(ISpan.DessertStore.SqlDataLayer.CategoryEntity);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Visible = false;
			this.idDataGridViewTextBoxColumn.Width = 45;
			// 
			// ProductName
			// 
			this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.ProductName.DataPropertyName = "ProductName";
			this.ProductName.HeaderText = "商品名稱";
			this.ProductName.Name = "ProductName";
			this.ProductName.Width = 85;
			// 
			// CategoryName
			// 
			this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.CategoryName.DataPropertyName = "CategoryName";
			this.CategoryName.HeaderText = "類別名稱";
			this.CategoryName.Name = "CategoryName";
			this.CategoryName.Width = 85;
			// 
			// Picture1
			// 
			this.Picture1.DataPropertyName = "Picture1";
			this.Picture1.HeaderText = "圖片1";
			this.Picture1.Name = "Picture1";
			// 
			// UnitPrice
			// 
			this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.UnitPrice.DataPropertyName = "UnitPrice";
			this.UnitPrice.HeaderText = "商品單價";
			this.UnitPrice.Name = "UnitPrice";
			this.UnitPrice.Width = 85;
			// 
			// ProductUnit
			// 
			this.ProductUnit.DataPropertyName = "ProductUnit";
			this.ProductUnit.HeaderText = "商品單位";
			this.ProductUnit.Name = "ProductUnit";
			// 
			// UnitsInStock
			// 
			this.UnitsInStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.UnitsInStock.DataPropertyName = "UnitsInStock";
			this.UnitsInStock.HeaderText = "商品庫存";
			this.UnitsInStock.Name = "UnitsInStock";
			this.UnitsInStock.Width = 85;
			// 
			// ProductStatus
			// 
			this.ProductStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.ProductStatus.DataPropertyName = "ProductStatus";
			this.ProductStatus.HeaderText = "上架狀態";
			this.ProductStatus.Name = "ProductStatus";
			this.ProductStatus.Width = 85;
			// 
			// Description
			// 
			this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Description.DataPropertyName = "Description";
			this.Description.HeaderText = "描述";
			this.Description.Name = "Description";
			// 
			// categoryIDDataGridViewTextBoxColumn
			// 
			this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
			this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
			this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
			this.categoryIDDataGridViewTextBoxColumn.Visible = false;
			// 
			// sellerIDDataGridViewTextBoxColumn
			// 
			this.sellerIDDataGridViewTextBoxColumn.DataPropertyName = "SellerID";
			this.sellerIDDataGridViewTextBoxColumn.HeaderText = "SellerID";
			this.sellerIDDataGridViewTextBoxColumn.Name = "sellerIDDataGridViewTextBoxColumn";
			this.sellerIDDataGridViewTextBoxColumn.Visible = false;
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
			this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			this.productNameDataGridViewTextBoxColumn.Visible = false;
			// 
			// categoryNameDataGridViewTextBoxColumn
			// 
			this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
			this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
			this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
			this.categoryNameDataGridViewTextBoxColumn.Visible = false;
			// 
			// productStatusDataGridViewCheckBoxColumn
			// 
			this.productStatusDataGridViewCheckBoxColumn.DataPropertyName = "ProductStatus";
			this.productStatusDataGridViewCheckBoxColumn.HeaderText = "ProductStatus";
			this.productStatusDataGridViewCheckBoxColumn.Name = "productStatusDataGridViewCheckBoxColumn";
			this.productStatusDataGridViewCheckBoxColumn.Visible = false;
			// 
			// productUnitDataGridViewTextBoxColumn
			// 
			this.productUnitDataGridViewTextBoxColumn.DataPropertyName = "ProductUnit";
			this.productUnitDataGridViewTextBoxColumn.HeaderText = "ProductUnit";
			this.productUnitDataGridViewTextBoxColumn.Name = "productUnitDataGridViewTextBoxColumn";
			this.productUnitDataGridViewTextBoxColumn.Visible = false;
			// 
			// picture1DataGridViewImageColumn
			// 
			this.picture1DataGridViewImageColumn.DataPropertyName = "Picture1";
			this.picture1DataGridViewImageColumn.HeaderText = "Picture1";
			this.picture1DataGridViewImageColumn.Name = "picture1DataGridViewImageColumn";
			this.picture1DataGridViewImageColumn.Visible = false;
			// 
			// productFlavorDataGridViewTextBoxColumn
			// 
			this.productFlavorDataGridViewTextBoxColumn.DataPropertyName = "ProductFlavor";
			this.productFlavorDataGridViewTextBoxColumn.HeaderText = "ProductFlavor";
			this.productFlavorDataGridViewTextBoxColumn.Name = "productFlavorDataGridViewTextBoxColumn";
			this.productFlavorDataGridViewTextBoxColumn.Visible = false;
			// 
			// productSizeDataGridViewTextBoxColumn
			// 
			this.productSizeDataGridViewTextBoxColumn.DataPropertyName = "ProductSize";
			this.productSizeDataGridViewTextBoxColumn.HeaderText = "ProductSize";
			this.productSizeDataGridViewTextBoxColumn.Name = "productSizeDataGridViewTextBoxColumn";
			this.productSizeDataGridViewTextBoxColumn.Visible = false;
			// 
			// unitPriceDataGridViewTextBoxColumn
			// 
			this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
			this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
			this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
			this.unitPriceDataGridViewTextBoxColumn.Visible = false;
			// 
			// unitsInStockDataGridViewTextBoxColumn
			// 
			this.unitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock";
			this.unitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock";
			this.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn";
			this.unitsInStockDataGridViewTextBoxColumn.Visible = false;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.Visible = false;
			// 
			// unitsOnOrderDataGridViewTextBoxColumn
			// 
			this.unitsOnOrderDataGridViewTextBoxColumn.DataPropertyName = "UnitsOnOrder";
			this.unitsOnOrderDataGridViewTextBoxColumn.HeaderText = "UnitsOnOrder";
			this.unitsOnOrderDataGridViewTextBoxColumn.Name = "unitsOnOrderDataGridViewTextBoxColumn";
			this.unitsOnOrderDataGridViewTextBoxColumn.Visible = false;
			// 
			// uploadDateDataGridViewTextBoxColumn
			// 
			this.uploadDateDataGridViewTextBoxColumn.DataPropertyName = "UploadDate";
			this.uploadDateDataGridViewTextBoxColumn.HeaderText = "UploadDate";
			this.uploadDateDataGridViewTextBoxColumn.Name = "uploadDateDataGridViewTextBoxColumn";
			this.uploadDateDataGridViewTextBoxColumn.Visible = false;
			// 
			// lastModifiedDataGridViewTextBoxColumn
			// 
			this.lastModifiedDataGridViewTextBoxColumn.DataPropertyName = "LastModified";
			this.lastModifiedDataGridViewTextBoxColumn.HeaderText = "LastModified";
			this.lastModifiedDataGridViewTextBoxColumn.Name = "lastModifiedDataGridViewTextBoxColumn";
			this.lastModifiedDataGridViewTextBoxColumn.Visible = false;
			// 
			// FormProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1018, 621);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.comboBoxCategoryName);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxProductName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "商品維護";
			this.Load += new System.EventHandler(this.FormProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryEntityBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productEntityBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.formCategoryEditBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryEntityBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productEntityBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryEntityBindingSource2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxProductName;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.ComboBox comboBoxCategoryName;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.BindingSource categoryEntityBindingSource;
		private System.Windows.Forms.BindingSource categoryEntityBindingSource1;
		private System.Windows.Forms.BindingSource productEntityBindingSource;
		private System.Windows.Forms.BindingSource formCategoryEditBindingSource;
		private System.Windows.Forms.BindingSource productEntityBindingSource1;
		private System.Windows.Forms.BindingSource categoryEntityBindingSource2;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Picture1;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnit;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitsInStock;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sellerIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn productStatusDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productUnitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn picture1DataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productFlavorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productSizeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStockDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnOrderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn uploadDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedDataGridViewTextBoxColumn;
	}
}