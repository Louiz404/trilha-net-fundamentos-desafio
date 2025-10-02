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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
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
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*

            string placa = placaVeiculo;
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();

            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*

                decimal valorTotal = 0; 
                int horas = 0;

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = int.Parse(Console.ReadLine());
                
                valorTotal = (precoPorHora * horas) + precoInicial ;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

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
                
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
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
