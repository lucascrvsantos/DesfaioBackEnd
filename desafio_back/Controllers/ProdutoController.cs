using desafio_back.Models;
using Microsoft.AspNetCore.Http;
using desafio_back.Data.Dtos;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.Text.Json;
using Microsoft.AspNetCore.JsonPatch;

namespace desafio_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> _produtos = new List<Produto>();
        private IMapper _mapper;

        public ProdutoController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProdutoDto produtoDto)
        {
            Produto produto = _mapper.Map<Produto>(produtoDto);
            if (produto == null) return BadRequest("Objeto vazio.");
            if (produto.Id == null) return BadRequest();
            _produtos.Add(produto);
            int pos = _produtos.Count - 1;
            _produtos[pos].Id = Guid.NewGuid();
            return CreatedAtAction(nameof(Get), new { id = _produtos[pos].Id }, _produtos[pos]);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get([FromQuery] int s = 0, [FromQuery] int t = 15)
        {
            if (t - s > 15) s = t - 15;
            return Ok(_produtos.Skip(s).Take(s + 15));
        }
        [HttpGet("{id}")]
        public ActionResult<Produto> Get(Guid id)
        {
            Produto produto = _produtos.Find(product => product.Id == id);
            if (produto == null) return NotFound();
            return Ok(produto);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            Produto produto = _produtos.Find(product => product.Id == id);
            if (produto == null) return NotFound();
            _produtos.Remove(produto);
            return Ok("Produto removido.");
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] AtualizarProdutoDto produtoDto)
        {
            Produto produto = _produtos.Find(pd => pd.Id == id);
            if (produto == null) return NotFound(); 
            _mapper.Map(produtoDto, produto);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult Put(Guid id, JsonPatchDocument<AtualizarProdutoDto> patch)
        {
            Produto produto = _produtos.Find(pd => pd.Id == id);
            if (produto == null) return NotFound();
            var produtoRequest = _mapper.Map<AtualizarProdutoDto>(produto);
            patch.ApplyTo(produtoRequest, ModelState);
            if (!TryValidateModel(produtoRequest)) return ValidationProblem(ModelState);
            _mapper.Map(produtoRequest, produto);
            return NoContent();
        }
    }
}
