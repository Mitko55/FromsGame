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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Lostkid = new Form2();
            Lostkid.Show();
            this.Hide();
        }

        private void imgKid_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 Lostkid = new Form3();
            Lostkid.Show();
            this.Hide();
        }

        private void imgKid_Click_1(object sender, EventArgs e)
        {

        }
    }
}
