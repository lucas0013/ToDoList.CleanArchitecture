using ToDoList.Application.DTOs;

namespace ToDoList.Application.Interfaces
{
    public interface ITagService
    {
        IEnumerable<TagDTO> GetAll();
        TagDTO GetById(int id);
        void Create(TagDTO Tag);
        void Edit(TagDTO Tag);
        void Delete(int id);
    }
}