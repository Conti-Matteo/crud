﻿using System;
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
        public string[] prodotto;
        public int dim;
        public Form1()
        {
            InitializeComponent();
            prodotto = new string[100];
            dim = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aggiunta(prodotto, ref dim, TextB1.Text, TextB2.Text);
            stampa(prodotto, ref dim, TextB1.Text, TextB2.Text);
        }
        //funzioni di servizio
        public void aggiunta(string[] prodoto, ref int dim, string nome, string prezzo)
        {
            prodotto[dim] = nome;
            dim++;
        }
        public void stampa(string[] prodotto, ref int dim, string nome, string prezzo)
        {
            this.listView1.Items.Add(nome +  " €" + prezzo);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}