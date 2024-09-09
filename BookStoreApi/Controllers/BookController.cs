using Microsoft.AspNetCore.Mvc;
using BookStoreApi.Communication.Response;
using BookStoreApi.Entities;

namespace BookStoreApi.Controllers
{
    public class BookController : BookStoreApiController
    {
        [HttpPost]
        [ProducesResponseType(typeof(Book),StatusCodes.Status201Created)]
        public IActionResult Create(Book request)
        {
            var book = new Book
            {
                Title = request.Title,
                Author = request.Author,
                Genre = request.Genre,
                Id = request.Id,
                Price = request.Price,
                Qty = request.Qty
            };
            
            Book.Adicionar(book);
            
            return Created(string.Empty, book);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var response = Book.Listar();            
            return Ok(response);
        }
        
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromRoute] int id, [FromBody] Book bookUpted)
        {
            Book.Atualizar(id, bookUpted);
            
            return NoContent();
        }
        

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete([FromRoute] int id)
        {
            Book.Deletar(id);
            
            return NoContent();
        }
    }
}
