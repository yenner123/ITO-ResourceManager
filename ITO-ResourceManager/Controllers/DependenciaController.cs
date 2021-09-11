using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ITO.ResourceManager.Models;
using ITO_ResourceManager.Services;
using ITO_ResourceManager.Common;

namespace ITO.ResourceManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DependenciaController : ControllerBase
    {
        private readonly IDependenciaService _dependenciaService;

        public DependenciaController(IDependenciaService dependenciaService)
        {
            _dependenciaService = dependenciaService;
        }

        // GET: api/Dependencia
        [HttpGet]
        public ActionResult<IEnumerable<DependenciaDTO>> GetDependencia()
        {
            var dependencias = _dependenciaService.GetDependencias();
            if (dependencias.Any())
            {
                return Ok(dependencias);
            }
            return NoContent();
        }

        // GET: api/Dependencia/5
        [HttpGet("{id}")]
        public ActionResult<DependenciaDTO> GetDependencium(Guid id)
        {
            var dependencia = _dependenciaService.GetDependencium(id);
            if (dependencia != null)
            {
                return Ok(dependencia);
            }
            return NoContent();
        }

        // PUT: api/Dependencia/5
        [HttpPut("{id}")]
        public IActionResult PutDependencium(Guid id, DependenciaDTO dto)
        {
            if (id != dto.Id)
            {
                return BadRequest();
            }
            _dependenciaService.PutDependencium(id, dto);
            return NoContent();
        }

        // POST: api/Dependencia
        [HttpPost]
        public ActionResult<DependenciaDTO> PostDependencium(DependenciaDTO dto)
        {
            return _dependenciaService.PostDependencium(dto);
        }

        // DELETE: api/Dependencia/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDependencium(Guid id)
        {
            _dependenciaService.DeleteDependencium(id);
            return NoContent();
        }
    }
}
