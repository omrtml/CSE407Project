using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ogrenci_kayit
{
    public partial class Form1 : Form
    {
        private SqlConnection con;

        public Form1()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection("server=localhost; Initial Catalog=library;Integrated Security=true");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox6.Text) || String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(maskedtextBox4.Text) || String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Eksik Alanları Doldurunuz");
            }
           

            else



                con = new SqlConnection("Server=localhost; Initial Catalog=library;Integrated Security=true");
            con.Open();

            SqlCommand cmd = new SqlCommand("studentRegistration", con);
            cmd.Connection = con;

            cmd.CommandText = "studentRegistration";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@studentID", SqlDbType.Int).Value = textBox6.Text;
            cmd.Parameters.Add("@trlDNo", SqlDbType.Int).Value = textBox1.Text;
            cmd.Parameters.Add("@studentName", SqlDbType.NVarChar, 30).Value = textBox2.Text;
            cmd.Parameters.Add("@studentSurname", SqlDbType.NVarChar, 30).Value = textBox3.Text;
            cmd.Parameters.Add("@phoneNumber", SqlDbType.Int).Value = maskedtextBox4.Text;
            cmd.Parameters.Add("@eMail", SqlDbType.NVarChar, 50).Value = textBox5.Text;
            cmd.Parameters.Add("@Return", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            

            cmd.ExecuteNonQuery();
            int ret = int.Parse(cmd.Parameters["@Return"].Value.ToString());

            if (ret == 1)
            {
                MessageBox.Show("Kayıt Başarılı");
    
            }
            else
            {
                MessageBox.Show("öğrenci zaten kayıtlı");


            }
            con.Close();
        
            }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tus;
            tus = MessageBox.Show("Çıkmak istediğinizden emin misiniz..?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tus == DialogResult.Yes)
            {
                Close();
            }
        }
    }
    }