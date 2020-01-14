using ApiCrudVolvo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiCrudVolvo.Models.Interfaces
{
    public interface ICaminhaoRepository
    {
        int Atualizar(Caminhao caminhao);
        int Cadastrar(Caminhao caminhao);
        IEnumerable<Caminhao> Listar();
        IEnumerable<Caminhao>
            Listar(Expression<Func<Caminhao, bool>> predicado);
        int Remover(Caminhao caminhao);
    }
}
