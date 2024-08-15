using Atividade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Classes
{
    public abstract class Pagamento : IDetalhavel
    {
        public decimal Valor { get; set; }
        public abstract void ExibirDetalhes();
    }


}
