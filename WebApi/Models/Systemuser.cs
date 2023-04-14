using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Systemuser
    {
        public decimal SusrId { get; set; }
        public string SusrNome { get; set; } = null!;
        public string SusrLogin { get; set; } = null!;
        public string SusrSenha { get; set; } = null!;
        public DateTime? SusrLogdatahora { get; set; }
        public char? SusrStatus { get; set; }
    }
}
