using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_POO.Model
{
    public class Livro : Produto
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string ClassificacaoIndicativa { get; set; }
        public int Edicao { get; set; }
        public int AnoPublicacao { get; set; }
        public int NumeroPaginas { get; set; }
        public string Autor { get; set; }
        public Editora Editora { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public Livro(
            string codigoBarras,
            string descricao,
            decimal preco,
            string titulo,
            string genero,
            string classificacaoIndicativa,
            int edicao,
            int anoPublicacao,
            int numeroPaginas,
            string autor,
            Editora editora,
            Fornecedor fornecedor)
            : base(codigoBarras, descricao, preco)
        {
            Titulo = titulo;
            Genero = genero;
            ClassificacaoIndicativa = classificacaoIndicativa;
            Edicao = edicao;
            AnoPublicacao = anoPublicacao;
            NumeroPaginas = numeroPaginas;
            Autor = autor;
            Editora = editora;
            Fornecedor = fornecedor;
        }

        // Código de Barras, Descrição, Título e Gênero
        public string ObterResumoBasico()
        {
            return $"{CodigoBarras} - {Descricao} - {Titulo} - {Genero}";
        }

        // Código de Barras, Descrição, Título, Gênero e Editora
        public string ObterResumoComEditora()
        {
            return $"{ObterResumoBasico()} - {Editora.Nome}";
        }

        // Código de Barras, Descrição, Título, Gênero, Editora e Edição
        public string ObterResumoComEdicao()
        {
            return $"{ObterResumoComEditora()} - {Edicao}ª edição";
        }

        // Código de Barras, Descrição, Título, Gênero, Autor, Editora, Edição e Fornecedor
        public string ObterResumoCompleto()
        {
            return $"{CodigoBarras} - {Descricao} - {Titulo} - {Genero} - {Autor} - " +
                   $"{Editora.Nome} - {Edicao}ª edição - {Fornecedor.Nome}";
        }
    }
}
