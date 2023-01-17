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

namespace Kino
{
    public partial class Saal : Form
    {
        //TableLayoutPanel saal;
        Button koht;
        Button osta;
        List<Button> kohtList = new List<Button>();
        SqlCommand cmd;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vafle\Source\Repos\Kino\Kino\KinoDB.mdf;Integrated Security=True");

        public Saal()
        {
            this.Size = new Size(800, 600);
            this.AutoScroll= true;

            Kohad(10, 10);
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
                    kohtList.Add(koht);
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
