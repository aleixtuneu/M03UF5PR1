using M03UF5PR1.Models.DTOs;

namespace M03UF5PR1.Persistence.DAOs
{
    public interface IRescatDAO
    {
        public void InsertRescue(RescatDTO rescue);
        public List<RescatDTO> GetAllRescue();
        public RescatDTO GetRescueById(int id);
        public List<int> GetAllIds();
    }
}
