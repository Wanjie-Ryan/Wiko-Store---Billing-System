using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Wiko_Store.Data_Layer;
using Wiko_Store.Logics;

namespace Wiko_Store.UI
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        CustomerDAL cdal = new CustomerDAL();
        productsDAL pdal = new productsDAL();
        DataTable dt = new DataTable();
        UserDAL udal = new UserDAL();
        transactionDAL tdal = new transactionDAL();
        transactionDetailsDAL tdetail = new transactionDetailsDAL();

        //CustomerLogics cl = new CustomerLogics();   
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // get the transactionType value from the formuserdashboard

            string type = FormUserDashboard.transactionType;

            // set the value on lblTop

            lblTop.Text = type;

            // specify the columns for the datagridview

            dt.Columns.Add("Product Name");
            dt.Columns.Add("Rate");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Total");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // get the keyword from the textbox

            string keyword = txtSearch.Text;

            if(keyword == "")
            {
                //if the search box is empty, render all the the other textboxes empty too.

                txtName.Text = "";
                txtEmail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                return;
            }

            // write the code to get the details and set the value on textboxes

            CustomerLogics cl = cdal.SearchDealerCustomer(keyword);

            // set the value in the cl to the textboxes

            txtName.Text = cl.name;
            txtEmail.Text = cl.email;
            txtContact.Text = cl.contact;
            txtAddress.Text = cl.address;



        }

        private void txtProdSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtProdSearch.Text;

            if(keyword == "")
            {
                //txtProdSearch.Text = "";
                txtProdName.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQuantity.Text = "";
                return;
            }

            ProductsLogic pl = pdal.SearchProductTransaction(keyword);

            // set the value in the pl to the textboxes

            txtProdName.Text = pl.name;
            txtRate.Text = pl.rate.ToString();
            txtInventory.Text =pl.quantity.ToString();

            //convert the rate and quantity to a string beacuse they are in decimal datatype.


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // get product name, rate, and quantity the customer wants to buy

            string productName = txtProdName.Text;
            decimal rate = decimal.Parse(txtRate.Text);
            decimal quantity = decimal.Parse(txtQuantity.Text);

            decimal total = rate * quantity;

            // display the subtotal in the textbox
            // get the subtotal value from the textbox

            decimal subTotal = decimal.Parse(txtSubTotal.Text);
            //Console.WriteLine(subTotal);
            subTotal = subTotal + total;

            if (productName == "" )
            {
                MessageBox.Show("Enter a product first. Try Again!", "Search for a product", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            else
            {
                dt.Rows.Add(productName, rate, quantity, total);

                // show the product in the data grid view

                dgvAddedProducts.DataSource = dt;

                // display the subtotal in textbox

                txtSubTotal.Text = subTotal.ToString();

                // clear the textboxes after adding the products to the datagrid view

                txtProdSearch.Text = "";
                txtProdName.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQuantity.Text = "";
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

            string value = txtDiscount.Text;

            if(value == "")
            {
                MessageBox.Show("Please provide the discount, if applicable", "Discount not provided!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {

                // getting the sub total to perform the grandtotal calculation
                decimal subTotal = decimal.Parse(txtSubTotal.Text);

                // getting the discount in form of decimal value
                decimal discount = decimal.Parse(txtDiscount.Text);

                // calculating the grand total based n the discount and subTotal

                decimal grandTotal = ((100 - discount) / 100) * subTotal;

                // display the grandTotal in the textbox

                txtGT.Text = grandTotal.ToString();


            }
        }

        private void txtVAT_TextChanged(object sender, EventArgs e)
        {
            string vatValue = txtVAT.Text;

            if(vatValue == "")
            {
                MessageBox.Show("Calculate the discount and set the GrandTotal first", "Calculate Discount", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                // getting the vat from the textbox

                decimal gt = decimal.Parse(txtGT.Text);
                decimal vat = decimal.Parse(txtVAT.Text);

                decimal GrandTotal = (100 + vat)/100 *gt;

                // displaying new grandtotal with vat

                txtGT.Text = GrandTotal.ToString();
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            // getting the paid amount from the textbox, and also the grandTotal

            decimal grandTotal = Math.Round(decimal.Parse(txtGT.Text),2);
            decimal paidAmount = decimal.Parse(txtPaidAmount.Text);

            decimal ReturnAmount = paidAmount - grandTotal;

            // display the change

            txtReturnAmount.Text = ReturnAmount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // get the details from the form

            transactionLogics tl = new transactionLogics();

            tl.type = lblTop.Text;

            // getting the id of the dealer or customer
            // get the name of the delaer or customer that was searched for
            string deaCustName = txtName.Text;

            CustomerLogics cl = cdal.GetDeaCustID(deaCustName);

            tl.dea_cust_id = cl.id;

            tl.total = decimal.Parse(txtGT.Text);

            tl.transaction_date = DateTime.Now;
            tl.tax = decimal.Parse(txtVAT.Text);
            tl.discount = decimal.Parse(txtDiscount.Text);

            // get the id of the user who has been logged in

            string loggeduser = LoginForm.loggedIn;

            UserLogics ul = udal.GetIDFromUsername(loggeduser);

            tl.added_by = ul.id;

            tl.transactionDetails = dt;

            // creating a boolean variable to check if the transaction was successful or not

            bool success = false;

           using(TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;

                // create a boolean variable and insert transaction

                bool w = tdal.InsertTransactions(tl, out transactionID);

                // use for loop to insert transaction details

                for(int i =0; i<dt.Rows.Count; i++)
                {
                    // get all the details of the product

                    transactionDetailsLogics tdl = new transactionDetailsLogics();

                    // get the product name and convert it to id

                    string productName = txtProdName.Text;

                    ProductsLogic pl = pdal.GetIDByProductName(productName);

                    tdl.product_id = pl.id;

                    // getting the rate from the transaction DT
                    tdl.rate = decimal.Parse(dt.Rows[i][1].ToString());

                    // getting the quantity from the transaction DT
                    tdl.quantity = decimal.Parse(dt.Rows[i][2].ToString());

                    // getting the total from the transaction DT

                    tdl.total = Math.Round(decimal.Parse(dt.Rows[i][3].ToString()),2);

                    tdl.dea_cust_id = cl.id;

                    tdl.added_date = DateTime.Now;
                    tdl.added_by = ul.id;

                    // insert the data into the db

                    bool y = tdetail.InsertTransDetails(tdl);

                    
                    success = w && y;


                }


                if (success == true)
                {
                    scope.Complete();
                    MessageBox.Show("Transaction completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // clear the datagrid view and textboxes

                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();
                    txtSearch.Text = "";
                    txtName.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";
                    txtProdSearch.Text = "";
                    txtProdName.Text = "";
                    txtInventory.Text = "";
                    txtRate.Text = "";
                    txtQuantity.Text = "";
                    txtSubTotal.Text = "0";
                    txtDiscount.Text = "0";
                    txtVAT.Text = "0";
                    txtGT.Text = "0";
                    txtPaidAmount.Text = "0";
                    txtReturnAmount.Text = "0";
                }
                else
                {
                    MessageBox.Show("Transaction failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }


        }
    }
}
