using System.ComponentModel;

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
        public string placaVeiculo;

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placaVeiculo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(placaVeiculo))
            {
                Console.WriteLine("Erro, tente novamente");
            }
            else if (veiculos.Contains(placaVeiculo))
            {
                Console.WriteLine("Esse veículo já está estacionado!");
            }

            else
            {
                veiculos.Add(placaVeiculo);
                Console.WriteLine($"Veiculo com a placa {placaVeiculo} adicionado com sucesso!");
            }
            
        }

        public void RemoverVeiculo()
        {
            string placa = placaVeiculo;
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();

            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                decimal valorTotal = 0; 
                int horas = 0;

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = int.Parse(Console.ReadLine());
                
                valorTotal = (precoPorHora * horas) + precoInicial ;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                for (int contador = 0; contador < veiculos.Count; contador++)
                {
                     Console.WriteLine("Os veículos estacionados são:");
                    Console.WriteLine($"Vaga n° {contador + 1} e placa: {veiculos[contador]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
