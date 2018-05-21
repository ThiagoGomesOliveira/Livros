using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProjeto;
using PersistenceProjec;

namespace ControllerProject
{
   public class NotaEntradaController
    {
        private Repository repositorio = new Repository();


        public NotaEntrada Insert(NotaEntrada notaEntrada)
        {
           return this.repositorio.InsertNotaEntrada(notaEntrada);
        }

        public void Remover(NotaEntrada notaEntrada)
        {
             this.repositorio.RemoverNotaEntrada(notaEntrada);
        }
        public IList<NotaEntrada> GetAllNotaEntrada(NotaEntrada notaEntrada)
        {
            return this.repositorio.GetAllNotaEntrada();
        }
        public NotaEntrada Update (NotaEntrada notaEntrada)
        {
            return this.repositorio.UpdateNotaEntrada(notaEntrada);
        }

    }
}
