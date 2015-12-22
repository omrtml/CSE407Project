using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Mail_Module
{
    public partial class Mail : Form
    {
                public static string USERNAME = "80ddbdb6-aa41-42b6-90ca-959890158ce3";
                public static string API_KEY = "80ddbdb6-aa41-42b6-90ca-959890158ce3";


        public static string SendEmail(string to, string subject, string bodyText, string from, string fromName)
        {

            WebClient client = new WebClient();
            NameValueCollection values = new NameValueCollection();
            values.Add("username", USERNAME);
            values.Add("api_key", API_KEY);
            values.Add("from", from);
            values.Add("from_name", fromName);
            values.Add("subject", subject);
            if (bodyText != null)
                values.Add("body_text", bodyText);
            values.Add("to", to);

            byte[] response = client.UploadValues("https://api.elasticemail.com/mailer/send", values);
            return Encoding.UTF8.GetString(response);
        }


        public Mail()
        {

            InitializeComponent();

        }

        private void buttonMailSend_Click(object sender, EventArgs e)
        {
            string from = "toroslibrary@mail.com";
            string fromName = "Toros Kütüphane";
            string to = textBox1.Text;
            string subject = "Ödünç Kitap";
            string bodyText = richTextBox1.Text;
            string result = SendEmail(to, subject, bodyText, from, fromName);
            MessageBox.Show(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SMS SMS = new SMS();
            SMS.Show();
        }

        private void Mail_Load(object sender, EventArgs e)
        {

        }
    }
}
