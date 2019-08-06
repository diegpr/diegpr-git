using Microsoft.AspNetCore.Mvc;
using System;
using TheProject.API.Model.DomainServices;
using TheProject.API.Model.Entities;

namespace TheProject.API.Controllers
{
    //Route prexix API
    [Route("api/[controller]")]
    public abstract class BaseController<T> : Controller where T : BaseEntity
    {
        [HttpGet("{id}")]
        public IActionResult Obter([FromServices]IGenericService<T> svc, int id)
        {
            try
            {
                var result = svc.Obter(id);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpPost]
        public IActionResult Criar([FromServices]IGenericService<T> svc, [FromBody] T obj)
        {
            try
            {
                if (!obj.Validate())
                    return BadRequest(obj);
                var result = svc.Criar(obj);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("[action]")]
        public IActionResult Listar([FromServices]IGenericService<T> svc, [FromQuery]T filtro)
        {
            try
            {
                var result = svc.Listar(filtro);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar([FromServices]IGenericService<T> svc, int id)
        {
            try
            {
                var result = svc.Deletar(id);
                if (result)
                    return NoContent();
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar([FromServices]IGenericService<T> svc, [FromBody] T obj, int id)
        {
            try
            {
                var exists = svc.Obter(id);
                if (exists == null)
                    return NotFound();

                if (!obj.Validate())
                    return BadRequest(obj);
                if (obj.Id == 0)
                    obj.Id = id;
                var result = svc.Atualizar(obj);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
