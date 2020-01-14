using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudVolvo.Models.Entity
{
    public class Caminhao
    {
        public int IdCaminhao { get; set; }
        public string Descricao { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public DateTime AnoModelo { get; set; }
        public string CorCaminhao { get; set; }

        [ForeignKey("IdStatus")]
        public virtual Status Status { get; set; }
    }
}
