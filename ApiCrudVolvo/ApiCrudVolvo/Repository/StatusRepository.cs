using ApiCrudVolvo.Context;
using ApiCrudVolvo.Models.Entity;
using ApiCrudVolvo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudVolvo.Repository
{
    public class StatusRepository : BaseRepository<Status, int>, IStatusRepository
    {
        private VolvoContext Context { get; set; }
        public StatusRepository(VolvoContext context) : base(context)
        {
            Context = context;
        }
    }
}
