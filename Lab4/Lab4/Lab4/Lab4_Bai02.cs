using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;

namespace Lab4
{
    public partial class Lab4_Bai02 : Form
    {
        public Lab4_Bai02()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string Url = textBox1.Text;
            string postData = textBox2.Text;

            string responseContent = postRequest(Url, postData);
            richTextBox1.Text = responseContent;

        }
        private string postRequest(string szURL, string postData)
        {
            // Create a web request for the given URL
            WebRequest request = WebRequest.Create(szURL);
            request.Method = "POST";

            // Set the ContentType property
            request.ContentType = "application/x-www-form-urlencoded";
            // Convert the postData string to a byte array.
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = byteArray.Length;

            // Write data to the request stream
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            // Get the response and read the response stream
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    return reader.ReadToEnd(); // Read and return the response
                }
            }
        }
    }
}
