using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Classes
{
    public class Reserva
    {
        public Viagem Viagem { get; set; }
        public Cliente Cliente { get; set; }
        public List<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();

        public void AdicionarPagamento(Pagamento pagamento)
        {
            Pagamentos.Add(pagamento);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("Detalhes da Reserva:");
            Cliente.ExibirDetalhes();
            Viagem.ExibirDetalhes();
            foreach (var pagamento in Pagamentos)
            {
                pagamento.ExibirDetalhes();
            }
        }
    }
}
