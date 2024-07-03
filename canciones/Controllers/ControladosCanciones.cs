using canciones.Contexto;
using canciones.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace canciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControladosCanciones : ControllerBase
    {
        private readonly ICancionRepositorio _cancionrepositorio;
        public ControladosCanciones(ICancionRepositorio cancionRepositorio)
        {
             this._cancionrepositorio = cancionRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Canciones>>> GetAllCanciones()
        {
            var song = await this._cancionrepositorio.GetAllCanciones();
            return Ok(song);
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Canciones>> Getcanciones(int id)
        //{
        //    var song = await _contexto.canciones.ToListAsync();
        //    return Ok(song);
        //}
        //[HttpDelete("{id}")]
        
        //public async Task<ActionResult<Canciones>> Quitarcanciones(int id )
        //{

        //    var song = await _contexto.canciones.FindAsync(id);
        //    if (song == null) { return NotFound("no hay"); }
        //    _contexto.canciones.Remove(song);
        //    await _contexto.SaveChangesAsync();
        //    return Ok(song);


        //}
        //[HttpPost]
        //public async Task<ActionResult<Canciones>> ponercancion(Canciones canciones)
        //{
        //     _contexto.canciones.Add(canciones);
        //    await _contexto.SaveChangesAsync();
        //    return Ok(canciones);
        //}
        //[HttpPut]
        //public async Task<ActionResult<Canciones>> cambiarnombre(Canciones nombre)
        //{
        //    var acancion =await _contexto.canciones.FindAsync(nombre.Id);
        //    acancion.Titulo=nombre.Titulo;
        //    acancion.Genero=nombre.Genero;
            
        //    return Ok(await _contexto.canciones.ToListAsync());

        //}

    }
}
