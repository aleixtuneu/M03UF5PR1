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
using M03UF5PR1.Models.DTOs;
using M03UF5PR1.Persistence.Mapping;

namespace M03UF5PR1
{
    public partial class GestioForm : Form
    {
        public GestioForm()
        {
            InitializeComponent();
        }

        /* Botó INSERIR */
        private void button1_Click(object sender, EventArgs e)
        {
            Regex words = new Regex(@"^[a-zA-Z\s]+$");
            
            Regex weight = new Regex(@"^\d+(\,\d+)?$");
            if (inserirNom.Text == "")
            {
                errorNom.SetError(inserirNom, "Es requereix el Nom");
                return;
            }
            else if (!words.IsMatch(inserirNom.Text))
            {
                errorNom.SetError(inserirNom, "El Nom només pot contenir lletres");
                return;
            }
            else
            {
                errorNom.Clear();
            }

            if (inserirSuperfamilia.Text == "")
            {
                errorText.SetError(inserirSuperfamilia, "Es requereix una Superfamilia");
                return;
            }
            else
            {
                errorText.Clear();
            }

            if (inserirEspecie.Text == "")
            {
                errorEspecie.SetError(inserirEspecie, "Es requereix una espècie");
                return;
            }
            else if (!words.IsMatch(inserirEspecie.Text))
            {
                errorEspecie.SetError(inserirEspecie, "L'espècie només pot contellir lletres");
                return;
            }
            else
            {
                errorEspecie.Clear();
            }

            if (inserirPes.Text == "")
            {
                errorPes.SetError(inserirPes, "Es requereix el pes");
                return;
            }
            else if (!weight.IsMatch(inserirPes.Text))
            {
                errorPes.SetError(inserirPes, "El pes ha de ser un número");
                return;
            }
            else
            {
                errorPes.Clear();

            }

            AnimalDTO animal = new AnimalDTO
            {
                Nom = inserirNom.Text,
                Superfamilia = inserirSuperfamilia.Text,
                Especie = inserirEspecie.Text,
                Pes = double.Parse(inserirPes.Text)
            };

            AnimalDAO animalDAO = new AnimalDAO();
            animalDAO.InserirAnimal(animal);

            MessageBox.Show("Animal inserit amb èxit");

            inserirId.Text = animalDAO.NextId().ToString();
        }

        /* Actualitzar enter */
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            actualitzarId.Items.Clear();

            AnimalDAO animalDAO = new AnimalDAO();
            List<int> ids = animalDAO.GetAllIds();
            foreach (int id in ids)
            {
                actualitzarId.Items.Add(id);
            }
        }

        /* Botó Actualitzar */
        private void button2_Click(object sender, EventArgs e)
        {
            if (actualitzarId.Text == "")
            {
                errorId.SetError(actualitzarId, "Es requerix un Id");
                return;
            }
            else if (!actualitzarId.Items.Contains(int.Parse(actualitzarId.Text)))
            {
                errorId.SetError(actualitzarId, "Id no trobat");
                return;
            }
            else
            {
                errorId.Clear();
            }

            Regex words = new Regex(@"^[a-zA-Z\s]+$");
            Regex pes = new Regex(@"^\d+(\,\d+)?$");

            if (actualitzarNom.Text == "")
            {
                errorNom.SetError(actualitzarNom, "Es requereix un nom");
                return;
            }
            else if (!words.IsMatch(actualitzarNom.Text))
            {
                errorNom.SetError(actualitzarNom, "El nom només pot contenir lletres");
                return;
            }
            else
            {
                errorNom.Clear();
            }

            if (!actualitzarSuperfamilia.Items.Contains(actualitzarSuperfamilia.Text))
            {
                errorText.SetError(actualitzarSuperfamilia, "Es requereix una Superfamilia");
                return;
            }
            else
            {
                errorText.Clear();
            }

            if (actualitzarEspecie.Text == "")
            {
                errorEspecie.SetError(actualitzarEspecie, "Es requereix una espècie");
                return;
            }
            else if (!words.IsMatch(actualitzarEspecie.Text))
            {
                errorEspecie.SetError(actualitzarEspecie, "L'espècie només pot contenir lletres");
                return;
            }
            else
            {
                errorEspecie.Clear();
            }

            if (actualitzarPes.Text == "")
            {
                errorPes.SetError(actualitzarPes, "Es requereix un pes");
                return;
            }
            else if (!pes.IsMatch(actualitzarPes.Text))
            {
                errorPes.SetError(actualitzarPes, "El pes només poden ser números");
                return;
            }
            else
            {
                errorPes.Clear();
            }

            AnimalDTO animal = new AnimalDTO
            {
                Id = int.Parse(actualitzarId.Text),
                Nom = actualitzarNom.Text,
                Superfamilia = actualitzarSuperfamilia.Text,
                Especie = actualitzarEspecie.Text,
                Pes = double.Parse(actualitzarPes.Text)
            };
            AnimalDAO animalDAO = new AnimalDAO();
            animalDAO.ActualitzarAnimal(animal);
            MessageBox.Show("Animal actualitzat amb èxit");
        }

        /* Botó Borrar */
        private void Borrar_Click(object sender, EventArgs e)
        {
            if (borrarId.Text == "")
            {
                errorId.SetError(borrarId, "Es requereix un id");
                return;
            }
            else if (!borrarId.Items.Contains(int.Parse(borrarId.Text)))
            {
                errorId.SetError(borrarId, "Id no trobat");
                return;
            }
            else
            {
                errorId.Clear();
            }

            AnimalDAO animalDAO = new AnimalDAO();
            animalDAO.BorrarAnimalPerId(int.Parse(borrarId.Text));
            MessageBox.Show("Animal borrat amb èxit");

            borrarId.Items.Clear();
            List<int> ids = animalDAO.GetAllIds();
            foreach (int id in ids)
            {
                borrarId.Items.Add(id);
            }
        }

        /* Botó Enrere */
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        /* Carregar formulari */
        private void GestioForm_Load(object sender, EventArgs e)
        {
            AnimalDAO animalDAO = new AnimalDAO();
            inserirId.Text = animalDAO.NextId().ToString();

            List<int> ids = animalDAO.GetAllIds();

            foreach (int id in ids)
            {
                borrarId.Items.Add(id);
                actualitzarId.Items.Add(id);
            }

            List<string> superfamilies = new List<string> { "Ocell Marí", "Tortuga Marina", "Cetaci" };

            foreach (string superfamilia in superfamilies)
            {
                inserirSuperfamilia.Items.Add(superfamilia);
                actualitzarSuperfamilia.Items.Add(superfamilia);
            }
        }

        /* Borrar */
        private void groupBox3_Enter(object sender, EventArgs e)
        {
            borrarId.Items.Clear();

            AnimalDAO animalDAO = new AnimalDAO();
            List<int> ids = animalDAO.GetAllIds();
            foreach (int id in ids)
            {
                borrarId.Items.Add(id);
            }
        }
    }
}
