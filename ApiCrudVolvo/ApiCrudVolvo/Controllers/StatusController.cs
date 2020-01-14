using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCrudVolvo.Models.Entity;
using ApiCrudVolvo.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCrudVolvo.Controllers
{
    [Route("api/status")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private IStatusRepository _status { get; set; }

        public StatusController(IStatusRepository status)
        {
            _status = status;
        }

        /// <summary>
        /// Metodo de busca todos os registro sem necessidade de parametro para localização
        /// </summary>
        /// <returns>Lista de Itens cadastrados</returns>
        /// 
        [HttpGet("[action]")]
        public ActionResult<IEnumerable<Status>> Buscar()
        {
            var status = _status.Listar();
            return status.ToList();
        }

        /// <summary>
        /// Metodo de busca todos os registro sem necessidade de parametro para localização
        /// </summary>
        /// <returns>Lista de Itens cadastrados</returns>
        /// 
        [HttpGet]
        // GET: Categoria
        public ActionResult<IEnumerable<Status>> Index()
        {
            var status = _status.Listar();
            return status.ToList();
        }

        /// <summary>
        /// Utilizando Metodo GET da WebApi para busca item especifico com necessidade de parametro para localização 
        /// do id do item.
        /// </summary>
        /// <param name="id"></param>
        /// 
        [HttpGet("{id}")]
        // GET: Categoria/Details/5
        public ActionResult<Status> BuscaId(int id)
        {
            var status = _status.Listar(x => x.IdStatus == id);
            return status.FirstOrDefault();
        }

        /// <summary>
        /// Metodo POST utilizado para inclusão de um novo item.
        /// </summary>
        /// <returns>Cadastro de Novo Item</returns>
        [HttpPost]
        public ActionResult Create(Status status)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    _status.Cadastrar(status);
                    return Ok();
                }
                else
                    return NotFound();

            }
            catch
            {
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Metodo PUT utilizado para alteração de um item de especifico ID.
        /// </summary>
        /// <param name="id"></param>
        [HttpPut]
        public ActionResult Edit(Status status)
        {
            try
            {
                if (ModelState.IsValid)
                {                
                    _status.Atualizar(status);

                    return Ok();
                }
                else
                    return NotFound();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Metodo DELETE utilizado para exclusão de um item de especifico ID.
        /// </summary>
        /// <param name="id"></param>

        [HttpDelete]
        public ActionResult Delete(Status status)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add delete logic here

                    _status.Remover(status);
                    return Ok();
                }
                else
                    return NotFound();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}