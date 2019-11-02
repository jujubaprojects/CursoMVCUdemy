using CursoMVCUdemy.Data;
using CursoMVCUdemy.Models;
using CursoMVCUdemy.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CursoMVCUdemy.UnitOfWork
{
    public class UnitOfWorkApp : DbContext
    {
        private ContextApp context = new ContextApp();
        private Repository.Repository<Produto> produtoRepository;

        public Repository<Produto> ProdutoRepository
        {
            get
            {
                if (produtoRepository == null)
                {
                    produtoRepository = new Repository<Produto>(context);
                }
                return produtoRepository;
            }
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}