using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Imap;
using MailKit.Security;
using MimeKit;
using System.Windows.Forms;
using MailKit;
using MailKit.Search;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class b4 : Form
    {
        public b4()
        {
            InitializeComponent();
        }

        void receive_mail(string email, string password, string server)
        {
            using (ImapClient client = new ImapClient())
            {
                try
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect(server, 143, SecureSocketOptions.Auto);
                    client.Authenticate(email, password);

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    var uids = client.Inbox.Search(SearchQuery.All);

                    foreach (var uid in uids)
                    {
                        var message = inbox.GetMessage(uid);
                        // Process the received message
                        string subject = message.Subject;
                        string from = message.From.ToString();
                        string body = message.HtmlBody;
                        string time = message.Date.DateTime.ToString();

                        // Display or store the received information as need
                        ListViewItem name = new ListViewItem(subject);
                        // From
                        ListViewItem.ListViewSubItem fromView = new ListViewItem.ListViewSubItem(name, from);
                        name.SubItems.Add(fromView);
                        // Message
                        ListViewItem.ListViewSubItem content = new ListViewItem.ListViewSubItem(name, body);
                        name.SubItems.Add(content);
                        // Date
                        ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, time);
                        name.SubItems.Add(date);
                        listView1.Items.Add(name);
                    }

                    client.Disconnect(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                Program.address = addressBox.Text;
                Program.password = passwordBox.Text;
                listView1.Columns.Add("Email", 200);
                listView1.Columns.Add("From", 300);
                listView1.Columns.Add("Content", 400);
                listView1.Columns.Add("Time", 200);
                listView1.View = View.Details;
                receive_mail(Program.address, Program.password, "127.0.0.1");
                buttonSend.Enabled = true;
                buttonLogin.Text = "Reload";
                btn_logout.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var sendForm = new sendmail();
            sendForm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            try
            {
                addressBox.Clear();
                passwordBox.Clear();
                Program.address = null;
                Program.password = null;
                listView1.Items.Clear();
                listView1.Columns.Clear();
                buttonSend.Enabled = false;
                buttonLogin.Text = "Login";
                btn_logout.Enabled = false; // Disable the logout button when logged out
                MessageBox.Show("Logged out successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
