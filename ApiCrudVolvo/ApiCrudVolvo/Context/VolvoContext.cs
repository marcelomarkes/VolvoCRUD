using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudVolvo.Context
{
    public class VolvoContext : DbContext
    {
        public VolvoContext(DbContextOptions<VolvoContext> options) : base(options)
        {

        }
    }
}
