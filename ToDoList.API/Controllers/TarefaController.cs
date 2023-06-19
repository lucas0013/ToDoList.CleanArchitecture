using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.DTOs;
using ToDoList.Application.Interfaces;

namespace ToDoList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaService _tarefaService;
        public TarefaController(ITarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var tarefas = _tarefaService.GetAll();
            return Ok(tarefas);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var tarefa = _tarefaService.GetById(id);
            return Ok(tarefa);
        }
        [HttpPost]
        public IActionResult Post(TarefaDTO tarefa)
        {
            _tarefaService.Create(tarefa);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(TarefaDTO tarefa)
        {
            _tarefaService.Edit(tarefa);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tarefaService.Delete(id);
            return Ok();
        }
    }
}
