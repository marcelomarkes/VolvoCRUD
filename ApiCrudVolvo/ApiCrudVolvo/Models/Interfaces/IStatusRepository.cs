using ApiCrudVolvo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiCrudVolvo.Models.Interfaces
{
    public interface IStatusRepository
    {
        int Atualizar(Status status);
        int Cadastrar(Status status);
        IEnumerable<Status> Listar();
        IEnumerable<Status>
            Listar(Expression<Func<Status, bool>> predicado);
        int Remover(Status status);
    }
}
