using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProjeto;
using PersistenceProjec;
namespace ControllerProject
{
    public class ProdutoController
    {
        private Repository repositorio = new Repository();

        public Produto Insert(Produto produto)
        {
          return  this.repositorio.InsertProduto(produto);
        }
        public void Remove(Produto produto)
        {
            this.repositorio.RemoveProduto(produto);
        }
        public IList<Produto> GetAllProduto()
        {
            return this.repositorio.GetAllProduto();
        }
        public Produto Update(Produto produto)
        {
            return this.repositorio.UpdateProduto(produto);
        }


    }
}
