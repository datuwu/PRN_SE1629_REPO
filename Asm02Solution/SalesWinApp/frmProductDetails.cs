using DataAccess.Repository;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;

namespace SalesWinApp
{
    public partial class frmProductDetails : Form
    {
       
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Product ProductInfor { get; set; }
        //----------------------------------------------

        public frmProductDetails()
        {
            InitializeComponent();
        }
        private void frmProductDetails_Load(object sender, EventArgs e)
        {
        
            txtProductID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)//update mode
            {
                //Show member to perform updating
                txtProductID.Text = ProductInfor.ProductId.ToString();
                txtProductName.Text = ProductInfor.ProductName;
                txtCategoryID.Text = ProductInfor.CategoryId.ToString();
                txtWeight.Text = ProductInfor.Weight;
                txtUnitPrice.Text = ProductInfor.UnitPrice.ToString();
                txtUnitsInStock.Text = ProductInfor.UnitsInStock.ToString();

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        { 
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtProductID.Text, @"^(?!\s*$).+")
                       && System.Text.RegularExpressions.Regex.IsMatch(txtProductName.Text, @"^(?!\s*$).+")
                       && System.Text.RegularExpressions.Regex.IsMatch(txtWeight.Text, @"^(?!\s*$).+")
                       && System.Text.RegularExpressions.Regex.IsMatch(txtUnitPrice.Text, @"^(?!\s*$).+")
                       && System.Text.RegularExpressions.Regex.IsMatch(txtUnitsInStock.Text, @"^(?!\s*$).+")
                       && System.Text.RegularExpressions.Regex.IsMatch(txtCategoryID.Text, @"^(?!\s*$).+"))
                {
                    var product = new Product
                {
                    ProductId = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock                                                              = int.Parse(txtUnitsInStock.Text),
                    CategoryId = int.Parse(txtCategoryID.Text),

                };
                if (InsertOrUpdate == false)
                {
                    ProductRepository.InsertProduct(product);
                }
                else
                {
                    ProductRepository.UpdateProduct(product);
                }
                }
                else
                {
                    MessageBox.Show("Please double check every fields must not be null, empty or spaces only!", InsertOrUpdate == false ? "Add a new Member" : "Update a Member");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Product" : "Update a Product");
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
       
    }
}
