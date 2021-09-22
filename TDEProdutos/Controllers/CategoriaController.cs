using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDEProdutos.models;
using TDEProdutos.Validations;

namespace TDEProdutos.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : Controller
    {
        private IList<Categoria> ListaCategoria;

        public CategoriaController()
        {
            ListaCategoria = new List<Categoria>();

            ListaCategoria.Add(new Categoria()
            {
                IdCategoria = 2,
                NomeCategoria = "Salgadinhos"
            });

        }

        [HttpGet]
        public ActionResult Ola()
        {
            return Ok("Ola");
        }






        [HttpGet("BuscarCategoria/{IDCategoria}")]

        public ActionResult BuscarCategoria(int IdCategoria)
        {
            var resultado = ListaCategoria.Where(ID => ID.IdCategoria == IdCategoria).FirstOrDefault();
            if (resultado == null)
            {
                return NotFound("Não existe esse codigo de categoria na base de dados");
            }

            return Ok(resultado);


        }

        [HttpPost("Adicionar")]
        [ProducesResponseType(typeof(Produto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]


        public ActionResult Adicionar(Categoria categoria)
        {


        }





    }


}