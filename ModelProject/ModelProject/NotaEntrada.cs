using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
   public class NotaEntrada
    {

        public string NumeroNota { get; set; }
        public string NomeFornecedor { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        public IList<ProdutoNotaEntrada> Produtos { get; set; }


        public NotaEntrada()
        {
            Produtos = new List<ProdutoNotaEntrada>();
        }


        public void RegistrarProduto(ProdutoNotaEntrada produtos)
        {
            if (! this.Produtos.Contains(produtos))
            {
                this.Produtos.Add(produtos);
            }
        }


        public void RemoverProduto(ProdutoNotaEntrada produtos)
        {
            this.Produtos.Remove(produtos);
        }

        public void RemoverTodosProdutos()
        {
            this.Produtos.Clear();
        }

    }
}
