using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Classes
{
    public class ViagemInternacional : Viagem
    {
        public string Pais { get; set; }
        public bool PrecisaVisto { get; set; }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Viagem Internacional: Destino: {Destino}, Pais: {Pais}, Preço: {Preco}, Precisa de Visto: {PrecisaVisto}");
        }
    }   
}
