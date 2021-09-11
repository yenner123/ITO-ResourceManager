using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ITO.ResourceManager.Models;
using ITO_ResourceManager.Services;
using ITO_ResourceManager.Common.Dtos;

namespace ITO.ResourceManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly IEmpleadoService _empleadoService;

        public EmpleadosController(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }

        // GET: api/Dependencia
        [HttpGet]
        public ActionResult<IEnumerable<EmpleadoDTO>> GetDependencia()
        {
            var empleado = _empleadoService.GetDependencias();
            if (empleado.Any())
            {
                return Ok(empleado);
            }
            return NoContent();
        }

        // GET: api/Dependencia/5
        [HttpGet("{id}")]
        public ActionResult<EmpleadoDTO> GetDependencium(Guid id)
        {
            var empleado = _empleadoService.GetDependencium(id);
            if (empleado != null)
            {
                return Ok(empleado);
            }
            return NoContent();
        }

        // PUT: api/Dependencia/5
        [HttpPut("{id}")]
        public IActionResult PutDependencium(Guid id, EmpleadoDTO dto)
        {
            if (id != dto.Id)
            {
                return BadRequest();
            }
            _empleadoService.PutDependencium(id, dto);
            return NoContent();
        }

        // POST: api/Dependencia
        [HttpPost]
        public ActionResult<EmpleadoDTO> PostDependencium(EmpleadoDTO dto)
        {
            return _empleadoService.PostDependencium(dto);
        }

        // DELETE: api/Dependencia/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDependencium(Guid id)
        {
            _empleadoService.DeleteDependencium(id);
            return NoContent();
        }
    }
}
