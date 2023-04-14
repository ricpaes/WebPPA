using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Tiposaida
    {
        public Tiposaida()
        {
            Workflows = new HashSet<Workflow>();
        }

        public int TpsId { get; set; }
        public string TpsDescricao { get; set; } = null!;
        public DateTime? TpsLogdatahora { get; set; }
        public int? TpsUser { get; set; }
        public char? TpsStatus { get; set; }

        public virtual ICollection<Workflow> Workflows { get; set; }
    }
}
