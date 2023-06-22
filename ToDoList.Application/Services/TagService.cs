using AutoMapper;
using ToDoList.Application.DTOs;
using ToDoList.Application.Interfaces;
using ToDoList.Domain.Entities;
using ToDoList.Domain.Interfaces;
using ToDoList.Domain.IRepositories;

namespace ToDoList.Application.Services
{
    public class TagService : ITagService
    {
        public readonly ITagRepository _tagRepository;
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public TagService(ITagRepository tagRepository, IMapper mapper, IUnitOfWork unitOfWork) {
            _tagRepository = tagRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<TagDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<TagDTO>>(_unitOfWork.TagRepository.Get());
        }
        public TagDTO GetById(int id)
        {
            return _mapper.Map<TagDTO>(_unitOfWork.TagRepository.GetById(t=> t.Id == id));
        }
        
        public void Create(TagDTO Tag)
        {
            _unitOfWork.TagRepository.Add(_mapper.Map<Tag>(Tag));
            _unitOfWork.Commit();
        }

        public void Edit(TagDTO Tag)
        {
            _unitOfWork.TagRepository.Update(_mapper.Map<Tag>(Tag));
            _unitOfWork.Commit();
        }
        public void Delete(int id)
        {
            var tag = _unitOfWork.TagRepository.GetById(p => p.Id == id);

            if (tag == null)
            {
                return;
            }

            _unitOfWork.TagRepository.Delete(tag);
            _unitOfWork.Commit();
        }
    }
}