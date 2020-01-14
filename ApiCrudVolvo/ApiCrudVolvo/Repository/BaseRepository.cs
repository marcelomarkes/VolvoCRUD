using ApiCrudVolvo.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiCrudVolvo.Repository
{
    public class BaseRepository<TEntity, TCode> where TEntity : class
    {
        protected readonly VolvoContext _context;

        public BaseRepository(VolvoContext context)
        {
            _context = context;
        }

        public int Atualizar(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChanges();
        }


        public int Cadastrar(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return _context.SaveChanges();
        }


        public int Remover(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return _context.SaveChanges();
        }


        public IEnumerable<TEntity> Listar(Expression<Func<TEntity, bool>> predicado)
        {
            return this._context.Set<TEntity>().Where(predicado).ToList();
        }

        public IEnumerable<TEntity> Listar()
        {
            return this._context.Set<TEntity>().ToList();
        }
    }
}
