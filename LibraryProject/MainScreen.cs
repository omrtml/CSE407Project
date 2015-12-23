using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LibraryProject
{
    public partial class MainScreen : Form
    {
        public static string USERNAME = "80ddbdb6-aa41-42b6-90ca-959890158ce3"; // mail api için kullanıcı adı
        public static string API_KEY = "80ddbdb6-aa41-42b6-90ca-959890158ce3"; // mail api için api key
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=localhost;Initial Catalog=Library;Integrated Security=True");
            SqlCommand mailproc = new SqlCommand("MailSender", con);
            mailproc.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dr = new SqlDataAdapter(mailproc);
            DataSet ds = new DataSet();
            dr.Fill(ds, "MailSender");

            this.Hide();
            LoginScreen ls = new LoginScreen();
            ls.Show();
        }

    }
}
