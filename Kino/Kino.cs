using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Kino()
        {
            this.Size = new Size(1280, 720);
            this.BackgroundImage = BckGroundPic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Text = "Kino";

            nimilbl = new Label()
            {
                Text = "nimi",
                Location= new Point(750,50)
                
            };
            this.Controls.Add(nimilbl);
            zanrlbl = new Label()
            {
                Text = "zanr",
                Location = new Point(750, 150)

            };
            this.Controls.Add(zanrlbl);
            aastalbl = new Label()
            {
                Text = "aasta",
                Location = new Point(750, 100)

            };
            this.Controls.Add(aastalbl);
            keellbl = new Label()
            {
                Text = "keel",
                Location = new Point(750, 200)

            };
            this.Controls.Add(keellbl);
            kestuslbl = new Label()
            {
                Text = "kestus",
                Location = new Point(750, 250)

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
                Size = new Size(75, 50),
                Location = new Point(900,380)
            };
            this.Controls.Add(exit);
            osta = new Button()
            {
                Text="Osta piletid",
                Size= new Size(75,50),
                Location = new Point(780,380)
            };
            this.Controls.Add(osta);


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


            int verg = 1; //column
            int rida = 0; //row
            string[] paths = Directory.GetFiles(@"C:\Users\vafle\source\repos\Kino\Kino\MovieImages\", "*.jpg");
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
            }

        }
    }
}
