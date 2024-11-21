using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CodexAPI.Services.Autor;
using CodexAPI.Models;

namespace codexapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorInterface _autorInterface;
        public AutorController(IAutorInterface autorInterface)
        {
            _autorInterface = autorInterface;
        }
        [HttpGet("ListarAutores")] // api/Autor/ListarAutores
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>>ListarAutores(){
            var autores = await _autorInterface.ListarAutores();
            return Ok(autores);
        }
    }
}
