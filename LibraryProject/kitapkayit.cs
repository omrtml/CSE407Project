﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kitap_kayit
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

            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(textBox6.Text) || String.IsNullOrEmpty(textBox7.Text) || String.IsNullOrEmpty(textBox8.Text) || String.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Eksik Alanları Doldurunuz");

            }
           
            else
                
            con.Open();

            SqlCommand cmd = new SqlCommand("studentRegistration", con);
            cmd.Connection = con;

            cmd.CommandText = "bookRegistration";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@isbnNO", SqlDbType.Int).Value = textBox1.Text;
            cmd.Parameters.Add("@volNo", SqlDbType.Int).Value = textBox2.Text;
            cmd.Parameters.Add("@issueNO", SqlDbType.Int).Value = textBox3.Text;
            cmd.Parameters.Add("@bookName", SqlDbType.NVarChar, 50).Value = textBox4.Text;
            cmd.Parameters.Add("@placeOfPub", SqlDbType.NVarChar, 100).Value = textBox5.Text;
            cmd.Parameters.Add("@publiser", SqlDbType.NVarChar, 100).Value = textBox6.Text;
            cmd.Parameters.Add("@edition", SqlDbType.Int).Value = textBox7.Text;
            cmd.Parameters.Add("@authorName", SqlDbType.NVarChar, 50).Value = textBox8.Text;
            cmd.Parameters.Add("@authorSurname", SqlDbType.NVarChar, 50).Value = textBox9.Text;
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
            {
                MessageBox.Show("kayit basarili");
            }
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
