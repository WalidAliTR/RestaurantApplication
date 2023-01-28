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
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }
        public static SqlConnection con = new SqlConnection(LoginForm.sqlCon);
        public static SqlDataAdapter da;
        public static DataSet ds;

        private void PayForm_Load(object sender, EventArgs e)
        {
            float temp = (float)(MakeOrderForm.total * 0.14); Total.Text = (temp + MakeOrderForm.total).ToString();
            TotalTaxlbl.Text = temp.ToString(); TBTaxlbl.Text = MakeOrderForm.total.ToString();
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DishList.Items.Count; i++)
            {
                con.Open();
                string query = "insert into TempBillTb ([Food Name],Price) values('" + DishList.Items[i].ToString() + "','" + Convert.ToSingle(PriceList.Items[i]) + "')";
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            BillReport billReport = new BillReport();
            TextObject text = (TextObject)billReport.ReportDefinition.Sections["Section4"].ReportObjects["Text12"];
            text.Text = Total.Text;
            da = new SqlDataAdapter("select * From TempBillTb", con);
            ds = new DataSet();
            da.Fill(ds);
            billReport.SetDataSource(ds.Tables[0]);
            MainScreen.BillForm.crystalReportViewer1.ReportSource = billReport;
            MainScreen.BillForm.Show();
        }
        
        private void DishList_SelectedIndexChanged(object sender, EventArgs e) { PriceList.SelectedIndex = DishList.SelectedIndex; }

        private void PriceList_SelectedIndexChanged(object sender, EventArgs e) { DishList.SelectedIndex = PriceList.SelectedIndex; }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}