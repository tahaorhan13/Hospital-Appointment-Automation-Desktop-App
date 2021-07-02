using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Randevu_Projesi.Forms
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {            
            Login frm = new Login();
            frm.Show();
        }

        private void btnCalisan_Click(object sender, EventArgs e)
        {
            
            WorkerLogin frm = new WorkerLogin();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
