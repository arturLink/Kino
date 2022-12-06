using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class Saal : Form
    {
        //TableLayoutPanel saal;
        Button koht;


        public Saal()
        {
            this.Size = new Size(800, 600);
            this.AutoScroll= true;

            //this.saal = new TableLayoutPanel();
            //this.saal.ColumnCount = 10;
            //this.saal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            //this.saal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            //this.saal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            //this.saal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            //this.saal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            //this.saal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            //this.saal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            //this.saal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            //this.saal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            //this.saal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999999F));
            //this.saal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            //this.saal.Location = new System.Drawing.Point(12, 12);
            //this.saal.Name = "kohad";
            //this.saal.RowCount = 6;
            //this.saal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            //this.saal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            //this.saal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            //this.saal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            //this.saal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            //this.saal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            //this.saal.Size = new System.Drawing.Size(760, 459);
            //this.saal.TabIndex = 0;
            //this.saal.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            //this.Controls.Add(this.saal);

            Kohad(20, 10);

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
                    koht = new Button()
                    {
                        Text = i.ToString() + a.ToString(),
                        BackgroundImage = Image.FromFile("../../ProjectImages/roheline.jpg"),
                        BackColor= Color.DarkGreen,
                        Size= new Size(60,60)
                    };
                    saal.Controls.Add(koht,a,i);
                    koht.Click += new EventHandler(Koht_Click);
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
            }
            else if (klik.BackColor == Color.Yellow)
            {
                klik.BackgroundImage = Image.FromFile("../../ProjectImages/roheline.jpg");
                klik.BackColor = Color.DarkGreen;
            }
            else
            {
                MessageBox.Show("UGABUGA");
            }
        }
    }
}
