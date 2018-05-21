using ModelProjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceProjec
{
    public class Repository
    {
        private IList<Fornecedor> fornecedores = new List<Fornecedor>();
        private IList<Produto> produtos = new List<Produto>();
        private IList<NotaEntrada> notasEntrada = new List<NotaEntrada>();



        public Fornecedor InsertFornecedor( Fornecedor fornecedor)
        {
            this.fornecedores.Add(fornecedor);
            return fornecedor;
        }
        public Produto InsertProduto(Produto produto)
        {
            this.produtos.Add(produto);
            return produto;
        }
        public NotaEntrada InsertNotaEntrada(NotaEntrada notaEntrada)
        {
            this.notasEntrada.Add(notaEntrada);
            return notaEntrada;
        }
        public void RemoveFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Remove(fornecedor);
        }
        public void RemoveProduto(Produto produto)
        {
            this.produtos.Remove(produto);
        }
        public void RemoverNotaEntrada(NotaEntrada notaEntrada)
        {
            this.notasEntrada.Remove(notaEntrada);
        }
        public IList<Fornecedor> GetAllFornecedor()
        {
            return this.fornecedores;
        }
        public IList<Produto> GetAllProduto()
        {
            return this.produtos;
        }
        public IList<NotaEntrada> GetAllNotaEntrada()
        {
            return this.notasEntrada;
        }
        public Fornecedor UpdateFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores[this.fornecedores.IndexOf(fornecedor)] = fornecedor;
            return fornecedor;
        }
        public Produto UpdateProduto(Produto produto)
        {
            this.produtos[this.produtos.IndexOf(produto)] = produto;
            return produto;
        }
        public NotaEntrada UpdateNotaEntrada(NotaEntrada notaEntrada)
        {
            this.notasEntrada[this.notasEntrada.IndexOf(notaEntrada)] = notaEntrada;
            return notaEntrada;
        }


    }
}
