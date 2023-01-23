using EASendMail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EASendMail;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Kino
{
    public partial class Email : Form
    {
        public static string mail;
        public static bool gotemail;
        public Email()
        {
            InitializeComponent();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            string emailstr = emailBox.Text;
            bool emailcheck = IsValidEmail(emailstr);
            if (emailcheck == true)
            {
                gotemail= true;
                mail = emailstr;
                this.Close();
            }
            else
            {
                gotemail = false;
                MessageBox.Show("Email on viga");
            }
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            gotemail = false;
            this.Close();
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
