using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Pessoa
    {
        public int PesIs { get; set; }
        public string PesNome { get; set; } = null!;
        public int? PesCpf { get; set; }
        public string? PesEmail { get; set; }
        public int? SetId { get; set; }
        public DateTime? PesLogdatahora { get; set; }
        public int? PesUser { get; set; }
        public char? PesStatus { get; set; }

        public virtual Setor? Set { get; set; }
    }
}
