using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kino
{
    public partial class Parool : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        
        public Parool()
        {
            InitializeComponent();
        }

        private void valjaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jatkaBtn_Click(object sender, EventArgs e)
        {
            if (paroolBox.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from Parool where parol='" + paroolBox.Text + "'", cn);

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Close();
                    Admin admin= new Admin();
                    admin.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Vale parool ", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Parool_Load(object sender, EventArgs e)
        {
            paroolBox.PasswordChar = '*';
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vafle\Source\Repos\Kino\Kino\KinoDB.mdf;Integrated Security=True");
            cn.Open();
        }
    }
}
