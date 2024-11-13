using DataAccess.Generic;
using Entities.Domain;
using Entities.Domain.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiciosController : ControllerBase
    {
        private readonly IGenericRepository<Servicio> _genericRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ServiciosController(IGenericRepository<Servicio> genericRepository, IUnitOfWork unitOfWork)
        {
            this._genericRepository = genericRepository;
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<Servicio>> Get()
        {
            return await _genericRepository.GetAsync();
        }

        [HttpGet("buscarServicio")]
        public async Task<IEnumerable<Servicio>> Get([FromQuery] string nombreServicio)
        {
            return await _genericRepository.GetAsync(a => a.NombreServicio == nombreServicio);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ServicioDTO servicio)
        {
            if (ModelState.IsValid)
            {

                bool state = await _genericRepository.CreateAsync(servicio);
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
        public async Task<ActionResult> Update(int id, [FromBody] ServicioDTO servicio)
        {
            bool state = await _genericRepository.UpdateByIdAsync(id, servicio);
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
