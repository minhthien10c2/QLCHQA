using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_KIEU
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public String auth;
        public String account;

        Bill_GUI bill_gui;
        Product_GUI product_gui;
        Category_GUI category_gui;
        Account_GUI account_gui;
        Report_GUI report_sales_gui;
        ChangePassword_GUI change_pass_gui;
        Customer_GUI customer_gui;

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            change_pass_gui = new ChangePassword_GUI();
            change_pass_gui.account = account;
            change_pass_gui.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            customer_gui = new Customer_GUI();
            customer_gui.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            category_gui = new Category_GUI();
            category_gui.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            product_gui = new Product_GUI();
            product_gui.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            report_sales_gui = new Report_GUI();
            report_sales_gui.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            account_gui = new Account_GUI();
            account_gui.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (auth == "Nhân viên")
            {
                pnAccount.Visible = false;
                pnCategory.Visible = false;
                pnProduct.Visible = false;
                pnReport.Visible = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            bill_gui = new Bill_GUI();
            bill_gui.ShowDialog();
        }

        


    }
}
