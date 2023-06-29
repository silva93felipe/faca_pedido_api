using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.DTO
{
    public class ItensPedidoDTOResponse
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Descricao { get; set; }
        public double Quantidade {get; set; }
        public double Valor {get; set; }
    }
}