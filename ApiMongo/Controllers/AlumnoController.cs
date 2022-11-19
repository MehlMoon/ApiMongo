using ApiMongo.Models;
using ApiMongo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        public EscuelaService _alumnoService;

        public AlumnoController(EscuelaService alumnoService)
        {
            _alumnoService = alumnoService;
        }

        [HttpGet]
        public ActionResult<List<Alumnos>> Get()
        {
            return _alumnoService.Get();
        }

        [HttpPost]
        public ActionResult<Alumnos> Create(Alumnos alumnos)
        {
            return _alumnoService.Create(alumnos);
        }


        [HttpPut]
        public ActionResult Update(Alumnos alumnos)
        {
            _alumnoService.Update(alumnos.Id, alumnos);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _alumnoService.Delete(id);
            return Ok();
        }

    }
}
