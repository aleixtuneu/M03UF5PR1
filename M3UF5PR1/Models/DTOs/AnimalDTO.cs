using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03UF5PR1.Models.DTOs
{
    public class AnimalDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Superfamilia { get; set; }
        public string Especie { get; set; }
        public double Pes { get; set; }
    }
}
