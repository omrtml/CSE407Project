using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raporlama_ekranı_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            public void StudentList()
        {
            SqlCommand sorgu = new SqlCommand("Select*From Students", baglanti);
            baglanti.Open();
            SqlDataReader reader = sorgu.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListViewItem StudentList = new ListViewItem();
                    StudentList.Tag = reader["studentID"];
                    StudentList.Text = reader["trldNo"].ToString();
                    StudentList.SubItems.Add(reader)["studentname"].tostring());
                    StudentList.SubItems.Add(reader)["studentsurname"].tostring());
                    StudentList.SubItems.Add(reader)["phonenumber"].tostring());
                    StudentList.SubItems.Add(reader)["eMail"].tostring());
                    listview1.ıtems.add(StudentList);

                }
            }
            baglanti.Close();
            reader.close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            public void BookList()
        {
            SqlCommand sorgu = new SqlCommand("Select*From Books", baglanti);
            baglanti.Open();
            SqlDataReader reader = sorgu.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListViewItem BookList = new ListViewItem();
                    BooksList.Tag = reader["barcodeNO"];
                    BooksList.Text = reader["isbnNO"].ToString();
                    BooksList.SubItems.Add(reader)["volNO"].tostring());
                    BooksList.SubItems.Add(reader)["issueNO"].tostring());
                    BooksList.SubItems.Add(reader)["bookname"].tostring());
                    BooksList.SubItems.Add(reader)["placeofpub"].tostring());
                    BooksList.SubItems.Add(reader)["publise"].tostring());
                    BooksList.SubItems.Add(reader)["edition"].tostring());
                    listview1.ıtems.add(BookList);

                }
            }
            baglanti.Close();
            reader.close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            public void eMailLİst()
        {
            SqlCommand sorgu = new SqlCommand("Select*From email", baglanti);
            baglanti.Open();
            SqlDataReader reader = sorgu.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListViewItem eMailList = new ListViewItem();
                    emaillist.Tag = reader["eMailID"];
                    emaillist.Text = reader["studentID"].ToString();
                    emaillist.SubItems.Add(reader)["mailingdate"].tostring());
                    emaillist.SubItems.Add(reader)["processNO"].tostring());
                    emaillist.SubItems.Add(reader)["barcodeNO].tostring());
                    listview1.ıtems.add(eMailLİst);

                }

                baglanti.Close();
                reader.close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            public void SmsList()
        {
            SqlCommand sorgu = new SqlCommand("Select*From Sms", baglanti);
            baglanti.Open();
            SqlDataReader reader = sorgu.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListViewItem StudentList = new ListViewItem();
                    smslist.Tag = reader["smsID"];
                    smslist.Text = reader["studentID"].ToString();
                    smslist.SubItems.Add(reader)["smsdate"].tostring());
                    smslist.SubItems.Add(reader)["processNO"].tostring());
                    sms.SubItems.Add(reader)["barcodeNO"].tostring());
                    listview1.ıtems.add(SmsList);

                }
            }
            baglanti.Close();
            reader.close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            public void BlackList()
        {
            SqlCommand sorgu = new SqlCommand("Select*From BlackList", baglanti);
            baglanti.Open();
            SqlDataReader reader = sorgu.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListViewItem BlackList = new ListViewItem();
                    BlackList.Tag = reader["blacklistNO"];
                    BlackList.Text = reader["stundentID"].ToString();
                    BlackList.SubItems.Add(reader)["retardNO"].tostring());
                    BlackList.SubItems.Add(reader)["ListedDate"].tostring());
                    BlackList.SubItems.Add(reader)["removedDate"].tostring());
                    listview1.ıtems.add(BlackList);

                }
            }
            baglanti.Close();
            reader.close();
        }
    }
}