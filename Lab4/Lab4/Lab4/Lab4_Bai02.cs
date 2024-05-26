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
using System.Security.Policy;

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
            richTextBox1.Clear();
            try
            {
                if (!tb_url.Text.StartsWith("http://"))
                    tb_url.Text = tb_url.Text.Insert(0, "http://");

                richTextBox1.AppendText(postRequest(tb_url.Text.Trim(), tb_.Text.Trim()));
            }
            catch (Exception ex) { richTextBox1.AppendText(ex.Message); }

        }
        private string postRequest(string szURL, string postData)
        {
            var byteArray = Encoding.UTF8.GetBytes(postData);

            var request = WebRequest.Create(szURL);
            request.Method = "POST";
            request.ContentLength = byteArray.Length;
            request.ContentType = "application/x-www-form-urlencoded";

            using (var requestStream = request.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            using (var response = request.GetResponse())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream == null)
                        throw new Exception("Null response stream");

                    using (var reader = new StreamReader(responseStream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }
    }
}
