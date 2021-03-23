
namespace Northwind.WebForms.Ui
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.txtAddProductName = new System.Windows.Forms.TextBox();
            this.cbxAddCategory = new System.Windows.Forms.ComboBox();
            this.txtAddProductPrice = new System.Windows.Forms.TextBox();
            this.txtAddStock = new System.Windows.Forms.TextBox();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.txtUpdateStock = new System.Windows.Forms.TextBox();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.txtUpdateProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 129);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(734, 162);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(734, 54);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "KategoriyeGore Ara";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.btnRemove);
            this.gbxProduct.Controls.Add(this.txtProductName);
            this.gbxProduct.Controls.Add(this.lblProductName);
            this.gbxProduct.Location = new System.Drawing.Point(12, 72);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(734, 51);
            this.gbxProduct.TabIndex = 0;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Ürün Adına Göre Ara";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(6, 22);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(70, 19);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(232, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(6, 22);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(59, 16);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.Location = new System.Drawing.Point(70, 19);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(232, 22);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.txtQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.txtAddStock);
            this.gbxProductAdd.Controls.Add(this.txtAddProductPrice);
            this.gbxProductAdd.Controls.Add(this.cbxAddCategory);
            this.gbxProductAdd.Controls.Add(this.txtAddProductName);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblStock);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblAddCategory);
            this.gbxProductAdd.Controls.Add(this.lblAddProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(12, 297);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(734, 135);
            this.gbxProductAdd.TabIndex = 2;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(6, 33);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(48, 13);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Ürün Adı";
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Location = new System.Drawing.Point(6, 67);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(46, 13);
            this.lblAddCategory.TabIndex = 1;
            this.lblAddCategory.Text = "Kategori";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(6, 98);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(344, 36);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(54, 13);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stok Adet";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(344, 70);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(54, 13);
            this.lblQuantityPerUnit.TabIndex = 4;
            this.lblQuantityPerUnit.Text = "Birim Adet";
            // 
            // txtAddProductName
            // 
            this.txtAddProductName.Location = new System.Drawing.Point(60, 30);
            this.txtAddProductName.Name = "txtAddProductName";
            this.txtAddProductName.Size = new System.Drawing.Size(172, 20);
            this.txtAddProductName.TabIndex = 5;
            // 
            // cbxAddCategory
            // 
            this.cbxAddCategory.FormattingEnabled = true;
            this.cbxAddCategory.Location = new System.Drawing.Point(58, 64);
            this.cbxAddCategory.Name = "cbxAddCategory";
            this.cbxAddCategory.Size = new System.Drawing.Size(174, 21);
            this.cbxAddCategory.TabIndex = 6;
            // 
            // txtAddProductPrice
            // 
            this.txtAddProductPrice.Location = new System.Drawing.Point(58, 95);
            this.txtAddProductPrice.Name = "txtAddProductPrice";
            this.txtAddProductPrice.Size = new System.Drawing.Size(174, 20);
            this.txtAddProductPrice.TabIndex = 7;
            // 
            // txtAddStock
            // 
            this.txtAddStock.Location = new System.Drawing.Point(404, 33);
            this.txtAddStock.Name = "txtAddStock";
            this.txtAddStock.Size = new System.Drawing.Size(123, 20);
            this.txtAddStock.TabIndex = 8;
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(404, 67);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(123, 20);
            this.txtQuantityPerUnit.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(404, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtUpdateQuantity);
            this.groupBox1.Controls.Add(this.txtUpdateStock);
            this.groupBox1.Controls.Add(this.txtUpdatePrice);
            this.groupBox1.Controls.Add(this.cbxUpdateCategory);
            this.groupBox1.Controls.Add(this.txtUpdateProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 438);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 135);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜrünGüncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(404, 95);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateQuantity
            // 
            this.txtUpdateQuantity.Location = new System.Drawing.Point(404, 67);
            this.txtUpdateQuantity.Name = "txtUpdateQuantity";
            this.txtUpdateQuantity.Size = new System.Drawing.Size(123, 20);
            this.txtUpdateQuantity.TabIndex = 9;
            // 
            // txtUpdateStock
            // 
            this.txtUpdateStock.Location = new System.Drawing.Point(404, 33);
            this.txtUpdateStock.Name = "txtUpdateStock";
            this.txtUpdateStock.Size = new System.Drawing.Size(123, 20);
            this.txtUpdateStock.TabIndex = 8;
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(58, 95);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(174, 20);
            this.txtUpdatePrice.TabIndex = 7;
            // 
            // cbxUpdateCategory
            // 
            this.cbxUpdateCategory.FormattingEnabled = true;
            this.cbxUpdateCategory.Location = new System.Drawing.Point(58, 64);
            this.cbxUpdateCategory.Name = "cbxUpdateCategory";
            this.cbxUpdateCategory.Size = new System.Drawing.Size(174, 21);
            this.cbxUpdateCategory.TabIndex = 6;
            // 
            // txtUpdateProductName
            // 
            this.txtUpdateProductName.Location = new System.Drawing.Point(60, 30);
            this.txtUpdateProductName.Name = "txtUpdateProductName";
            this.txtUpdateProductName.Size = new System.Drawing.Size(172, 20);
            this.txtUpdateProductName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birim Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Adı";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(621, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(96, 30);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.TextBox txtAddStock;
        private System.Windows.Forms.TextBox txtAddProductPrice;
        private System.Windows.Forms.ComboBox cbxAddCategory;
        private System.Windows.Forms.TextBox txtAddProductName;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateQuantity;
        private System.Windows.Forms.TextBox txtUpdateStock;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.ComboBox cbxUpdateCategory;
        private System.Windows.Forms.TextBox txtUpdateProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
    }
}

