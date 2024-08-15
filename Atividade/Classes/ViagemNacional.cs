using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Classes
{
    public class ViagemNacional : Viagem
    {
        public string Estado { get; set; }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Viagem Nacional: Destino: {Destino}, Estado: {Estado}, Preco: {Preco}");
        }
    }
}
