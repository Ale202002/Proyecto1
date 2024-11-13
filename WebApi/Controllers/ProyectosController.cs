using DataAccess.Generic;
using Entities.Domain;
using Entities.Domain.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProyectosController : ControllerBase
    {
        private readonly IGenericRepository<Proyecto> _genericRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProyectosController(IGenericRepository<Proyecto> genericRepository, IUnitOfWork unitOfWork)
        {
            this._genericRepository = genericRepository;
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<Proyecto>> Get()
        {
            return await _genericRepository.GetAsync();
        }

        [HttpGet("buscarProyecto")]
        public async Task<IEnumerable<Proyecto>> Get([FromQuery] string nombreProyecto)
        {
            return await _genericRepository.GetAsync(a => a.NombreProyecto == nombreProyecto);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ProyectoDTO proyecto)
        {
            if (ModelState.IsValid)
            {

                bool state = await _genericRepository.CreateAsync(proyecto);
                if (state)
                {
                    _unitOfWork.Commit();
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            bool state = await _genericRepository.DeleteByIdAsync(id);
            if (state)
            {
                _unitOfWork.Commit();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] ProyectoDTO proyecto)
        {
            bool state = await _genericRepository.UpdateByIdAsync(id, proyecto);
            if (state)
            {
                _unitOfWork.Commit();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
