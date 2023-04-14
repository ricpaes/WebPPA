using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Tipoacao
    {
        public Tipoacao()
        {
            Workflows = new HashSet<Workflow>();
        }

        public int TpaId { get; set; }
        public string TpaDescricao { get; set; } = null!;
        public DateTime? TpaLogdatahora { get; set; }
        public int? TpaUser { get; set; }
        public char? TpaStatus { get; set; }

        public virtual ICollection<Workflow> Workflows { get; set; }
    }
}
