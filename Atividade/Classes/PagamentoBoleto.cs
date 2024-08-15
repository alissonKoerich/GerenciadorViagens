using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Classes
{
    public class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto { get; set; }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Pagamento com Boleto: Valor: {Valor}, Numero do Boleto: {NumeroBoleto}");
        }
    }
}
