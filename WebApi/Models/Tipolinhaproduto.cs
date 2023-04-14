using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Tipolinhaproduto
    {
        public Tipolinhaproduto()
        {
            Workflows = new HashSet<Workflow>();
        }

        public int TlpId { get; set; }
        public string TlpDescricao { get; set; } = null!;
        public DateTime? TlpLogdatahora { get; set; }
        public int? TlpUser { get; set; }
        public char? TlpStatus { get; set; }

        public virtual ICollection<Workflow> Workflows { get; set; }
    }
}
