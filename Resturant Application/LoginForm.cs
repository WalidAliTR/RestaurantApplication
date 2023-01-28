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

namespace Resturant_Application
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string sqlCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kg462\Desktop\Universite Files\Programs\Resturant Application Evolution\Resturant Application Version 1.0\Resturant Application\Database.mdf;Integrated Security=True";
        public static CreateAccountForm signupform = new CreateAccountForm();
        public static MainScreen Form1 = new MainScreen();
        public static SqlConnection con = new SqlConnection(sqlCon);
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static string userid, userpassword;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = true;
        }

        public void Login()
        {
            try
            {
                string logintry = "select * from LoginTb Where UserID = '" + TxtUserID.Text + "'  And Password ='" + CreateAccountForm.MD5Encrypting(TxtPassword.Text) + "'";
                SqlDataAdapter sda = new SqlDataAdapter(logintry, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    userid = TxtUserID.Text; userpassword= TxtPassword.Text;
                    TxtUserID.Clear(); TxtPassword.Clear();
                    con.Open();
                    SqlCommand command = new SqlCommand("select UserName from LoginTb where UserID='" + LoginForm.userid + "'", con);
                    Form1.label1.Text = "Welcome " + command.ExecuteScalar().ToString();
                    con.Close();
                    this.Hide();
                    Form1.Show();
                }
                else
                {
                    MessageBox.Show("Invaild Login Details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUserID.Clear(); TxtPassword.Clear(); TxtUserID.Focus();
                }
            }
            catch { MessageBox.Show("Error"); }
        }

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             signupform.ShowDialog(); 
        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = guna2CustomCheckBox1.Checked;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
