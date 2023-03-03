using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class Form1 : Form
    {
        public int dim;
        public struct struttura
        {
            public string[] prodotto;
            public string[] prezzo;
        }
        public static struttura Struttura = new struttura();
        public Form1()
        {
            InitializeComponent();
            Struttura.prodotto = new string[100];
            dim = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aggiunta(TextB1.Text, TextB2.Text);
            stampa();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int posizione = ricerca(TextB3.Text);
            if (posizione != -1)
            {
                modifica(TextB4.Text, textB5.Text, posizione);
                stampa();
                MessageBox.Show("il prodotto è stato trovato");
            }
            else
            {
                MessageBox.Show("il prodotto non è stato trovato");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        //funzioni di servizio
        public void aggiunta(string nome, string valore)
        {
            Struttura.prodotto[dim] = nome;
            Struttura.prezzo[dim] = valore;
            dim++;
        }
        public void stampa()
        {
            this.listView1.Items.Add(Struttura.prodotto[dim-1] + " €" + Struttura.prezzo[dim-1]);

        }
        public void modifica(string nome, string valore, int posizione)
        {
            Struttura.prodotto[posizione] = nome;
            Struttura.prezzo[posizione] = valore;
        }
        public int ricerca(string nome)
        {
            int pos;
            for(int i = 0; i < dim; i++)
            {
                if(Struttura.prodotto[i] == nome)
                {
                    pos = i;
                    return pos;
                }
            }
            pos = -1;
            return pos;
        }
    }
}
