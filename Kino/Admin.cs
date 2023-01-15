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
        FileDialog piltValiDialog;
        SaveFileDialog saveValiDialog;
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
                filmiPlt.Image = Image.FromFile(@"..\..\ProjectImages\Info.jpg");
                MessageBox.Show("Fail puudub");
            }
        }

        private void kustutaBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            string sql = "DELETE FROM Filmid WHERE Id = @rowID";

            using (SqlCommand deletedRecord = new SqlCommand(sql, connect))
            {
                connect.Open();
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int rowId = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);
                deletedRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowId;
                deletedRecord.ExecuteNonQuery();

                dataGridView1.Rows.RemoveAt(selectedIndex);
                connect.Close();
            }
        }
        int Id;
        private void uuendaBtn_Click(object sender, EventArgs e)
        {
            if (nimiBox.Text != "" && aastaBox.Text != "" &&
                zanrBox.Text != "" && keelBox.Text != "" && kestusBox.Text != "") //&& filmiPlt.Image != null
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Filmid SET Nimi=@nimi,Aasta=@aasta,Zanr=@zanr,Keel=@keel,Kestus=@Kestus WHERE Id=@id", connect); //,Pilt = @pilt
                    connect.Open();
                    cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows.Count);
                    cmd.Parameters.AddWithValue("@nimi", nimiBox.Text);
                    cmd.Parameters.AddWithValue("@aasta", aastaBox.Text);
                    cmd.Parameters.AddWithValue("@zanr", zanrBox.Text);
                    cmd.Parameters.AddWithValue("@keel", keelBox.Text);
                    cmd.Parameters.AddWithValue("@kestus", kestusBox.Text);

                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Naita_Andmed();
                    Kustuta_Andmed();
                    MessageBox.Show("Andmed uuendatud");
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmeebaasi viga");
                }
            }
            else
            {
                MessageBox.Show("Sissesta andmeid");
            }
        }

        private void liisaBtn_Click(object sender, EventArgs e)
        {
                if (nimiBox.Text.Trim() != string.Empty && aastaBox.Text.Trim() != string.Empty &&
                    zanrBox.Text.Trim() != string.Empty && keelBox.Text.Trim() != string.Empty && kestusBox.Text.Trim() != string.Empty)
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT INTO Filmid (Nimi,Aasta,Zanr,Keel,Kestus)" +
                            " VALUES (@nimi,@aasta,@zanr,@keel,@kestus)", connect); //@pilt, //Pilt
                        connect.Open();
                        cmd.Parameters.AddWithValue("@nimi", nimiBox.Text);
                        cmd.Parameters.AddWithValue("@aasta", aastaBox.Text);
                        cmd.Parameters.AddWithValue("@zanr", zanrBox.Text);
                        cmd.Parameters.AddWithValue("@keel", keelBox.Text);
                        cmd.Parameters.AddWithValue("@kestus", kestusBox.Text);
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

        private void piltBtn_Click(object sender, EventArgs e)
        {
            piltValiDialog = new OpenFileDialog();
            cmd = new SqlCommand("UPDATE Filmid SET Pilt=@pilt WHERE Nimi=@nimi", connect);

            piltValiDialog.InitialDirectory = @"D:\Downloads";
            piltValiDialog.Filter = "Image Files(*.jpg)|*.jpg";
            FileInfo open_info = new FileInfo(@"D:\Downloads\" + piltValiDialog.FileName);
            if (piltValiDialog.ShowDialog() == DialogResult.OK && nimiBox != null)
            {
                saveValiDialog = new SaveFileDialog();
                saveValiDialog.InitialDirectory = Path.GetFullPath(@"..\..\MovieImages");
                saveValiDialog.FileName = nimiBox.Text + Path.GetExtension(piltValiDialog.FileName); //".jpg";            
                saveValiDialog.Filter = "Image Files" + Path.GetExtension(piltValiDialog.FileName) + "|" + Path.GetExtension(piltValiDialog.FileName);
                connect.Open();
                cmd.Parameters.AddWithValue("@nimi", nimiBox.Text);
                cmd.Parameters.AddWithValue("@pilt", saveValiDialog.FileName);
                cmd.ExecuteNonQuery();
                connect.Close();


                if (saveValiDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(piltValiDialog.FileName, saveValiDialog.FileName);
                    saveValiDialog.RestoreDirectory = true;
                    filmiPlt.Image = Image.FromFile(saveValiDialog.FileName);
                }
            }
        }




        private void nimiBox_Enter(object sender, EventArgs e)
        {
            TextBox textSender = (TextBox)sender;
            if (textSender.Text == "Nimi")
            {
                textSender.ForeColor = Color.Black;
                textSender.Text = "";
            }
        }

        private void nimiBox_Leave(object sender, EventArgs e)
        {
            TextBox textSender = (TextBox)sender;
            if (textSender.Text.Length == 0)
            {
                textSender.ForeColor = Color.Black;
                textSender.Text = "Nimi";
            }
        }

        private void aastaBox_Leave(object sender, EventArgs e)
        {
            TextBox textSender = (TextBox)sender;
            if (textSender.Text.Length == 0)
            {
                textSender.ForeColor = Color.Black;
                textSender.Text = "Aasta";
            }
        }

        private void aastaBox_Enter(object sender, EventArgs e)
        {
            TextBox textSender = (TextBox)sender;
            if (textSender.Text == "Aasta")
            {
                textSender.ForeColor = Color.Black;
                textSender.Text = "";
            }
        }

        private void zanrBox_Leave(object sender, EventArgs e)
        {
            TextBox textSender = (TextBox)sender;
            if (textSender.Text.Length == 0)
            {
                textSender.ForeColor = Color.Black;
                textSender.Text = "Zanr";
            }
        }

        private void keelBox_Leave(object sender, EventArgs e)
        {
            TextBox textSender = (TextBox)sender;
            if (textSender.Text.Length == 0)
            {
                textSender.ForeColor = Color.Black;
                textSender.Text = "Keel";
            }
        }

        private void kestusBox_Leave(object sender, EventArgs e)
        {
            TextBox textSender = (TextBox)sender;
            if (textSender.Text.Length == 0)
            {
                textSender.ForeColor = Color.Black;
                textSender.Text = "Kestus";
            }
        }

        private void zanrBox_Enter(object sender, EventArgs e)
        {
            TextBox textSender = (TextBox)sender;
            if (textSender.Text == "Zanr")
            {
                textSender.ForeColor = Color.Black;
                textSender.Text = "";
            }
        }

        private void keelBox_Enter(object sender, EventArgs e)
        {
            TextBox textSender = (TextBox)sender;
            if (textSender.Text == "Keel")
            {
                textSender.ForeColor = Color.Black;
                textSender.Text = "";
            }
        }

        private void kestusBox_Enter(object sender, EventArgs e)
        {
            TextBox textSender = (TextBox)sender;
            if (textSender.Text == "Kestus")
            {
                textSender.ForeColor = Color.Black;
                textSender.Text = "";
            }
        }
    }
}
