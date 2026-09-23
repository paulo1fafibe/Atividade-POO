using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_POO.Model
{
    public class Produto
    {
        public string CodigoBarras { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public Produto(string codigoBarras, string descricao, decimal preco)
        {
            CodigoBarras = codigoBarras;
            Descricao = descricao;
            Preco = preco;
        }

        
        public string ObterCodigoBarrasDescricao()
        {
            return $"{CodigoBarras} - {Descricao}";
        }
    }
}
