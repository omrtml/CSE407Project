using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Web;
using System.Net.Http.Headers;
namespace Mail_Module
{
    public string Name { get; set; }
    public partial class SMS : Form {
        private const string URL = "https://api-gw.turkcell.com.tr/api/v1/sms";
        private string urlParameters = "8403cb98-fe34-48e8-88b8-79aa3f2081bd";

        private void SMS_Load(object sender, EventArgs e)
        {

        }
    }


    static void SendSMS(string[] args)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(URL);

        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("api_key:8403cb98-fe34-48e8-88b8-79aa3f2081bd"));

    }
   


}
