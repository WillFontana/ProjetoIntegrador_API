using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetoIntegrador.Data;
using ProjetoIntegrador.Data.Dtos.ProfessorDtos;
using ProjetoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorController : ControllerBase
    {
        private MainContext _context;
        private IMapper _mapper;
        public ProfessorController(MainContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<Professor> GetProfessores()
        {
            return _context.Professores;
        }
        [HttpGet("{cpf}")]
        public IActionResult GetProfessorByCpf(string cpf, [FromBody] LoginProfessorDto professorDto)
        {
            try
            {
                Professor professorLogin = _context.Professores.FirstOrDefault(professorLogin => professorLogin.Cpf.Equals(cpf));
                if(professorLogin == null)
                {
                    return NotFound();
                } else if (!professorDto.Senha.Equals(professorLogin.Senha)) {
                    return Unauthorized();
                } else
                {
                    ReadProfessorDto professorDtoLogin = _mapper.Map<ReadProfessorDto>(professorLogin);
                    return Ok(professorDtoLogin);
                }
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
        [HttpPost]
        public IActionResult AddProfessor([FromBody] CreateProfessorDto professorDto)
        {
            try
            {
                Professor newProfessor = _mapper.Map<Professor>(professorDto);

                _context.Professores.Add(newProfessor);
                _context.SaveChanges();

                return CreatedAtAction(nameof(GetProfessorByCpf), new { newProfessor.Crn }, newProfessor);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }

        }
        [HttpPut("{crn}")]
        public IActionResult UpdateProfessor(string crn, [FromBody] UpdateProfessorDto professorDto)
        {
            try
            {
                Professor professorUpdate = _context.Professores.FirstOrDefault(professorUpdate => professorUpdate.Crn.Equals(crn));
                if (professorUpdate == null)
                {
                    return NotFound();
                }
                _mapper.Map(professorDto, professorUpdate);
                _context.SaveChanges();
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }

        }
        [HttpDelete("{crn}")]
        public IActionResult DeleteProfessor(string crn)
        {
            try
            {
                Professor professorDelete = _context.Professores.FirstOrDefault(professorDelete => professorDelete.Crn.Equals(crn));
                if (professorDelete == null)
                {
                    return NotFound();
                }

                _context.Remove(professorDelete);
                _context.SaveChanges();

                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }

        }
    }
}
