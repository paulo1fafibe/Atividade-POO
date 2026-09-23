using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_POO.Model
{
    public class Fornecedor
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }

        public Fornecedor(string cnpj, string nome)
        {
            CNPJ = cnpj;
            Nome = nome;
        }

        
        public string ObterCnpjNome()
        {
            return $"{CNPJ} - {Nome}";
        }
    }
}
