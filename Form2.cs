using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int totalücret;
        int kolaa = 0;
        int kolaf = 10;
        int ayrana = 0;
        int ayranf = 5;
        int sodaa = 0;
        int sodaf = 5;
        int fantaa = 0; 
        int fantaf = 10;
        int gazoza = 0;
        int gazozf = 10;
        int meyvesa = 0;
        int meyvesf = 10;
        int sua = 0;
        int suf = 5;
        int hamburgera = 0;
        int hamburgerf = 30;
        int patatesa = 0;
        int patatesf = 20;
        int pizzaa = 0;
        int pizzaf = 40;
        int dönera = 0;
        int dönerf = 20;
        int pilava = 0;
        int pilavf = 20;
        int tosta = 0;
        int tostf = 10;
        int makarnaa = 0;
        int makarnaf = 10;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kolaa = int.Parse(label32.Text);
            kolaa++;
            label32.Text = kolaa.ToString();
            if (kolaa <= 0)
            {
                label32.Text = "0";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hamburgera = int.Parse(label17.Text);
            hamburgera++;
            label17.Text = hamburgera.ToString();
            if (hamburgera <= 0)
            {
                label17.Text = "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            kolaa = int.Parse(label32.Text);
            kolaa--;
            label32.Text = kolaa.ToString();
            if (kolaa <= 0)
            {
                label32.Text = "0";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            hamburgera = int.Parse(label17.Text);
            hamburgera--;
            label17.Text = hamburgera.ToString();
            if (hamburgera <= 0)
            {
                label17.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ayrana = int.Parse(label26.Text);
            ayrana++;
            label26.Text = ayrana.ToString();
            if (ayrana <= 0)
            {
                label26.Text = "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ayrana = int.Parse(label26.Text);
            ayrana--;
            label26.Text = ayrana.ToString();
            if (ayrana <= 0)
            {
                label26.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sodaa = int.Parse(label31.Text);
            sodaa++;
            label31.Text = sodaa.ToString();
            if (sodaa <= 0)
            {
                label31.Text = "0";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            sodaa = int.Parse(label31.Text);
            sodaa--;
            label31.Text = sodaa.ToString();
            if (sodaa <= 0)
            {
                label31.Text = "0";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fantaa = int.Parse(label30.Text);
            fantaa++;
            label30.Text = fantaa.ToString();
            if (fantaa <= 0)
            {
                label30.Text = "0";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gazoza = int.Parse(label29.Text);
            gazoza++;
            label29.Text = gazoza.ToString();
            if (gazoza <= 0)
            {
                label29.Text = "0";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            gazoza = int.Parse(label29.Text);
            gazoza--;
            label29.Text = gazoza.ToString();
            if (gazoza <= 0)
            {
                label29.Text = "0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            meyvesa = int.Parse(label27.Text);
            meyvesa++;
            label27.Text = meyvesa.ToString();
            if (meyvesa <= 0)
            {
                label27.Text = "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            meyvesa = int.Parse(label27.Text);
            meyvesa--;
            label27.Text = meyvesa.ToString();
            if (meyvesa <= 0)
            {
                label27.Text = "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sua = int.Parse(label28.Text);
            sua++;
            label28.Text = sua.ToString();
            if (sua <= 0)
            {
                label28.Text = "0";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sua = int.Parse(label28.Text);
            sua--;
            label28.Text = sua.ToString();
            if (sua <= 0)
            {
                label28.Text = "0";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            patatesa = int.Parse(label25.Text);
            patatesa++;
            label25.Text = patatesa.ToString();
            if (patatesa <= 0)
            {
                label25.Text = "0";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            patatesa = int.Parse(label25.Text);
            patatesa--;
            label25.Text = patatesa.ToString();
            if (patatesa <= 0)
            {
                label25.Text = "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pizzaa = int.Parse(label19.Text);
            pizzaa++;
            label19.Text = pizzaa.ToString();
            if (pizzaa <= 0)
            {
                label19.Text = "0";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            pizzaa = int.Parse(label19.Text);
            pizzaa--;
            label19.Text = pizzaa.ToString();
            if (pizzaa <= 0)
            {
                label19.Text = "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dönera = int.Parse(label20.Text);
            dönera++;
            label20.Text = dönera.ToString();
            if (dönera <= 0)
            {
                label20.Text = "0";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            dönera = int.Parse(label20.Text);
            dönera--;
            label20.Text = dönera.ToString();
            if (dönera <= 0)
            {
                label20.Text = "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pilava = int.Parse(label22.Text);
            pilava++;
            label22.Text = pilava.ToString();
            if (pilava <= 0)
            {
                label22.Text = "0";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            pilava = int.Parse(label22.Text);
            pilava--;
            label22.Text = pilava.ToString();
            if (pilava <= 0)
            {
                label22.Text = "0";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tosta = int.Parse(label24.Text);
            tosta++;
            label24.Text = tosta.ToString();
            if (tosta <= 0)
            {
                label24.Text = "0";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            tosta = int.Parse(label24.Text);
            tosta--;
            label24.Text = tosta.ToString();
            if (tosta <= 0)
            {
                label24.Text = "0";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            makarnaa = int.Parse(label23.Text);
            makarnaa++;
            label23.Text = makarnaa.ToString();
            if (makarnaa <= 0)
            {
                label23.Text = "0";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            makarnaa = int.Parse(label23.Text);
            makarnaa--;
            label23.Text = makarnaa.ToString();
            if (makarnaa <= 0)
            {
                label23.Text = "0";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            fantaa = int.Parse(label30.Text);
            fantaa--;
            label30.Text = fantaa.ToString();
            if (fantaa <= 0)
            {
                label30.Text = "0";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            // yiyecekler

            int ücret = hamburgerf * hamburgera;
            int ücret1 = patatesf * patatesa;
            int ücret2 = pizzaa * pizzaf;
            int ücret3 = dönera * dönerf;
            int ücret4 = pilava * pilavf;
            int ücret5 = tosta * tostf;
            int ücret6 = pilava * pilavf;

            // İçecekler

            int ücret7 = kolaa * kolaf;
            int ücret8 = sua * suf;
            int ücret9 = ayrana * ayranf;
            int ücret10 = fantaa * fantaf;
            int ücret11 = sodaa * sodaf;
            int ücret12 = meyvesa * meyvesf;
            int ücret13 = gazoza * gazozf;
            
            
            totalücret = ücret + ücret1 + ücret2 + ücret3 + ücret4 + ücret5 + ücret6 + ücret7 + ücret8 + ücret9 + ücret10 + ücret11 + ücret12 + ücret13;
            
            label33.Text = "Total Fiyat = " + totalücret.ToString();
        }
    }
}
