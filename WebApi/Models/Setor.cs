using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Setor
    {
        public Setor()
        {
            Pessoas = new HashSet<Pessoa>();
            Workflows = new HashSet<Workflow>();
        }

        public int SetId { get; set; }
        public string SetNome { get; set; } = null!;
        public int? SetResponsavel { get; set; }
        public DateTime? SetLogdatahora { get; set; }
        public int? SetUser { get; set; }
        public char? SetStatus { get; set; }

        public virtual ICollection<Pessoa> Pessoas { get; set; }
        public virtual ICollection<Workflow> Workflows { get; set; }
    }
}
