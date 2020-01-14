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
    [Route("api/caminhao")]
    [ApiController]
    public class CaminhaoController : ControllerBase
    {
        private ICaminhaoRepository _caminhao { get; set; }

        public CaminhaoController(ICaminhaoRepository caminhao)
        {
            _caminhao = caminhao;
        }

        [HttpGet("[action]")]
        public ActionResult<IEnumerable<Caminhao>> Buscar()
        {
            var caminhao = _caminhao.Listar();
            return caminhao.ToList();
        }


        [HttpGet]
        // GET: Categoria
        public ActionResult<IEnumerable<Caminhao>> Index()
        {
            var caminhao = _caminhao.Listar();
            return caminhao.ToList();
        }

        [HttpGet("{id}")]
        // GET: Categoria/Details/5
        public ActionResult<Caminhao> BuscaId(int id)
        {
            var cat = _caminhao.Listar(x => x.IdCaminhao == id);
            return cat.FirstOrDefault();
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(Caminhao caminhao)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    _caminhao.Cadastrar(caminhao);
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

        // POST: Categoria/Edit/5
        [HttpPut]
        public ActionResult Edit(Caminhao caminhao)
        {
            try
            {
                if (ModelState.IsValid)
                {


                    //_contexto.Entry(collection).State = EntityState.Modified;                    
                    _caminhao.Atualizar(caminhao);

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

        // DELETE: Categoria/Delete/5
        [HttpDelete]
        public ActionResult Delete(Caminhao caminhao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add delete logic here

                    _caminhao.Remover(caminhao);
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