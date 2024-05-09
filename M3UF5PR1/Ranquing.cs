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
using System.Xml;

namespace M03UF5PR1
{
    public partial class Ranquing : Form
    {
        public Ranquing()
        {
            InitializeComponent();
        }

        /* Carregar */
        private void Ranquing_Load(object sender, EventArgs e)
        {
            XMLHelper xmlHelper = new XMLHelper();
            List<PersonaDTO> persones = xmlHelper.GetPeople();

            dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn columnaId = new DataGridViewTextBoxColumn();
            columnaId.HeaderText = "ID";
            columnaId.DataPropertyName = "Id";
            dataGridView1.Columns.Add(columnaId);

            DataGridViewTextBoxColumn columnaNom = new DataGridViewTextBoxColumn();
            columnaNom.HeaderText = "Nom";
            columnaNom.DataPropertyName = "Nom";
            dataGridView1.Columns.Add(columnaNom);

            DataGridViewTextBoxColumn columnaOfici = new DataGridViewTextBoxColumn();
            columnaOfici.HeaderText = "Ofici";
            columnaOfici.DataPropertyName = "Ofici";
            dataGridView1.Columns.Add(columnaOfici);

            DataGridViewTextBoxColumn columnaXp = new DataGridViewTextBoxColumn();
            columnaXp.HeaderText = "XP";
            columnaXp.DataPropertyName = "XP";
            dataGridView1.Columns.Add(columnaXp);

            DataGridViewTextBoxColumn columnaNumRescat = new DataGridViewTextBoxColumn();
            columnaNumRescat.HeaderText = "Numero Rescat";
            columnaNumRescat.DataPropertyName = "NumRescat";
            dataGridView1.Columns.Add(columnaNumRescat);

            dataGridView1.DataSource = persones;
        }

        /* Botó enrere */
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
