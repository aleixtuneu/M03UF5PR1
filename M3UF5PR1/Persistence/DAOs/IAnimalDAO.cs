using M03UF5PR1.Models.DTOs;

namespace M03UF5PR1.Persistence.DAOs
{
     public interface IAnimalDAO
    {
        void InsertAnimal(AnimalDTO animal);
        void UpdateAnimal(AnimalDTO animal);
        void DeleteAnimalById(int id);
        AnimalDTO SelectRandomAnimal();
        AnimalDTO SelectById(int id);
        int NextId();
        List<int> GetAllIds();
    }
}
