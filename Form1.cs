using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.Nhibernate;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.Entities.Concrete;
using System.Data.Entity.Infrastructure;
using Northwind.Business.DependencyResolvers.Ninject;

namespace Northwind.WebForms.Ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            //_productService = new ProductManager(new EfProductDal());
            //_categoryService = new CategoryManager(new EfCategoryDal());
        }

        IProductService _productService;
        ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            // ProductManager productManager = new ProductManager(new NhProductDal());
            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxAddCategory.DataSource = _categoryService.GetAll();
            cbxAddCategory.DisplayMember = "CategoryName";
            cbxAddCategory.ValueMember = "CategoryId";

            cbxUpdateCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch { }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            string key = txtProductName.Text;
            dgwProduct.DataSource = _productService.GerProductsByName(key);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxAddCategory.SelectedValue),
                    ProductName = txtAddProductName.Text,
                    QuantityPerUnit = txtQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(txtAddProductPrice.Text),
                    UnitsInStock = Convert.ToInt16(txtAddStock.Text)
                });
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                UnitsInStock = Convert.ToInt16(txtUpdateStock.Text),
                ProductName = txtUpdateProductName.Text,
                QuantityPerUnit = txtUpdateQuantity.Text,
                UnitPrice = Convert.ToDecimal(txtUpdatePrice.Text)
            });
            MessageBox.Show("Ürün Güncellendi");

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateProductName.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            cbxUpdateCategory.SelectedValue = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            txtUpdateQuantity.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            txtUpdatePrice.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            txtUpdateStock.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product()
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün Silindi");
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }

           
        }
    }
}
