using System;
using System.Collections.Generic;

namespace ENG7.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public int IdHtml { get; set; }
        public string CodInterno { get; set; }
        public string CnpjParametro { get; set; }  
        public string CnpjConsultado { get; set; }
        public string CnpjNumInscricao { get; set; }
        public string NomeEmpresarial { get; set; }
        public string NomeFantasia { get; set; }
        public DateTime DataImportacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public string PorteEmpresa { get; set; }
        public decimal FatBrutoAnual { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
    }
}