using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_server_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}
