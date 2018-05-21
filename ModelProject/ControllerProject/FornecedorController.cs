using ModelProjeto;
using PersistenceProjec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class FornecedorController
    {
        private Repository repositorio = new Repository();


        public Fornecedor Insert(Fornecedor fornecedor)
        {
            return this.repositorio.InsertFornecedor(fornecedor);
        }

        public void Remove(Fornecedor fornecedor)
        {
            this.repositorio.RemoveFornecedor(fornecedor);
        }

        public IList<Fornecedor> GetAllFornecedores()
        {
            return this.GetAllFornecedores();
        }

        public Fornecedor Update(Fornecedor fornecedor)
        {
          return  this.repositorio.UpdateFornecedor(fornecedor);
        }

    }
}
