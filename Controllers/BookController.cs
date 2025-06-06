using DesafioLivraria.Communication.Requests;
using DesafioLivraria.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioLivraria.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private int _id = 1;

    //Criar um livro
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredBookJson), StatusCodes.Status201Created)]

    public IActionResult CreateBook([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponseRegisteredBookJson
        {
            Id = _id++,
            Title = request.Title,
        };

        return Created(string.Empty, response);
    }


    //Listar todos os livros
    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<Book>
        {
            new Book { Id= 1, Title="Livro 1", Author="Autor 1", Genero=Genero.Romance, Price=10.50, QtdEstoque=10 },
            new Book { Id= 2, Title="Livro 2", Author="Autor 2", Genero=Genero.Ficcao, Price=123.50, QtdEstoque=20 },
            new Book { Id= 3, Title="Livro 3", Author="Autor 3", Genero=Genero.Drama, Price=13.50, QtdEstoque=30 },
            new Book { Id= 4, Title="Livro 4", Author="Autor 4", Genero=Genero.Misterio, Price=10.70, QtdEstoque=40 },
            new Book { Id= 5, Title="Livro 5", Author="Autor 5", Genero=Genero.Policial, Price=35.50, QtdEstoque=50 },
            
        };

        return Ok(response);
    }


    //Editar um livro
    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update(
        [FromRoute] int id,
        [FromBody] RequestUpdateBookJson request)
    {
        return NoContent();
    }


    //Deletar um livro
    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int Id)
    {
        return NoContent();
    }
}
