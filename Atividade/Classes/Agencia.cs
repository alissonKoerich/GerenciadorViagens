using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Classes
{
    public class Agencia
    {
        private List<Viagem> viagens = new List<Viagem>();
        private List<Cliente> clientes = new List<Cliente>();
        private List<Reserva> reservas = new List<Reserva>();

       
        public List<Viagem> GetViagens() => viagens;
        public List<Cliente> GetClientes() => clientes;
        public List<Reserva> GetReservas() => reservas;

        public void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
            Console.WriteLine("Cliente adicionado com sucesso");
        }

        public void AdicionarViagem(Viagem viagem)
        {
            viagens.Add(viagem);
            Console.WriteLine("Viagem adicionada com sucesso!");
        }

        public void ListarClientes()
        {
            foreach (var cliente in clientes)
            {
                cliente.ExibirDetalhes();
            }
        }

        public void ListarViagens()
        {
            foreach (var viagem in viagens)
            {
                viagem.ExibirDetalhes();
            }
        }

        public void RealizarReserva(Reserva reserva)
        {
            reservas.Add(reserva);
            Console.WriteLine("Reserva realizada com sucesso!");
        }

        public void ListarReservas()
        {
            foreach (var reserva in reservas)
            {
                reserva.ExibirDetalhes();
            }
        }

        public void CancelarReserva(Reserva reserva)
        {
            reservas.Remove(reserva);
            Console.WriteLine("Reserva cancelada com sucesso!");
        }

        public void AtualizarReserva(Reserva reserva)
        {
            
        }

        public void ListarReservasPorCliente(Cliente cliente)
        {
            foreach (var reserva in reservas)
            {
                if (reserva.Cliente == cliente)
                {
                    reserva.ExibirDetalhes();
                }
            }
        }

        public void FiltrarViagensPorPreco(decimal preco)
        {
            foreach (var viagem in viagens)
            {
                if (viagem.Preco <= preco)
                {
                    viagem.ExibirDetalhes();
                }
            }
        }

        public void FiltrarViagensPorDestino(string destino)
        {
            foreach (var viagem in viagens)
            {
                if (viagem.Destino.Contains(destino))
                {
                    viagem.ExibirDetalhes();
                }
            }
        }

        public void FiltrarViagensPorTipo<T>() where T : Viagem
        {
            foreach (var viagem in viagens)
            {
                if (viagem is T)
                {
                    viagem.ExibirDetalhes();
                }
            }
        }
    }
}
