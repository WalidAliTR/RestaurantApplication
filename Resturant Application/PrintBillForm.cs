using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Resturant_Application
{
    public partial class PrintBillForm : Form
    {
        public PrintBillForm()
        {
            InitializeComponent();
        }
        public static SqlConnection con = new SqlConnection(LoginForm.sqlCon);
        public static SqlDataAdapter da;
        public static DataSet ds;

        private void PrintBillForm_FormClosed(object sender, FormClosedEventArgs e) { ClearTable(); }

        void ClearTable()
        {
            da = new SqlDataAdapter("select * From TempBillTb", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string query = "delete from TempBillTb where ID ='" + Convert.ToInt32(ds.Tables[0].Rows[i][0]) + "'";
                SqlCommand myCommand = new SqlCommand(query, con);
                myCommand.ExecuteNonQuery();
            }
            con.Close();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            LoginForm.Form1.Order();
            MakeOrderForm.total = 0;
            crystalReportViewer1.PrintReport();
            ClearTable();
            this.Hide();
            MainScreen.PayForm.DishList.Items.Clear();
            MainScreen.PayForm.PriceList.Items.Clear();
            MainScreen.PayForm.Hide();
            MainScreen.OrderForm.DishList.Items.Clear();
            MainScreen.OrderForm.PriceList.Items.Clear();
            MainScreen.OrderForm.Totallbl.Text = "";
            MainScreen.OrderForm.BackCateBtn.PerformClick();
            MainScreen.OrderForm.Hide();
            LoginForm.Form1.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            ClearTable();
            this.Hide();
        }
    }
}