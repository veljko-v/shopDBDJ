using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Products : Form
    {
        readonly ProductBusiness productBusiness = new ProductBusiness(); 

        public Products()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            listBoxItems.Items.Clear();
            foreach (Product product in productBusiness.GetProducts())
            {
                listBoxItems.Items.Add($"{product.Id}. {product.Name}");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = tbName.Text,
                Description = tbDescription.Text,
                ExpiryDate = dateTimePicker1.Value
            };

            productBusiness.InsertProduct(product);

            RefreshList();

            tbName.Text = "";
            tbDescription.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            tbName.Focus();
        }
    }
}
