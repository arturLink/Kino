using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class Kino : Form
    {
        Button exit, osta;
        Label nimilbl,zanrlbl,aastalbl,keellbl, kestuslbl;
        PictureBox film,filmbox;
        TableLayoutPanel FilmPanel = new TableLayoutPanel();
        Image BckGroundPic = Image.FromFile("../../ProjectImages/theater.jpg");
        Image PanelFramePic = Image.FromFile("../../ProjectImages/frame.jpg");

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Link_TARpv21\Kino\Kino\KinoDB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter dataAdapter;

        public Kino()
        {
            this.Size = new Size(1280, 720);
            this.BackgroundImage = BckGroundPic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Text = "Kino";

            nimilbl = new Label()
            {
                Text = "nimi",
                Location= new Point(750,70),
                BackColor = System.Drawing.Color.Salmon,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F),

        };
            this.Controls.Add(nimilbl);
            zanrlbl = new Label()
            {
                Text = "zanr",
                Location = new Point(750, 170),
                BackColor = System.Drawing.Color.Salmon,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F),

            };
            this.Controls.Add(zanrlbl);
            aastalbl = new Label()
            {
                Text = "aasta",
                Location = new Point(750, 120),
                BackColor = System.Drawing.Color.Salmon,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F),

            };
            this.Controls.Add(aastalbl);
            keellbl = new Label()
            {
                Text = "keel",
                Location = new Point(750, 220),
                BackColor = System.Drawing.Color.Salmon,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F),

            };
            this.Controls.Add(keellbl);
            kestuslbl = new Label()
            {
                Text = "kestus",
                Location = new Point(750, 270),
                BackColor = System.Drawing.Color.Salmon,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F),

            };
            this.Controls.Add(kestuslbl);

            filmbox = new PictureBox()
            {
                Location = new Point(900,50),
                Size = new Size(320,250)
            };
            this.Controls.Add(filmbox);
            exit = new Button()
            {
                Text = "Väljuta",
                Size = new Size(125, 75),
                Location = new Point(1050,340),
                BackColor = System.Drawing.Color.Salmon,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F),
            };
            this.Controls.Add(exit);
            exit.Click += Exit_Click;
            osta = new Button()
            {
                Text="Osta piletid",
                Size= new Size(125,75),
                Location = new Point(780,340),
                BackColor = System.Drawing.Color.Salmon,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F),
            };
            this.Controls.Add(osta);
            osta.Click += Osta_Click;


            FilmPanel = new TableLayoutPanel()
            {
                BackgroundImage = PanelFramePic,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                ColumnCount = 6,
                Location = new System.Drawing.Point(12, 12),
                Name = "FilmPanel",
                RowCount = 5,
                Size = new System.Drawing.Size(701, 657),
                TabIndex = 0
            };
            this.FilmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.20833F));
            this.FilmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.79166F));
            this.FilmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.FilmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.FilmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.FilmPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));

            this.FilmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.55204F));
            this.FilmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.44797F));
            this.FilmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.FilmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.FilmPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.Controls.Add(this.FilmPanel);
            //FilmPanel.Click += FilmPanel_Click;


            int verg = 1; //column
            int rida = 0; //row
            string[] paths = Directory.GetFiles(@"C:\Users\opilane\source\repos\Link_TARpv21\Kino\Kino\MovieImages\", "*.jpg");
            List<string> images = paths.ToList();
            for (int i = 0; i < images.Count; i++)
            {
                film = new PictureBox()
                {
                    BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                    //Dock = System.Windows.Forms.DockStyle.Fill,
                    //Location = new System.Drawing.Point(2, 2),
                    Size = new System.Drawing.Size(140, 200),
                    TabIndex = 0,
                    TabStop = false
                    

                };
                film.SizeMode = PictureBoxSizeMode.StretchImage;
                film.ImageLocation = paths[i];
                rida++;
                if (rida == 4)
                {
                    verg++;
                    rida = 1;
                }
                FilmPanel.Controls.Add(film, verg, rida);
                film.Click += Film_Click;
            }

        }
        //dorabotat nado -- select,i vivod danih 4eres kartinku
        private void Film_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            var filmidDB = new List<string>();
            //string filmNimi;
            FileInfo info = new FileInfo(pic.ImageLocation.ToString());
            string nimi = info.Name;
            //string pilt = film.ImageLocation.ToString();
            connect.Open();
            dataAdapter = new SqlDataAdapter("SELECT Nimi FROM Filmid WHERE Pilt=" + nimi, connect);
            DataTable piltTable = new DataTable();
            dataAdapter.Fill(piltTable);
            foreach (DataRow nimetus in piltTable.Rows)
            {
                MessageBox.Show("22");
                //filmidDB.Add(nimetus["Nimi"]);
                nimilbl.Text = nimetus["Nimi"].ToString();
                //katBox.Items.Add(nimetus["KategooriaNimetus"]);
            }
            //cmd = new SqlCommand("SELECT Nimi FROM Filmid WHERE Pilt=" + nimi, connect);
            //dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    dr.Close();
            //    filmidDB.Add(dr.GetString(0));
            //    MessageBox.Show(dr.GetString(0));
            //}
            //else
            //{
            //    MessageBox.Show("ssss");
            //}
            connect.Close();
        }


        private void Osta_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
