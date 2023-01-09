using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Kino
{
    public partial class Admin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vafle\source\repos\Kino\Kino\KinoDB.mdf;Integrated Security=True");
        SqlDataAdapter adapter_filmid = new SqlDataAdapter();
        SqlCommand cmd;
        public Admin()
        {
            InitializeComponent();
            Naita_Andmed();
        }

        public void Naita_Andmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            //cmd = new SqlCommand("SELECT * FROM Toodetable");
            adapter_filmid = new SqlDataAdapter("SELECT * FROM Filmid", connect);
            adapter_filmid.Fill(dt_toode);
            dataGridView1.DataSource = dt_toode;


            filmiPlt.Image = Image.FromFile("../../ProjectImages/Info.jpg");
            filmiPlt.SizeMode = PictureBoxSizeMode.StretchImage;
            connect.Close();
            //Naita_Kategooria();

        }
        public void Kustuta_Andmed()
        {
            nimiBox.Text = "";
            aastaBox.Text = "";
            zanrBox.Text = "";
            keelBox.Text = "";
            kestusBox.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nimiBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            aastaBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            zanrBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            keelBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            kestusBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            try
            {
                filmiPlt.Image = Image.FromFile(@"..\..\MovieImages\" + dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            }
            catch (Exception)
            {
                filmiPlt.Image = Image.FromFile(@"..\..\images\Info.png");
                MessageBox.Show("Fail puudub");
            }
        }

        private void kustutaBtn_Click(object sender, EventArgs e)
        {

        }

        private void uuendaBtn_Click(object sender, EventArgs e)
        {

        }

        private void liisaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kas unustasite pildi valida?", "Hoiatus!",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                FileInfo info = new FileInfo(filmiPlt.ImageLocation.ToString());
                string pltnimi = info.Name;
                if (nimiBox.Text.Trim() != string.Empty && aastaBox.Text.Trim() != string.Empty &&
                    zanrBox.Text.Trim() != string.Empty && keelBox.Text.Trim() != string.Empty && kestusBox.Text.Trim() != string.Empty)
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO Filmid (Nimi,Aasta,Zanr,Keel,Kestus,Pilt)" +
                            " VALUES (@nimi,@aasta,@zanr,@keel,@kestus,@pilt)", connect); //@pilt, //Pilt
                        connect.Open();
                        cmd.Parameters.AddWithValue("@nimi", nimiBox.Text);
                        cmd.Parameters.AddWithValue("@aasta", aastaBox.Text);
                        cmd.Parameters.AddWithValue("@zanr", zanrBox.Text);
                        cmd.Parameters.AddWithValue("@keel", keelBox.Text);
                        cmd.Parameters.AddWithValue("@kestus", kestusBox.Text);
                        cmd.Parameters.AddWithValue("@pilt", pltnimi);
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        Kustuta_Andmed();
                        Naita_Andmed();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Andmeebaasi viga");
                    }
                }
                else
                {
                    MessageBox.Show("Sissesta korektselt andmeid");
                }
            }
        }

        private void piltBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
