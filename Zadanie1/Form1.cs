using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //przechwytywanie danych od usera
            int ocenaMatematyka = int.Parse(textBox1.Text);
            int ocenaPolski = int.Parse(textBox2.Text);
            int ocenaFizyka = int.Parse(textBox3.Text);
            int ocenaAngielski = int.Parse(textBox4.Text);
            int ocenaInformatyka = int.Parse(textBox5.Text);

            //obliczenia
            int sumaOcen = ocenaMatematyka + ocenaPolski + ocenaFizyka + ocenaAngielski + ocenaFizyka;
            double srednia = (double)sumaOcen / 5;  // int / int = int
             //rzutowanie to szybka zmiana typu

            //przykład - można wykonać konwersję z int do double ale usunie to część ułamkową
            int srednia2 = (int)srednia;

            //wypisanie wyniku
            textBox6.Text = srednia.ToString();
        }
    }
}
