using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void loadProducts()
        {
            dgwProducts.DataSource = _productDal.getAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.add(new Product{
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            MessageBox.Show("Product Added!");
            loadProducts();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tabloya tıklandığında verilerin tableboxlara gelmesi
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.update(new Product
            {
                //güncellemek istediğimiz verileri butona tıklandığı zaman güncelleyen kodlar
                id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
            loadProducts();
            MessageBox.Show("Products Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.delete(new Product
            {
                id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            loadProducts();
            MessageBox.Show("Product Deleted");
        }
    }
}
