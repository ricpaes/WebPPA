using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    /// <summary>
    /// tabela com lista de parâmetros que podem ser usados nos modelos de email, guia e outros.
    /// </summary>
    public partial class Tipoparametromodelo
    {
        public int TppmId { get; set; }
        public string TppmNome { get; set; } = null!;
        public string TppmTabela { get; set; } = null!;
        public string TppmColuna { get; set; } = null!;
        public DateTime? TppmLogdatahora { get; set; }
        public int? TppmUser { get; set; }
        public char? TppmStatus { get; set; }
    }
}
