using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{


    public partial class Registration : Form
    {
        byte[] salt = new byte[50];

        public Registration()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen ls = new LoginScreen();
            ls.Show();
        }

        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();



        private void btn_Register_Click(object sender, EventArgs e)
        {



            if (txt_Password.Text == txt_PasswordConfirm.Text
                && lblconfirm.Visible == false
                && lblwarning.Visible == false
                && prikey(txt_PriKey.Text) == true)
            {

                string saltstring = System.Text.Encoding.UTF8.GetString(salt, 0, salt.Length);
                SqlConnection con = new SqlConnection("server=localhost;Initial Catalog=Library;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("studentRegistration", con);
                cmd.Connection = con;
                cmd.CommandText = "CreateUser";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = txt_Username.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = txt_Password.Text;
                cmd.Parameters.Add("@salt", SqlDbType.VarChar, 50).Value = saltstring;
                int rtrn = cmd.ExecuteNonQuery();
                con.Close();
                genaratesalt();

                if (rtrn == 1)
                {
                    DialogResult rslt = MessageBox.Show("Registration Complated", " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (rslt == DialogResult.OK)
                    {
                        this.Hide();
                        LoginScreen ls = new LoginScreen();
                        ls.Show();

                    }
                }
            }



        }
        private static Boolean prikey(string s)
        {
            string prikey = "software";

            if (s == prikey)
                return true;
            else
                return false;

        }


        private void genaratesalt()
        {

            rngCsp.GetBytes(salt);

        }

        private void Registration_Load(object sender, EventArgs e)
        {

            genaratesalt();

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

            if (PasswordPolicy.IsValid(txt_Password.Text) == false)
                lblwarning.Visible = true;
            else lblwarning.Visible = false;
        }

        private void txt_PasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txt_Password.Text != txt_PasswordConfirm.Text)
                lblconfirm.Visible = true;
            else lblconfirm.Visible = false;

        }
    }

    public class PasswordPolicy : Form
    {
        private static int Minimum_Length = 8;
        private static int Upper_Case_length = 1;
        private static int Lower_Case_length = 1;
        private static int NonAlpha_length = 1;
        private static int Numeric_length = 1;

        public static bool IsValid(string Password)
        {
            if (Password.Length < Minimum_Length)
                return false;
            if (UpperCaseCount(Password) < Upper_Case_length)
                return false;
            if (LowerCaseCount(Password) < Lower_Case_length)
                return false;
            if (NumericCount(Password) < Numeric_length)
                return false;
            if (NonAlphaCount(Password) < NonAlpha_length)
                return false;
            return true;
        }

        private static int UpperCaseCount(string Password)
        {
            return Regex.Matches(Password, "[A-Z]").Count;
        }

        private static int LowerCaseCount(string Password)
        {
            return Regex.Matches(Password, "[a-z]").Count;
        }
        private static int NumericCount(string Password)
        {
            return Regex.Matches(Password, "[0-9]").Count;
        }
        private static int NonAlphaCount(string Password)
        {
            return Regex.Matches(Password, @"[^0-9a-zA-Z\._]").Count;
        }
    }

}
