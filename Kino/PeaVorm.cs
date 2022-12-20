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
    public partial class PeaVorm : Form
    {
        public PeaVorm()
        {
            InitializeComponent();
        }

        private void FilmiBtn_Click(object sender, EventArgs e)
        {
            Kino kino = new Kino();
            kino.ShowDialog();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            Parool parol= new Parool();
            parol.ShowDialog();
        }
    }
}
