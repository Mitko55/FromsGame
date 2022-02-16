using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igra
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Lostkid = new Form4();
            Lostkid.Show();
            this.Hide();
        }

        private void btntoForm5_Click(object sender, EventArgs e)
        {
            Form5 Lostkid = new Form5();
            Lostkid.Show();
            this.Hide();
        }
    }
}
