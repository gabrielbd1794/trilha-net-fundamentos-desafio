using System.Runtime.CompilerServices;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            //TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaDoVeiculo = Console.ReadLine();
            veiculos.Add(placaDoVeiculo);
            Console.WriteLine($"A placa {placaDoVeiculo} foi adicionada");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placaDoVeiculo = Console.ReadLine();
          
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaDoVeiculo.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                string horasUsuario = Console.ReadLine();
                int horas = 0;
                decimal valorTotal = 0;
                horas = Convert.ToInt32(horasUsuario);
                valorTotal = (precoInicial + precoPorHora) * horas;
                Console.WriteLine($"O preço total foi de {valorTotal}");
                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placaDoVeiculo);

                Console.WriteLine($"O veículo {placaDoVeiculo} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (string veiculoEstacionado in veiculos)
                {
                    Console.WriteLine($"O veículo {veiculoEstacionado} está aqui");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
