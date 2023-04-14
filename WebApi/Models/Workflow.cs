using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    /// <summary>
    /// Tabela com os terefas que de devem ser realizadas para cada linha de produto e ação
    /// </summary>
    public partial class Workflow
    {
        public int WrkId { get; set; }
        public string? WrkDescricao { get; set; }
        public int TlpId { get; set; }
        public int TpaId { get; set; }
        public int TpsId { get; set; }
        public int WrkSequencia { get; set; }
        public int? WrkDestino { get; set; }
        public bool? WrkAguardaraprovacao { get; set; }
        public bool? WrkPossuimodelo { get; set; }
        public int? ModgId { get; set; }
        public DateTime? WrkDatainicio { get; set; }
        public DateTime? WrkDatafim { get; set; }
        public DateTime? WrkLogdatahora { get; set; }
        public int? WrkUser { get; set; }
        public char? WrkStatus { get; set; }

        public virtual Modelodocumento? Modg { get; set; }
        public virtual Tipolinhaproduto Tlp { get; set; } = null!;
        public virtual Tipoacao Tpa { get; set; } = null!;
        public virtual Tiposaida Tps { get; set; } = null!;
        public virtual Setor? WrkDestinoNavigation { get; set; }
    }
}
