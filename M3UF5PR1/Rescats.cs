using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M03UF5PR1.Models.DTOs;
using M03UF5PR1.Persistence.Mapping;

namespace M03UF5PR1
{
    public partial class Rescats : Form
    {
        public Rescats()
        {
            InitializeComponent();
        }

        /* Botó enrere */
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /* Botó Seleccionar */
        private void button2_Click(object sender, EventArgs e)
        {
            if (!comboBox1.Items.Contains(comboBox1.SelectedItem))
            {
                errorComboBox.SetError(comboBox1, "Selecciona una opció vàlida");
                return;
            }
            else if (comboBox1.SelectedItem == null)
            {
                errorComboBox.SetError(comboBox1, "Selecciona una opció");
                return;
            }
            else
            {
                errorComboBox.Clear();
            }

            RescatDAO rescatDAO = new RescatDAO();
            RescatDTO rescat = new RescatDTO();
            rescat = rescatDAO.GetRescueById(int.Parse(comboBox1.Text));

            rescueNum.Text = rescat.NumRescat;
            rescueDate.Text = rescat.DataRescat.ToString();
            animalID.Text = rescat.Animal.Id.ToString();
            grauAfectacio.Text = rescat.GA.ToString();
            location.Text = rescat.Localitzacio;
        }

        /* Carregar formulari */
        private void Rescats_Load(object sender, EventArgs e)
        {
            RescatDAO rescatDAO = new RescatDAO();
            dataGridView1.DataSource = rescatDAO.GetAllRescue();

            List<int> ints = rescatDAO.GetAllIds();
            foreach (int i in ints)
            {
                comboBox1.Items.Add(i);
            }
        }
    }
}
