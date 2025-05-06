namespace DesafioFundamentos.Models{
    public class Estacionamento{
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(){
            string aux;
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            aux = Console.ReadLine();
            if(!veiculos.Contains(aux.ToUpper())){
                veiculos.Add(aux.ToUpper());
            }
            else{
                Console.WriteLine("Esse veículo já está estacionado!");
            }

        }

        public void RemoverVeiculo(){
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = "";
            placa = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())){
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = 0;
                decimal valorTotal = 0;
                horas = int.Parse(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora * horas);
                veiculos.Remove(placa.ToUpper());
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else{
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos(){
            int cont = 1;
            if (veiculos.Count != 0){
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string veiculo in veiculos){
                    Console.WriteLine($"{cont} - {veiculo}");
                    cont++;
                }
            }
            else{
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
