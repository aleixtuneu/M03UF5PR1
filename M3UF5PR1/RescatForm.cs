using M03UF5PR1.Models.DTOs;
using M03UF5PR1.Persistence.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M03UF5PR1
{
    public partial class RescatForm : Form
    {
        public RescatForm()
        {
            InitializeComponent();
        }

        /* Botó RESCATAR */
        private void button1_Click_1(object sender, EventArgs e)
        {
            Regex name = new Regex(@"^[a-zA-Z\s]+$");
            if (comboBox1.SelectedItem == null)
            {
                errorOfici.SetError(comboBox1, "Selecciona un ofici");
                return;
            }
            else if (!comboBox1.Items.Contains(comboBox1.SelectedItem))
            {
                errorOfici.SetError(comboBox1, "Select un ofici vàlid");
                return;
            }
            else
            {
                errorOfici.Clear();
            }

            if (textBox1.Text == "")
            {
                errorNom.SetError(textBox1, "Introdueix un nom");
                return;
            }
            else if (!name.IsMatch(textBox1.Text))
            {
                errorNom.SetError(textBox1, "Només es poden introduïr lletres");
                return;
            }
            else
            {
                errorNom.Clear();
            }

            PersonaDTO persona = new PersonaDTO();
            persona.Nom = textBox1.Text;
            persona.Ofici = comboBox1.SelectedItem.ToString();
            if (persona.Ofici == "Veterinari")
            {
                persona.XP = 80;
            }
            else
            {
                persona.XP = 45;
            }

            DialogResult dialogResult = MessageBox.Show("Vols traslladar l'animal al CRAM?", "CRAM", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AnimalDAO animalDAO = new AnimalDAO();
                int id = animalId.Text == "" ? 0 : int.Parse(animalId.Text);
                AnimalDTO animal = animalDAO.SeleccionarPerId(id);
                if (animal != null)
                {
                    RescatDTO rescat = new RescatDTO();
                    double Ga = rescat.CalculateGA(animal, double.Parse(ga.Text), true);
                    rescat.DataRescat = DateTime.Parse(dataRescat.Text);
                    rescat.GenerateRescue(animal);
                    if (Ga < 0)
                    {
                        Ga = 0;
                    }
                    rescat.GA = Ga;
                    rescat.Localitzacio = localitzacio.Text;

                    RescatDAO rescatDAO = new RescatDAO();

                    rescatDAO.InsertRescue(rescat);
                    if (rescat.GA < 30)
                    {
                        MessageBox.Show("Animal traslladat al CRAM. Grau d'afectació: " + rescat.GA + ". Has guanyat 50XP!");
                        persona.XP += 50;

                    }
                    else
                    {
                        MessageBox.Show("Animal traslladat al CRAM. Grau d'afectació: " + rescat.GA + ". Has perdut 20XP");
                        persona.XP -= 20;
                    }
                    MessageBox.Show("Resultats: " + persona.Nom + " té " + persona.XP + "XP");

                    XMLHelper xmlHelper = new XMLHelper();
                    persona.NumRescat = rescat.NumRescat;
                    xmlHelper.InsertPerson(persona);

                    Form1 form1 = new Form1();
                    form1.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Animal no trobat");
                }
            }
            else
            {
                AnimalDAO animalDAO = new AnimalDAO();
                AnimalDTO animal = animalDAO.SeleccionarPerId(int.Parse(animalId.Text));
                if (animal != null)
                {
                    RescatDTO rescat = new RescatDTO();
                    double Ga = rescat.CalculateGA(animal, double.Parse(ga.Text), false);
                    rescat.DataRescat = DateTime.Parse(dataRescat.Text);
                    rescat.GenerateRescue(animal);
                    if (Ga < 0)
                    {
                        Ga = 0;
                    }
                    rescat.GA = Ga;
                    rescat.Localitzacio = localitzacio.Text;

                    RescatDAO rescatDAO = new RescatDAO();

                    rescatDAO.InsertRescue(rescat);
                    if (rescat.GA < 30)
                    {
                        MessageBox.Show("Animal no traslladat al CRAM. Grau d'afectació: " + rescat.GA + ". Has guanyat 50XP!");
                        persona.XP += 50;

                    }
                    else
                    {
                        MessageBox.Show("Animal no traslladat al CRAM. Grau d'afectació: " + rescat.GA + ". has perdut 20XP");
                        persona.XP -= 20;
                    }
                    MessageBox.Show("Resultats: " + persona.Nom + " té " + persona.XP + "XP");

                    XMLHelper xmlHelper = new XMLHelper();
                    persona.NumRescat = rescat.NumRescat;
                    xmlHelper.InsertPerson(persona);

                    Form1 form1 = new Form1();
                    form1.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Animal no trobat");
                }
            }
        }

        /* Carregar formulari */
        private void RescatForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Veteriniari");
            comboBox1.Items.Add("Tècnic");

            AnimalDAO animalDAO = new AnimalDAO();
            AnimalDTO animal = animalDAO.SelectRandomAnimal();

            RescatDTO rescat = new RescatDTO();
            rescat.GenerateRescue(animal);

            numRescat.Text = rescat.NumRescat;
            dataRescat.Text = rescat.DataRescat.ToString();
            especie.Text = animal.Superfamilia;
            ga.Text = rescat.GA.ToString();
            localitzacio.Text = rescat.Localitzacio;
            animalId.Text = animal.Id.ToString();
        }

        /* Botó enrere */
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
