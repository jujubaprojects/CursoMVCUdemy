using CursoMVCUdemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVCUdemy.Controllers
{
    public class ProdutoController : Controller
    {
        UnitOfWork.UnitOfWorkApp _uow;
        public ProdutoController()
        {
            _uow = new UnitOfWork.UnitOfWorkApp();
        }

        // GET: Produto
        public ActionResult Index()
        {
            return View(_uow.ProdutoRepository.FindAll());
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            return View(_uow.ProdutoRepository.FindByID(id));
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(Produto pProduto)
        {
            try
            {
                // TODO: Add insert logic here
                _uow.ProdutoRepository.Add(pProduto);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_uow.ProdutoRepository.FindByID(id));
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Produto pProduto)
        {
            try
            {
                // TODO: Add update logic here
                _uow.ProdutoRepository.Edit(pProduto);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_uow.ProdutoRepository.FindByID(id));
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Produto pProduto)
        {
            try
            {
                // TODO: Add delete logic here
                _uow.ProdutoRepository.Remove(_uow.ProdutoRepository.FindByID(id));
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
