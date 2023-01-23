using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EASendMail;

namespace Kino
{
    public partial class Saal : Form
    {
        //TableLayoutPanel saal;
        Button koht;
        Button osta,exit;
        List<Button> kohtList = new List<Button>();
        public List<String> kohtNumList = new List<String>();
        SqlDataReader dr;
        SqlCommand cmd;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vafle\Source\Repos\Kino\Kino\KinoDB.mdf;Integrated Security=True");

        public Saal()
        {
            this.Size = new Size(1000, 600);
            this.AutoScroll= true;

            Kohad(10, 10);
            osta = new Button()
            {
                Text = "Osta piletid",
                Size = new Size(125, 75),
                Location = new Point(780, 80),
                BackColor = System.Drawing.Color.Green,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F),
            };
            this.Controls.Add(osta);
            osta.Click += Osta_Click;
            exit = new Button()
            {
                Text = "Väljuta",
                Size = new Size(125, 75),
                Location = new Point(780, 180),
                BackColor = System.Drawing.Color.Red,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F),
            };
            this.Controls.Add(exit);
            exit.Click += Exit_Click;
        }

        private void Osta_Click(object sender, EventArgs e)
        {
            Email mail = new Email();
            mail.ShowDialog();
            if (Email.gotemail == true)
            {
                SmtpMail oMail = new SmtpMail("TryIt");
                oMail.From = "arturlink04@gmail.com";
                oMail.To = Email.mail;
                oMail.Subject = "Kino";
                oMail.TextBody = "Sinu kohad: ";

                SmtpServer oServer = new SmtpServer("smtp.gmail.com");
                oServer.User = "arturlink04@gmail.com";
                oServer.Password = "nddbiaboivqmrwkt"; //\r\n
                oServer.Port = 587;
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;


                foreach (string ostudKoha in kohtNumList)
                {
                    oMail.TextBody += ostudKoha + ", ";
                    connect.Open();
                    cmd = new SqlCommand("UPDATE Kohad SET Vaba='-' WHERE Id=" + ostudKoha, connect);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                }

                SmtpClient oSmtp = new SmtpClient();
                oSmtp.SendMail(oServer, oMail);

                MessageBox.Show("Pilet on ostud");
            }
            else if (Email.gotemail == false)
            {
                MessageBox.Show("Pilet ostmata");
            }

            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Kohad(int kuipaljurideid, int kuipaljukohad)
        {
            TableLayoutPanel saal = new TableLayoutPanel();
            saal.AutoSize = true;
            saal.ColumnCount= kuipaljukohad;
            saal.RowCount= kuipaljurideid;
            saal.Location = new Point(60, 20);
            for (int i = 0; i < kuipaljurideid; i++)
            {
                for (int a = 0; a < kuipaljukohad; a++)
                {
                    connect.Open();
                    cmd = new SqlCommand("SELECT Vaba FROM Kohad WHERE Id="+i.ToString()+a.ToString(),connect);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        if (dr.GetString(0) == "+")
                        {
                            koht = new Button()
                            {
                                Text = i.ToString() + a.ToString(),
                                BackgroundImage = Image.FromFile("../../ProjectImages/roheline.jpg"),
                                BackColor = Color.DarkGreen,
                                Size = new Size(60, 60)
                            };
                            saal.Controls.Add(koht, a, i);
                            koht.Click += new EventHandler(Koht_Click);
                            kohtList.Add(koht);
                        }

                        else if (dr.GetString(0) == "-")
                        {
                            koht = new Button()
                            {
                                Text = i.ToString() + a.ToString(),
                                BackgroundImage = Image.FromFile("../../ProjectImages/punane.jpg"),
                                BackColor = Color.Red,
                                Size = new Size(60, 60)
                            };
                            saal.Controls.Add(koht, a, i);
                            koht.Click += new EventHandler(Koht_Click);
                            kohtList.Add(koht);
                        }
                        dr.Close();
                    }
                    connect.Close();

                }
                this.Controls.Add(saal);
            }
            this.Controls.Add(saal);
        }

        private void Koht_Click(object sender, EventArgs e)
        {
            Button klik = sender as Button;
            if (klik.BackColor == Color.DarkGreen)
            {
                klik.BackgroundImage = Image.FromFile("../../ProjectImages/kollane.jpg");
                klik.BackColor= Color.Yellow;
                kohtNumList.Add(klik.Text);
            }
            else if (klik.BackColor == Color.Yellow)
            {
                klik.BackgroundImage = Image.FromFile("../../ProjectImages/roheline.jpg");
                klik.BackColor = Color.DarkGreen;
                kohtNumList.Remove(klik.Text);
            }
            else
            {
                MessageBox.Show("Seda koht on hõivatud");
            }
        }
    }
}
