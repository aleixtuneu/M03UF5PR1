using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M03UF5PR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Botó TANCAR */
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Botó NOU RESCAT */
        private void button2_Click(object sender, EventArgs e)
        {
            RescatForm rescatForm = new RescatForm();
            rescatForm.Show();
            Hide();
        }

        /* Botó RANQUING */
        private void button3_Click(object sender, EventArgs e)
        {
            Ranquing ranquing = new Ranquing();
            ranquing.Show();
            Hide();
        }

        /* Botó GESTIÓ */
        private void button4_Click(object sender, EventArgs e)
        {
            GestioForm gestioForm = new GestioForm();
            gestioForm.Show();
            Hide();
        }

        /* Botó RESCATS */
        private void button5_Click(object sender, EventArgs e)
        {
            Rescats rescats = new Rescats();
            rescats.Show();
            Hide();
        }
    }
}
