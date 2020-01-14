using ApiCrudVolvo.Context;
using ApiCrudVolvo.Models.Entity;
using ApiCrudVolvo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudVolvo.Repository
{
    public class CaminhaoRepository : BaseRepository<Caminhao, int>, ICaminhaoRepository
    {
        private VolvoContext Context;
        public CaminhaoRepository(VolvoContext context) : base(context)
        {
            Context = context;
        }
    }
}
