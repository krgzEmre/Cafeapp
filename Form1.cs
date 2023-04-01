using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            this.Hide();
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn1.ForeColor = Color.Black;
            btn2.ForeColor = Color.Black;
            btn3.ForeColor = Color.Black;
            btn4.ForeColor = Color.Black;
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btn1.BackColor = Color.Black;
            btn2.BackColor = Color.Black;
            btn3.BackColor = Color.Black;
            btn4.BackColor = Color.Black;
            btn1.ForeColor = Color.White;
            btn2.ForeColor = Color.White;
            btn3.ForeColor = Color.White;
            btn4.ForeColor = Color.White;
        }

        private void cıkısToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Çıkış yapılsın mı ? ", "Çıkış", MessageBoxButtons.YesNoCancel);
            if (result2 == DialogResult.Yes)
            {

            }
            else if (result2 == DialogResult.No)
            {

            }
            else if (result2 == DialogResult.Cancel)
            {

            }
        }
    }
}
