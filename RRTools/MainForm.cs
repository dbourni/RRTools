using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RRTools
{
    public partial class MainForm : Form
    {
        static HttpClient client = new HttpClient();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String data = Get_request("https://api.raceresult.com/153860/324CV6Q778H7G5VZ8IIR5W7RAFSVBJL7");
            if (data != "error")
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List));
                StringReader stringReader = new StringReader(data);
                List PilotsList;
                PilotsList = (List)serializer.Deserialize(stringReader);
                MessageBox.Show(PilotsList.Pilots.Length.ToString());
            }
        }

        private string Get_request(string Url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.ContentType = "application/json; charset=utf-8";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch
            {
                return "error";
            }

        }

    }
}
