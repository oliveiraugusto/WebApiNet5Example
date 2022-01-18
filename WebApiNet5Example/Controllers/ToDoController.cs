using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiNet5Example.Services;

namespace WebApiNet5Example.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        private readonly ITodoService service;

        public ToDoController(ITodoService service)
        {
            this.service = service;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await service.Get());
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult> GetTodo(int id)
        {
            return Ok(await service.Get(id));
        }
    }
}
