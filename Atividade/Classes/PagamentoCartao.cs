using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Classes
{
    public class PagamentoCartao : Pagamento
    {
        public string NumeroCartao { get; set; }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Pagamento com Cartao: Valor: {Valor:C}, Numero do Cartao: {NumeroCartao}");
        }
    }

}
