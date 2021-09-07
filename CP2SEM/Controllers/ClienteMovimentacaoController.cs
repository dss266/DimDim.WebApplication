using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CP2SEM.DAO;
using CP2SEM.Models;

namespace CP2SEM.Controllers
{
    public class ClienteMovimentacaoController : Controller
    {
        // GET: ClienteMovimentacaoController
        ClienteMovimentacaoDAO dao ;
        MovimentacaoDAO movimentacaoDao ;
        private ClienteDAO clienteDao;
        public ActionResult Index()
        {
            dao = new ClienteMovimentacaoDAO();
            var lista = dao.GetAll();
            return View(lista);
        }

        // GET: ClienteMovimentacaoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteMovimentacaoController/Create
        public ActionResult Create()
        {
            var clientes= clienteDao.GetAll().ToList();
            var movimentacao = movimentacaoDao.GetAll().ToList();

            ViewBag.DropCliente = clientes;
            ViewBag.DropMovimentacao = movimentacao;

            return View();
        }

        // POST: ClienteMovimentacaoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                ClienteMovimentacao clienteMovimentacao = new ClienteMovimentacao();

                clienteMovimentacao.IdCliente = Convert.ToInt32(collection["IdCliente"]);
                clienteMovimentacao.IdMovimentacao = Convert.ToInt32(collection["IdMovimentacao"]) ;
                
                dao = new ClienteMovimentacaoDAO();
                dao.Add(clienteMovimentacao);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteMovimentacaoController/Edit/5
        public ActionResult Edit(int id)
        {
            dao = new ClienteMovimentacaoDAO();

            var clienteMovimentação = dao.GetById(id);
            
            return View(clienteMovimentação);
        }

        // POST: ClienteMovimentacaoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                ClienteMovimentacao clienteMovimentacao = new ClienteMovimentacao();

                clienteMovimentacao.IdCliente = Convert.ToInt32(collection["IdCliente"]);
                clienteMovimentacao.IdMovimentacao = Convert.ToInt32(collection["IdMovimentacao"]);

                dao = new ClienteMovimentacaoDAO();
                dao.Update(clienteMovimentacao);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteMovimentacaoController/Delete/5
        public ActionResult Delete(int id)
        {
            dao = new ClienteMovimentacaoDAO();

            var clienteMovimentação = dao.GetById(id);

            return View(clienteMovimentação);
        }

        // POST: ClienteMovimentacaoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                dao = new ClienteMovimentacaoDAO();

                var clienteMovimentacao = dao.GetById(id);

                dao.Remove(clienteMovimentacao);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
