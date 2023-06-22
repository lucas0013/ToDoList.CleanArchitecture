using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.DTOs;
using ToDoList.Application.Interfaces;

namespace ToDoList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly ITagService _tagService;
        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Tags = _tagService.GetAll();
            return Ok(Tags);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Tag = _tagService.GetById(id);
            return Ok(Tag);
        }
        [HttpPost]
        public IActionResult Post(TagDTO Tag)
        {
            _tagService.Create(Tag);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(TagDTO Tag)
        {
            _tagService.Edit(Tag);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tagService.Delete(id);
            return Ok();
        }
    }
}