using Class03.Homework.Data;
using Class03.Homework.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class03.Homework.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    //https://localhost:[port]/api/books
    //https://localhost:[port]/api/books?idnex=[index]
    [HttpGet]
    public ActionResult Get([FromQuery] int? index)
    {
        try
        {
            if (index == null) return Ok(StaticDb.Books);
            if (index < 0) return BadRequest("Index must be a positive number.");
            if (index >= StaticDb.Books.Count) return NotFound($"There is no resource on index {index}.");

            return Ok(StaticDb.Books[index.Value]);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    //https://localhost:[port]/api/search?author=[author]&title=[title]
    [HttpGet("search")]
    public ActionResult<List<Book>> Search([FromQuery] string? author, string? title)
    {
        try
        {
            if(string.IsNullOrEmpty(author) && string.IsNullOrEmpty(title)) return BadRequest("Filter parameters are required and must be valid.");

            var books = StaticDb.Books.Where(x => 
                (string.IsNullOrWhiteSpace(author) || x.Author.ToLower().Contains(author.ToLower())) &&
                (string.IsNullOrWhiteSpace(title) || x.Title.ToLower().Contains(title.ToLower()))).ToList();

            if (books.Count == 0) return Ok("No books with those parameters were found.");

            return Ok(books);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    public IActionResult Post([FromBody] List<Book> books)
    {
        try
        {
            if (books == null || books.Count == 0) return BadRequest("At least one book entry is required.");

            foreach (var book in books)
            {
                if (string.IsNullOrEmpty(book.Author)) return BadRequest("Book author is require.");
                if (string.IsNullOrEmpty(book.Title)) return BadRequest("Book title is required.");
            }

            StaticDb.Books.AddRange(books);

            return StatusCode(StatusCodes.Status201Created, books.Select(x => x.Title));
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}
