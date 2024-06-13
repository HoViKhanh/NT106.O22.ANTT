using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class _3 : Form
    {
        public _3()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure all required fields are filled
                if (string.IsNullOrEmpty(fromTB.Text) ||
                    string.IsNullOrEmpty(pwdTB.Text) ||
                    string.IsNullOrEmpty(toTB.Text) ||
                    string.IsNullOrEmpty(subTB.Text) ||
                    string.IsNullOrEmpty(bodyTB.Text))
                {
                    MessageBox.Show("Please fill in all fields before sending the email.");
                    return;
                }

                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(fromTB.Text, pwdTB.Text); // Use app password here
                    client.EnableSsl = true;

                    using (MailMessage msg = new MailMessage())
                    {
                        MailAddress from = new MailAddress(fromTB.Text);
                        MailAddress to = new MailAddress(toTB.Text);

                        msg.From = from;
                        msg.To.Add(to);
                        msg.Subject = subTB.Text;
                        msg.Body = bodyTB.Text;

                        if (!string.IsNullOrEmpty(attachTB.Text))
                        {
                            foreach (string file in attachTB.Text.Split(';'))
                            {
                                msg.Attachments.Add(new Attachment(file));
                            }
                        }

                        client.Send(msg);
                        MessageBox.Show("Email sent successfully!");
                    }
                }
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show("SMTP error: " + smtpEx.Message);
                Console.WriteLine("SMTP error: " + smtpEx);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show("Invalid email format: " + formatEx.Message);
                Console.WriteLine("Invalid email format: " + formatEx);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
                Console.WriteLine("An unexpected error occurred: " + ex);
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog
            {
                Filter = "All Files (*.*)|*.*",
                FilterIndex = 1,
                Multiselect = true
            };

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                attachTB.Text = string.Join(";", choofdlog.FileNames);
            }
        }
    }
}
