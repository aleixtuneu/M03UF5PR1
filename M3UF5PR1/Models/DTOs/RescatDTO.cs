using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03UF5PR1.Models.DTOs
{
    public class RescatDTO
    {
        public int Id { get; set; }
        public string NumRescat { get; set; }
        public DateTime DataRescat { get; set; }
        public AnimalDTO Animal { get; set; }
        public double GA { get; set; }
        public string Localitzacio { get; set; }

        // Calcular grau d'afectació
        public double CalculateGA(AnimalDTO animal, double ga, bool cram)
        {
            int x = 0;

            if (animal.Superfamilia == "Ocell Marí")
            {
                x = 15;
                return 2 * ga + 3 - ((ga - 20) * 2) - x;
            }
            else if (animal.Superfamilia == "Tortuga Marina")
            {
                if (cram) x = 5;
                return (ga - x) / 5;
            }
            else
            {
                if (cram) x = 50;
                return ga - (ga / 5) - x;
            }
        }

        // Crear un nou animal aleatori
        public void GenerateRescue(AnimalDTO animal)
        {
            Random random = new Random();
            List<string> localitzacions = new List<string> { "America", "Europa", "Àsia", "Àfrica", "Oceania" };

            NumRescat = "RES" + random.Next(100, 1000);
            DateTime date = new DateTime(random.Next(2010, 2021), random.Next(1, 13), random.Next(1, 29));
            DataRescat = date;
            Animal = animal;
            GA = random.Next(0, 101);
            Localitzacio = localitzacions[random.Next(0, localitzacions.Count)];
        }
    }
}
