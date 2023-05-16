namespace ISpan.DessertShop.TinaWinForms
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonMaintainOrders = new System.Windows.Forms.Button();
            this.buttonMaintainProduct = new System.Windows.Forms.Button();
            this.buttonMaintainCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1662, 108);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.buttonMaintainOrders);
            this.splitContainer1.Panel1.Controls.Add(this.buttonMaintainProduct);
            this.splitContainer1.Panel1.Controls.Add(this.buttonMaintainCategory);
            this.splitContainer1.Size = new System.Drawing.Size(1205, 553);
            this.splitContainer1.TabIndex = 2;
            // 
            // buttonMaintainOrders
            // 
            this.buttonMaintainOrders.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonMaintainOrders.Location = new System.Drawing.Point(31, 175);
            this.buttonMaintainOrders.Name = "buttonMaintainOrders";
            this.buttonMaintainOrders.Size = new System.Drawing.Size(140, 50);
            this.buttonMaintainOrders.TabIndex = 2;
            this.buttonMaintainOrders.Text = "檢視訂單";
            this.buttonMaintainOrders.UseVisualStyleBackColor = true;
            this.buttonMaintainOrders.Click += new System.EventHandler(this.buttonMaintainOrders_Click);
            // 
            // buttonMaintainProduct
            // 
            this.buttonMaintainProduct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonMaintainProduct.Location = new System.Drawing.Point(31, 96);
            this.buttonMaintainProduct.Name = "buttonMaintainProduct";
            this.buttonMaintainProduct.Size = new System.Drawing.Size(140, 50);
            this.buttonMaintainProduct.TabIndex = 1;
            this.buttonMaintainProduct.Text = "維護商品";
            this.buttonMaintainProduct.UseVisualStyleBackColor = true;
            this.buttonMaintainProduct.Click += new System.EventHandler(this.buttonMaintainProduct_Click);
            // 
            // buttonMaintainCategory
            // 
            this.buttonMaintainCategory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMaintainCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaintainCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaintainCategory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonMaintainCategory.Location = new System.Drawing.Point(31, 21);
            this.buttonMaintainCategory.Name = "buttonMaintainCategory";
            this.buttonMaintainCategory.Size = new System.Drawing.Size(140, 50);
            this.buttonMaintainCategory.TabIndex = 0;
            this.buttonMaintainCategory.Text = "維護類別";
            this.buttonMaintainCategory.Click += new System.EventHandler(this.buttonMaintainCategory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonMaintainOrders;
        private System.Windows.Forms.Button buttonMaintainProduct;
        private System.Windows.Forms.Button buttonMaintainCategory;
    }
}