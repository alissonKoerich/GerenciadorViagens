using Atividade.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Agencia agencia = new Agencia();

            while (true)
            {
                Console.WriteLine("Selecione a Opção:");
                Console.WriteLine("1. Adicionar Cliente");
                Console.WriteLine("2. Adicionar Viagem");
                Console.WriteLine("3. Realizar reserva");
                Console.WriteLine("4. Atualizar reserva");
                Console.WriteLine("5. Listar cliente");
                Console.WriteLine("6. Listar viagens");
                Console.WriteLine("7. Listar reservas");
                Console.WriteLine("8. Listar reserva por cliente");
                Console.WriteLine("9. Cancelar reserva");
                Console.WriteLine("10. Filtrar viagens por preço");
                Console.WriteLine("11. Filtrar viagens por destino");
                Console.WriteLine("12. Filtrar viagens por tipo");
                Console.WriteLine("13. Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        
                        Console.WriteLine("Nome do Cliente:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Email do Cliente:");
                        string email = Console.ReadLine();
                        agencia.AdicionarCliente(new Cliente { Nome = nome, Email = email });
                        break;

                    case "2":
                        
                        Console.WriteLine("1. Viagem Nacional");
                        Console.WriteLine("2. Viagem Internacional");
                        string tipoViagem = Console.ReadLine();

                        if (tipoViagem == "1")
                        {
                            Console.WriteLine("Destino:");
                            string destino = Console.ReadLine();
                            Console.WriteLine("Estado:");
                            string estado = Console.ReadLine();
                            Console.WriteLine("Preço:");
                            decimal preco = decimal.Parse(Console.ReadLine());
                            agencia.AdicionarViagem(new ViagemNacional { Destino = destino, Estado = estado, Preco = preco });
                        }
                        else if (tipoViagem == "2")
                        {
                            Console.WriteLine("Destino:");
                            string destino = Console.ReadLine();
                            Console.WriteLine("País:");
                            string pais = Console.ReadLine();
                            Console.WriteLine("Preço:");
                            decimal preco = decimal.Parse(Console.ReadLine());
                            agencia.AdicionarViagem(new ViagemInternacional { Destino = destino, Pais = pais, Preco = preco, PrecisaVisto = true });
                        }
                        break;

                    case "3":
                        
                        Console.WriteLine("Selecione o Cliente:");
                        agencia.ListarClientes();
                        int indiceCliente = int.Parse(Console.ReadLine()) - 1;
                        Cliente clienteSelecionado = agencia.GetClientes()[indiceCliente];

                        Console.WriteLine("Selecione a Viagem:");
                        agencia.ListarViagens();
                        int indiceViagem = int.Parse(Console.ReadLine()) - 1;
                        Viagem viagemSelecionada = agencia.GetViagens()[indiceViagem];

                        Reserva reserva = new Reserva { Cliente = clienteSelecionado, Viagem = viagemSelecionada };

                        Console.WriteLine("Forma de Pagamento:");
                        Console.WriteLine("1. Cartão");
                        Console.WriteLine("2. Boleto");
                        string formaPagamento = Console.ReadLine();

                        if (formaPagamento == "1")
                        {
                            Console.WriteLine("Número do Cartão:");
                            string numeroCartao = Console.ReadLine();
                            reserva.AdicionarPagamento(new PagamentoCartao { Valor = viagemSelecionada.Preco, NumeroCartao = numeroCartao });
                        }
                        else if (formaPagamento == "2")
                        {
                            Console.WriteLine("Número do Boleto:");
                            string numeroBoleto = Console.ReadLine();
                            reserva.AdicionarPagamento(new PagamentoBoleto { Valor = viagemSelecionada.Preco, NumeroBoleto = numeroBoleto });
                        }

                        agencia.RealizarReserva(reserva);
                        break;

                    case "4":
                        // atualiza a reserva
                       
                        break;

                    case "5":
                        
                        agencia.ListarClientes();
                        break;

                    case "6":
                        
                        agencia.ListarViagens();
                        break;

                    case "7":
                       
                        agencia.ListarReservas();
                        break;

                    case "8":
                        //  reserva por Cliente
                        Console.WriteLine("Selecione o Cliente:");
                        agencia.ListarClientes();
                        int indiceCli = int.Parse(Console.ReadLine()) - 1;
                        Cliente clienteSelect = agencia.GetClientes()[indiceCli];
                        agencia.ListarReservasPorCliente(clienteSelect);
                        break;

                    case "9":
                        
                        Console.WriteLine("Selecione a Reserva:");
                        agencia.ListarReservas();
                        int indiceReserva = int.Parse(Console.ReadLine()) - 1;
                        Reserva reservaSelecionada = agencia.GetReservas()[indiceReserva];
                        agencia.CancelarReserva(reservaSelecionada);
                        break;

                    case "10":
                      
                        Console.WriteLine("Digite o Preço Máximo:");
                        decimal precoMax = decimal.Parse(Console.ReadLine());
                        agencia.FiltrarViagensPorPreco(precoMax);
                        break;

                    case "11":
                        
                        Console.WriteLine("Digite o Destino:");
                        string destinoFiltro = Console.ReadLine();
                        agencia.FiltrarViagensPorDestino(destinoFiltro);
                        break;

                    case "12":
                       
                        Console.WriteLine("1. Viagem Nacional");
                        Console.WriteLine("2. Viagem Internacional");
                        string tipoFiltro = Console.ReadLine();

                        if (tipoFiltro == "1")
                        {
                            agencia.FiltrarViagensPorTipo<ViagemNacional>();
                        }
                        else if (tipoFiltro == "2")
                        {
                            agencia.FiltrarViagensPorTipo<ViagemInternacional>();
                        }
                        break;

                    case "13":
                        // Sair
                        return;
                }
            }
        }
    }
}