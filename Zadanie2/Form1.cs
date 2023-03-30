using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2
{
    public partial class Form1 : Form
    {
        double kgNaMarsie = 0.377;
        double kgNaJowiszu = 2.528;
        double kgNaKsiężycu = 0.166;
        double wagaNaZiemi;
        double wynik;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMars_Click(object sender, EventArgs e)
        {
            wagaNaZiemi = double.Parse(textBox1.Text);
            wynik = wagaNaZiemi * kgNaMarsie;
            label2.Text = $"Na Marsie to waży {wynik} kg";
        }

        private void buttonJowisz_Click(object sender, EventArgs e)
        {

        }

        private void buttonKsiężyc_Click(object sender, EventArgs e)
        {

        }
    }
}
