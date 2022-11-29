using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class Kino : Form
    {
        PictureBox film;
        TableLayoutPanel FilmPanel = new TableLayoutPanel();
        Image BckGroundPic = Image.FromFile("../../ProjectImages/theater.jpg");
        Image PanelFramePic = Image.FromFile("../../ProjectImages/frame.jpg");

        public Kino()
        {
            this.Size = new Size(1280, 720);
            this.BackgroundImage = BckGroundPic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;



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

        }
    }
}
