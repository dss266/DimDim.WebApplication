using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CP2SEM.DAO;
using CP2SEM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CP2SEM.Controllers
{
    public class ClienteController : Controller
    {
        ClienteDAO dao;
        // GET: Cliente
        public ActionResult Index()
        {
            dao = new ClienteDAO();
            var lista = dao.GetAll();
            return View(lista);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Cliente cliente = new Cliente();

                cliente.Nome = collection["Nome"];
                cliente.CPF = collection["CPF"];
                cliente.Email = collection["Email"];
                cliente.DataCadastro = DateTime.Now;

                dao = new ClienteDAO();
                dao.Add(cliente);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            dao = new ClienteDAO();

            var cliente = dao.GetById(id);

            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                dao = new ClienteDAO();

                Cliente cliente = new Cliente();

                cliente.Id = Convert.ToInt32(collection["Id"]);
                cliente.Nome = collection["Nome"];
                cliente.CPF = collection["CPF"];
                cliente.Email = collection["Email"];
                cliente.DataCadastro = DateTime.Now;

                dao.Update(cliente);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            dao = new ClienteDAO();

            var cliente = dao.GetById(id);

            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                dao = new ClienteDAO();

                var cliente = dao.GetById(id);

                dao.Remove(cliente);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}