using Atividade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Classes
{
    public abstract class Viagem : IReservavel
    {
        public string Destino { get; set; }
        public decimal Preco { get; set; }

        public abstract void ExibirDetalhes();
    }

}
