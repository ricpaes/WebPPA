using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    /// <summary>
    /// Modelos de documentos, guias, notas fiscais, emails, etc
    /// </summary>
    public partial class Modelodocumento
    {
        public Modelodocumento()
        {
            Workflows = new HashSet<Workflow>();
        }

        public int ModgId { get; set; }
        public string? ModgTitulo { get; set; }
        public string? ModgTexto { get; set; }
        public DateTime? ModgLogdatahora { get; set; }
        public int? ModgUser { get; set; }
        public char? ModgStatus { get; set; }

        public virtual ICollection<Workflow> Workflows { get; set; }
    }
}
