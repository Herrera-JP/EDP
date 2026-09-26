using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Inventory.CustomException;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;

        private BindingSource showProductList;


        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }


        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = { "Beverages", "Bread/Bakery", "Canned/Jarred Goods",
                "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other" };

            foreach (string variableName in ListOfProductCategory)
            {
                cbCategory.Items.Add(variableName);
            }

            
        }

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                throw new StringFormatException("Product must letter only");
            return name;
        }

        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]+$"))
                throw new NumberFormatException("Quantity must number only");
            return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                throw new CurrencyFormatException("Price must valid number.");
            return Convert.ToDouble(price);
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
                    _ExpDate, _SellPrice, _Quantity, _Description));

                gridViewProductList.DataSource = showProductList;
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Clearfields();
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show(ex.Message, "Error! Invalid product");
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message, "Error! Invalid Quantity");
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(ex.Message, "Error! Invalid Price");
            }
            finally
            {
                Console.WriteLine("Add product attempt finished at " + DateTime.Now);
            }
        }
        public void Clearfields()
        {
            txtProductName.Clear();
            cbCategory.SelectedIndex = -1;
            dtPickerMfgDate.Value = DateTime.Now;
            dtPickerExpDate.Value = DateTime.Now;
            richTxtDescription.Clear();
            txtQuantity.Clear();
            txtSellPrice.Clear();
        }
    }
    class StringFormatException : Exception
    {
        public StringFormatException(string varName) : base(varName) { }
    }

    class NumberFormatException : Exception
    {
        public NumberFormatException(string varName) : base(varName) { }
    }

    class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string varName) : base(varName) { }
    }
}
