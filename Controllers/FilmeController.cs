using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    public static List<Filme> filmes = new List<Filme>();
    public static int id = 0;

    [HttpPost]
    public IActionResult AdicionarFilme([FromBody] Filme filme)
    {
        filme.Id = id++;
        filmes.Add(filme);
        return CreatedAtAction(nameof(ExibirFilmePorId), new { id =  filme.Id }, filme);
    }

    [HttpGet]
    public IEnumerable<Filme> ExibirFilmes([FromQuery] int skip = 0, [FromQuery] int take = 5)
    {
        return filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult ExibirFilmePorId(int id)
    {
        var filme =  filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }
}
