namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial { get; set; }
        private decimal precoPorHora { get; set; }
        private List<string> Veiculos = new List<string>();


        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            Veiculos.Add(Console.ReadLine());
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = int.Parse(Console.ReadLine());
                Veiculos.Remove(placa);
                decimal precoTotal = precoInicial + (horas * precoPorHora);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {precoTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Conifra se digitou a placa corretamente ");
            }
        }
        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string item in Veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
                Console.WriteLine("Tecle enter para continuar:");
                Console.ReadLine();
            }


        }
    }
}
