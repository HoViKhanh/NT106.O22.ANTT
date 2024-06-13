using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MimeKit;
using MailKit;
using MailKit.Search;
using MailKit.Net.Imap;
using MailKit.Security;

namespace WindowsFormsApp1
{
    public partial class _2 : Form
    {
        public _2()
        {
            InitializeComponent();
        }

        private ImapClient imapClient;

        private void loginBtn_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect("127.0.0.1", 143, SecureSocketOptions.None);

                    client.Authenticate(emailTB.Text.Trim(), pwdTB.Text.Trim());

                    // The Inbox folder is always available on all IMAP servers...
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    totalLabel.Text = inbox.Count.ToString();
                    recentLabel.Text = inbox.Recent.ToString();

                    listView1.Columns.Add("Email", 200);
                    listView1.Columns.Add("From", 100);
                    listView1.Columns.Add("Thời gian", 100);
                    listView1.View = View.Details;
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem name = new ListViewItem(message.Subject);
                        ListViewItem.ListViewSubItem from = new
                        ListViewItem.ListViewSubItem(name, message.From.ToString());
                        name.SubItems.Add(from);
                        ListViewItem.ListViewSubItem date = new
                        ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                        name.SubItems.Add(date);
                        listView1.Items.Add(name);
                    }

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
