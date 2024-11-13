using DataAccess.Generic;
using Entities.Domain;
using Entities.Domain.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IGenericRepository<Cliente> _genericRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ClientesController(IGenericRepository<Cliente> genericRepository, IUnitOfWork unitOfWork)
        {
            this._genericRepository = genericRepository;
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<Cliente>> Get()
        {
            return await _genericRepository.GetAsync();
        }

        [HttpGet("buscarCliente")]
        public async Task<IEnumerable<Cliente>> Get([FromQuery] string nombre)
        {
            return await _genericRepository.GetAsync(a => a.Nombre == nombre);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ClienteDTO cliente)
        {
            if (ModelState.IsValid)
            {

                bool state = await _genericRepository.CreateAsync(cliente);
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
        public async Task<ActionResult> Update(int id, [FromBody] ClienteDTO cliente)
        {
            bool state = await _genericRepository.UpdateByIdAsync(id, cliente);
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
