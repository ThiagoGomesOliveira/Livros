using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProjeto
{
   public class ProdutoNotaEntrada
    {
        public Guid Id { get; set; }
        public Produto ProdutoNota { get; set; }
        public double PrecoCusto { get; set; }
        public double QuantidadeComprada { get; set; }


        protected bool Equals(Produto produto)
        {
            return Id.Equals(produto.Id);
        }



        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != typeof(ProdutoNotaEntrada))
            {
                return false;
            }

            return base.Equals(obj);
        }


        public override int GetHashCode()
        {

            return ProdutoNota.GetHashCode();
        }


    }
}
    
