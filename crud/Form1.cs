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
        public struct Prodotto
        {
            public string nome;
            public float prezzo;
        }

        public static Prodotto[] Struttura;
        public Form1()
        {
            InitializeComponent();
            Struttura = new Prodotto[100];
            dim = 0;
        }
        #region Form
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region label
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        #endregion 

        #region button
        private void button1_Click(object sender, EventArgs e)
        {
            aggiunta(textBox1.Text, float.Parse(textBox2.Text));
            stampa();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int posizione = ricerca(textBox3.Text);
            if (posizione != -1)
            {
                MessageBox.Show("il prodotto è stato trovato");
            }
            else
            {
                MessageBox.Show("il prodotto non è stato trovato");
            }

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            int posizione = ricerca(textBox3.Text);
            modifica(textBox4.Text, float.Parse(textBox5.Text), posizione);
            stampa();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region TextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region ListView
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        //funzioni di servizio
        #region aggiunta
        public void aggiunta(string prod, float valore)
        {
            Struttura[dim].nome = prod;
            Struttura[dim].prezzo = valore;
            dim++;
        }
        #endregion

        #region stampa
        public void stampa()
        {
            listView1.Items.Clear();
            for(int i = 0; i < dim; i++)
            {
                listView1.Items.Add(Struttura[i].nome + " €" + Struttura[i].prezzo);
            }
        }
        #endregion

        #region modifica
        public void modifica(string prod, float valore, int posizione)
        {
            Struttura[posizione].nome = prod;
            Struttura[posizione].prezzo = valore;
        }
        #endregion

        #region ricerca
        public int ricerca(string prod)
        {
            int pos;
            for(int i = 0; i < dim; i++)
            {
                if(Struttura[i].nome == prod)
                {
                    pos = i;
                    return pos;
                }
            }
            pos = -1;
            return pos;
        }
        #endregion


    }
}