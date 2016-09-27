using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RMMSA.WebAPI.Fornecedores.Models;

namespace RMMSA.WebAPI.Fornecedores.Controllers
{
    public class FornecedorController : ApiController
    {
        private DB_FornecedorEntities _ctx = new DB_FornecedorEntities();

        // GET: api/Fornecedor
        [HttpGet]
        [ActionName("listagem")]
        public IEnumerable<FORNECEDOR> Get()
        {
            return _ctx.FORNECEDOR.AsEnumerable();
        }

        // GET: api/Fornecedor/5
        [HttpGet]
        [ActionName("busca")]
        public FORNECEDOR Get(int id)
        {
            var objFornecedor = _ctx.FORNECEDOR.FirstOrDefault(f => f.ID_FORNECEDOR.Equals(id));
            return objFornecedor;
        }

        // POST: api/Fornecedor
        [HttpPost]
        [ActionName("incluir")]
        public void Post(FORNECEDOR objFornecedor)
        {
            _ctx.FORNECEDOR.Add(objFornecedor);
            _ctx.SaveChanges();
        }

        // PUT: api/Fornecedor/5
        [HttpPost]
        [ActionName("alterar")]
        public void Put(FORNECEDOR objFornecedorAlterar)
        {
            var buscaFornecedor =
                _ctx.FORNECEDOR.FirstOrDefault(f => f.ID_FORNECEDOR == objFornecedorAlterar.ID_FORNECEDOR);

            _ctx.Entry(buscaFornecedor).CurrentValues.SetValues(objFornecedorAlterar);
            _ctx.SaveChanges();

        }

        // DELETE: api/Fornecedor/5
        [HttpGet]
        [ActionName("excluir")]
        public void Delete(int id)
        {
            var deletarFornecedor = _ctx.FORNECEDOR.FirstOrDefault(f => f.ID_FORNECEDOR == id);
            _ctx.FORNECEDOR.Remove(deletarFornecedor);

            _ctx.SaveChanges();
        }
    }
}
