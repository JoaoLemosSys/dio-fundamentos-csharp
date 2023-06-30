
using Dio_Estacionamento.Models;


Console.WriteLine("Estacionamento");
Console.WriteLine("Digite o valor inicial:");
float ValorInicial = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da hora:");
float ValorPorHora = float.Parse(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(ValorInicial, ValorPorHora);


int opcao = 0;

while (opcao != 4)
{


    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastra veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");


    opcao = Int32.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Opcao1");
            Console.WriteLine("Digite a placa do veiculo para cadastrar:");
            String placaParaAdicionar = Console.ReadLine();
            estacionamento.Incluir(placaParaAdicionar);
            break;
        case 2:
            Console.WriteLine("Opcao2");
            Console.WriteLine("Digite a placa do veiculo para remover:");
            String placaParaRemover = Console.ReadLine();
            Console.WriteLine("Digite o número de horas estacionado:");
            int horasEstacionado = int.Parse(Console.ReadLine());
            double Total = estacionamento.Calcular(horasEstacionado);
            estacionamento.Remover(placaParaRemover);
            Console.WriteLine($"O veiculo {placaParaRemover} foi removido e deve pagar {Total}");

            break;
        case 3:
            Console.WriteLine("Opcao3");
            estacionamento.Listar();
            break;
        case 4:
            Console.WriteLine("Saindo");
            break;

    }

    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadKey();
    Console.Clear();


}
