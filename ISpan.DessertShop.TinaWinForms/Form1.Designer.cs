namespace ISpan.DessertShop.TinaWinForms
{
	partial class Form1
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
            this.buttonConnectString = new System.Windows.Forms.Button();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.checkBoxPooling = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemMaintainCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMaintainProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMaintainOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnectString
            // 
            this.buttonConnectString.Location = new System.Drawing.Point(43, 94);
            this.buttonConnectString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConnectString.Name = "buttonConnectString";
            this.buttonConnectString.Size = new System.Drawing.Size(197, 31);
            this.buttonConnectString.TabIndex = 0;
            this.buttonConnectString.Text = "連線字串";
            this.buttonConnectString.UseVisualStyleBackColor = true;
            this.buttonConnectString.Click += new System.EventHandler(this.buttonConnectString_Click);
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(43, 155);
            this.buttonConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(197, 31);
            this.buttonConnection.TabIndex = 1;
            this.buttonConnection.Text = "連線測試";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // checkBoxPooling
            // 
            this.checkBoxPooling.AutoSize = true;
            this.checkBoxPooling.Location = new System.Drawing.Point(288, 165);
            this.checkBoxPooling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPooling.Name = "checkBoxPooling";
            this.checkBoxPooling.Size = new System.Drawing.Size(55, 19);
            this.checkBoxPooling.TabIndex = 2;
            this.checkBoxPooling.Text = "Pool";
            this.checkBoxPooling.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemMaintainCategories,
            this.menuItemMaintainProducts,
            this.menuItemMaintainOrdersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemMaintainCategories
            // 
            this.menuItemMaintainCategories.Name = "menuItemMaintainCategories";
            this.menuItemMaintainCategories.Size = new System.Drawing.Size(133, 26);
            this.menuItemMaintainCategories.Text = "維護商品分類(&C)";
            this.menuItemMaintainCategories.Click += new System.EventHandler(this.menuItemMaintainCategories_Click);
            // 
            // menuItemMaintainProducts
            // 
            this.menuItemMaintainProducts.Name = "menuItemMaintainProducts";
            this.menuItemMaintainProducts.Size = new System.Drawing.Size(102, 26);
            this.menuItemMaintainProducts.Text = "維護商品(&P)";
            this.menuItemMaintainProducts.Click += new System.EventHandler(this.menuItemMaintainProducts_Click);
            // 
            // menuItemMaintainOrdersToolStripMenuItem
            // 
            this.menuItemMaintainOrdersToolStripMenuItem.Name = "menuItemMaintainOrdersToolStripMenuItem";
            this.menuItemMaintainOrdersToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.menuItemMaintainOrdersToolStripMenuItem.Text = "維護訂單(&O)";
            this.menuItemMaintainOrdersToolStripMenuItem.Click += new System.EventHandler(this.menuItemMaintainOrdersToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.checkBoxPooling);
            this.Controls.Add(this.buttonConnection);
            this.Controls.Add(this.buttonConnectString);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonConnectString;
		private System.Windows.Forms.Button buttonConnection;
		private System.Windows.Forms.CheckBox checkBoxPooling;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuItemMaintainCategories;
		private System.Windows.Forms.ToolStripMenuItem menuItemMaintainProducts;
		private System.Windows.Forms.ToolStripMenuItem menuItemMaintainOrdersToolStripMenuItem;
	}
}