using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Resturant_Application
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
       public static SqlConnection con = new SqlConnection(LoginForm.sqlCon);
        public static SqlDataAdapter da;
        public static DataSet ds;
        static string UserIDtxt,UserNametxt;

        private void AdminForm_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LoginForm.userid) == 1)
            {
                RadioButton4.Visible = true; label18.Visible = true;
                da = new SqlDataAdapter("select UserID,UserName,AccountType from LoginTb where AccountType='" + "WORKER" + "' or AccountType='" + "ADMIN" + "'", con);
            }
            else
            {
                da = new SqlDataAdapter("select UserID,UserName,AccountType from LoginTb where AccountType='" + "WORKER" + "'", con);
                RadioButton4.Visible = false; label18.Visible = false;
            }
            ds = new DataSet();
            da.Fill(ds, "LoginTb");
            DGVDetails.DataSource = ds.Tables["LoginTb"];
        }

        private void ChangeAdminBtn_Click(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("select AdminPIN From LoginTb Where UserID ='" + LoginForm.userid + "'", con);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0].ToString() == TextBox9.Text)
                {
                    da = new SqlDataAdapter("select UserID,Password,AdminPIN From LoginTb Where UserID ='" + Convert.ToInt32(TextBox8.Text) + "' And Password='" + TextBox7.Text + "'", con);
                    ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][2].ToString() != "")
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("UPDATE LoginTb SET AdminPIN ='" + TextBox10.Text + "' Where UserID ='" + Convert.ToInt32(TextBox8.Text) + "'", con);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Updated Successfully!");
                        con.Close();
                        TextBox7.Clear(); TextBox8.Clear(); TextBox9.Clear(); TextBox10.Clear();
                    }
                    else if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][2].ToString() == "") { MessageBox.Show("This Account doesn't Have An Admin PIN!!"); TextBox7.Clear(); TextBox8.Clear(); TextBox9.Clear(); TextBox10.Clear(); TextBox9.Focus(); }
                    else { MessageBox.Show("The User ID or Password is Wrong, Please Try Again!"); TextBox7.Clear(); TextBox8.Clear(); }
                }
                else { MessageBox.Show("Your Admin PIN Is Wrong, Please Check It And Try Again!!"); TextBox9.Clear(); }
            }
            catch (FormatException) { MessageBox.Show("Please, Enter a Numbers In User ID Box!!"); TextBox7.Clear(); TextBox8.Clear(); TextBox8.Focus(); }
            catch { MessageBox.Show("An Error Found!!"); }

        }

        private void MakeAdminBtn_Click(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("select AdminPIN From LoginTb Where UserID ='" + LoginForm.userid + "'", con);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0].ToString() == TextBox6.Text)
                {
                    da = new SqlDataAdapter("select UserID,AdminPIN From LoginTb Where UserID ='" + Convert.ToInt32(TextBox5.Text) + "'", con);
                    ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][1].ToString() == "")
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("UPDATE LoginTb SET AdminPIN = '" + TextBox4.Text + "', AccountType='"+"ADMIN"+"' Where UserID = '" + Convert.ToInt32(TextBox5.Text) + "'", con);
                        command.ExecuteNonQuery();
                        MessageBox.Show("added Successfully!");
                        con.Close();
                        TextBox4.Clear(); TextBox5.Clear(); TextBox6.Clear();
                    }
                    else if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][1].ToString() != "") { MessageBox.Show("This Account Already Admin!!"); TextBox4.Clear(); TextBox5.Clear(); TextBox6.Clear(); TextBox6.Focus(); }
                    else { MessageBox.Show("The User ID isn't Found, Please Try Again!"); TextBox4.Clear(); TextBox5.Clear(); TextBox5.Focus(); }
                }
                else { MessageBox.Show("Your Admin PIN Is Wrong, Please Check It And Try Again!!"); TextBox6.Clear(); }
            }
            catch (FormatException) { MessageBox.Show("Please, Enter a Numbers In User ID Box!!"); TextBox4.Clear(); TextBox5.Clear(); TextBox5.Focus(); }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ChangeYourPINBtn_Click(object sender, EventArgs e)
        {
            try {
                if (LoginForm.userpassword == TextBox1.Text)
                {
                    da = new SqlDataAdapter("select AdminPIN From LoginTb Where UserID ='" + LoginForm.userid + "'", con);
                    ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0].ToString() == TextBox2.Text)
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("UPDATE LoginTb SET AdminPIN = '" + TextBox3.Text + "' Where UserID = '" + LoginForm.userid + "'", con);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Updated Successfully!");
                        con.Close();
                        TextBox1.Clear(); TextBox2.Clear(); TextBox3.Clear();
                    }
                    else MessageBox.Show("Your Admin PIN Is Wrong!! Please Try Again."); TextBox2.Clear(); TextBox2.Focus();
                }
                else { MessageBox.Show("Your Password Is Wrong!, Please Try Again."); TextBox1.Clear(); TextBox1.Focus(); }
            }
            catch (FormatException) { MessageBox.Show("Please, Enter The PIN with Just Numbers!!"); TextBox2.Clear(); TextBox3.Clear(); TextBox2.Focus(); }
            catch { MessageBox.Show("An Error Found!!"); }
        }

        private void DGVDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGVDetails.Rows[e.RowIndex];
                UserIDtxt = row.Cells["UserID"].Value.ToString();
                UserNametxt = row.Cells["UserName"].Value.ToString();
            }
        }

        private void RemoveAdminBtn_Click(object sender, EventArgs e)
        {
            try
            {
        con = new SqlConnection(LoginForm.sqlCon);
        da = new SqlDataAdapter("Select AdminPIN From LoginTb Where UserID ='" +Convert.ToInt32(LoginForm.userid)+"'", con);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                if (dataTable.Rows[0][0].ToString()== Admintxt.Text  && CreateAccountForm.MD5Encrypting(Adminpasstxt.Text) == CreateAccountForm.MD5Encrypting(LoginForm.userpassword))
                {
                    da = new SqlDataAdapter("select UserName,AdminPIN From LoginTb Where UserID ='" + Convert.ToInt32(AccIDtxt.Text) + "'", con);
                    ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][1].ToString()!="")
                    {
                        if (MessageBox.Show("Are You Sure That You Want To Remove " + ds.Tables[0].Rows[0][0].ToString() + " From Admin?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                            con.Open();
                            SqlCommand command = new SqlCommand("UPDATE LoginTb SET AccountType ='"+"WORKER"+"',AdminPIN='"+""+"' Where UserID ='" + Convert.ToInt32(AccIDtxt.Text) + "'", con);
                            command.ExecuteNonQuery();
                            con.Close();
                        }
                        Admintxt.Clear(); Adminpasstxt.Clear(); AccIDtxt.Clear();
                    }
                    else if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][1].ToString() == "") { MessageBox.Show("This Account Is Not An Admin!! Please Try Another Account."); AccIDtxt.Clear();AccIDtxt.Focus(); }
                }
                else { MessageBox.Show("Your Admin PIN Or Password Is Wrong, Please Check Them And Try Again!!"); Adminpasstxt.Clear(); Admintxt.Clear(); Admintxt.Focus(); }
            }
            catch (FormatException) { MessageBox.Show("Please, Enter a Numbers In User ID Box!!"); AccIDtxt.Clear(); AccIDtxt.Focus(); }
            catch { MessageBox.Show("An Error Found!!"); }
        }

        private void DeleteAccountBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To Delete " + UserNametxt + " Account?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                 con.Open();
                 SqlCommand command = new SqlCommand("Delete From LoginTb Where UserID='"+Convert.ToInt32(UserIDtxt)+"'",con);
                 command.ExecuteNonQuery();
                 con.Close();
            }
        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e){GroupBox1.Visible = RadioButton1.Checked;}

        private void RadioButton2_CheckedChanged(object sender, EventArgs e){GroupBox2.Visible = RadioButton2.Checked;}

        private void RadioButton3_CheckedChanged(object sender, EventArgs e){GroupBox3.Visible = RadioButton3.Checked;}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e){GroupBox4.Visible = RadioButton4.Checked;}

    }
}