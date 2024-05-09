using M03UF5PR1.Models.DTOs;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;


namespace M03UF5PR1.Persistence.Mapping
{
    public class XMLHelper
    {
        // Inserir persones al fitxer XML
        public void InsertPerson(PersonaDTO persona)
        {
            string path = @"../../../Scores.xml";
            XDocument doc = XDocument.Load(path);
            doc.Root.Add(new XElement("persona",
                         new XElement("nom", persona.Nom),
                         new XElement("ofici", persona.Ofici),
                         new XElement("xp", persona.XP),
                         new XElement("rescat", persona.NumRescat)));
            doc.Save(path);
        }

        // Obtenir llista de persones
        public List<PersonaDTO> GetPeople()
        {
            XDocument doc = XDocument.Load(@"../../../Scores.xml");
            List<PersonaDTO> persones = new List<PersonaDTO>();

            foreach (XElement element in doc.Descendants("persona"))
            {
                PersonaDTO persona = new PersonaDTO();
                persona.Nom = element.Element("nom").Value;
                persona.Ofici = element.Element("ofici").Value;
                persona.XP = int.Parse(element.Element("xp").Value);
                persona.NumRescat = element.Element("rescat").Value;

                persones.Add(persona);
            }
            return persones;
        }
    }
}
