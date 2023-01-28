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
using System.Security.Cryptography;

namespace Resturant_Application
{
    public partial class CreateAccountForm : Form
    {
        bool check = false;
        public static SqlConnection con = new SqlConnection(LoginForm.sqlCon);

        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {
            notifyIcon.Icon = SystemIcons.Application;
            ShowPasswordBox.Checked = true;
        }

        public void SignUp()
        {
            string adminpin;
            if (passwordTextBox.Text == PasswordAgaintxtbox.Text && userNameTextBox.Text != "" && PasswordAgaintxtbox.TextLength > 7 && AdminPINtxt.Text!="")
            {
                try
                {
                    string signuptry = "select * from LoginTb Where AdminPIN = '" + AdminPINtxt.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(signuptry, con);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        adminpin = AdminPINtxt.Text; check = true;
                    }
                    else
                    {
                        MessageBox.Show("Invaild Admin PIN! Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminPINtxt.Clear(); AdminPINtxt.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
            else if (userNameTextBox.Text == "") MessageBox.Show("Please Enter Your User Name!");
            else if (PasswordAgaintxtbox.TextLength < 8)
            {
                MessageBox.Show("Please Put Password With At least 8 Numbers/Characters And Try Again!");
                PasswordAgaintxtbox.Clear(); passwordTextBox.Clear(); passwordTextBox.Focus();
            }
            else if (PasswordAgaintxtbox.Text != passwordTextBox.Text)
            {
                MessageBox.Show("The Password Isn't The Same, Please Check It And Try Again!");
                passwordTextBox.Clear(); PasswordAgaintxtbox.Clear(); passwordTextBox.Focus();
            }
            else if (AdminPINtxt.Text == "") MessageBox.Show("Please Enter The Admin PIN!"); AdminPINtxt.Focus();
            
        }

        public static string MD5Encrypting(string EncryptionText)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(EncryptionText);

            array = md5.ComputeHash(array);

            StringBuilder sb = new StringBuilder();
            foreach (byte item in array)
                sb.Append(item.ToString("x2").ToLower());

            return sb.ToString();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            SignUp();
            if (check == true)
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into LoginTb(UserName,Password,AccountType) values ('" + userNameTextBox.Text + "','" + MD5Encrypting(passwordTextBox.Text) + "','" + "WORKER" + "')", con);
                if (command.ExecuteNonQuery() == 1) notifyIcon.ShowBalloonTip(3000, "Welcome With Us " + userNameTextBox.Text + "!", "Your Account Has Been Created Succesfully!", ToolTipIcon.Info);
                SqlCommand comm = new SqlCommand("Select IDENT_CURRENT('LoginTb')", con);
                MessageBox.Show("Your UserID is " + comm.ExecuteScalar().ToString() + " Please Remember it and Keep it Safe!");
                userNameTextBox.Clear(); passwordTextBox.Clear(); PasswordAgaintxtbox.Clear(); AdminPINtxt.Clear();
                con.Close(); this.Hide();
            }
        }

        private void ShowPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordAgaintxtbox.UseSystemPasswordChar = passwordTextBox.UseSystemPasswordChar = ShowPasswordBox.Checked;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
