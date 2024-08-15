using Atividade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Classes
{
    public class Cliente : IReservavel
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Cliente: Nome: {Nome}, Email: {Email}");
        }
    }
}
