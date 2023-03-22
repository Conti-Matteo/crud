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
        private void label8_Click(object sender, EventArgs e)
        {

        }
        #endregion 

        #region button
        private void button1_Click(object sender, EventArgs e)
        {
            aggiunta(textBox1.Text, float.Parse(textBox2.Text));
            stampa();
            textBox1.Text = "";
            textBox2.Text = "";
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
            textBox3.Text = textBox4.Text;
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int posizione = ricerca(textBox6.Text);

            if (posizione != -1)
            {
                cancella(posizione);

                stampa();

                MessageBox.Show("Elemento cancellato correttamente");
            }
            else
            {
                MessageBox.Show("L'elemento non esisteva, non è stato perciò possibile cancellarlo");
            }
            textBox3.Text = "";
            textBox6.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            pTot();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            sconto(int.Parse(textBox7.Text));
            stampa();
            textBox7.Text = "";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            sconto(-int.Parse(textBox7.Text));
            stampa();
            textBox7.Text = "";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            costoMag();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            costoMin();
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
        private void textBox7_TextChanged(object sender, EventArgs e)
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
            for (int i = 0; i < dim; i++)
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
            for (int i = 0; i < dim; i++)
            {
                if (Struttura[i].nome == prod)
                {
                    pos = i;
                    return pos;
                }
            }
            pos = -1;
            return pos;
        }
        #endregion

        #region cancella
        public void cancella(int posizione)
        {
            for (int i = posizione; i < dim; i++)
            {
                Struttura[i].nome = Struttura[i + 1].nome;
                Struttura[i].prezzo = Struttura[i + 1].prezzo;
            }
            dim--;
        }
        #endregion

        #region pTot
        public void pTot()
        {
            float p = 0;
            for (int i = 0; i < dim; i++)
            {
                p += Struttura[i].prezzo;
            }
            listView1.Items.Add("spesa totale: €" + p);
        }
        #endregion

        #region sconto
        public void sconto(int sconto)
        {
            for (int i = 0; i < dim; i++)
            {
                float p = Struttura[i].prezzo + (Struttura[i].prezzo / 100 * sconto);
                Struttura[i].prezzo = p;
            }
        }
        #endregion

        #region costoMag
        public void costoMag()
        {
            string prodMag = Struttura[0].nome;
            float prodMag2 = Struttura[0].prezzo;
            for (int i = 0; i < dim; i++)
            {
                if (prodMag2 < Struttura[i].prezzo)
                {
                    prodMag = Struttura[i].nome;
                    prodMag2 = Struttura[i].prezzo;
                }
            }
            MessageBox.Show("Il prodotto più costoso è: " + prodMag);
        }
        #endregion

        #region costoMin
        public void costoMin()
        {
            string prodMin = Struttura[0].nome;
            float prodMin2 = Struttura[0].prezzo;
            for (int i = 0; i < dim; i++)
            {
                if (prodMin2 > Struttura[i].prezzo)
                {
                    prodMin = Struttura[i].nome;
                    prodMin2 = Struttura[i].prezzo;
                }
            }
            MessageBox.Show("Il prodotto meno costoso è: " + prodMin);
            #endregion
        }
    }
}