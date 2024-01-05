using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

//USUÁRIO INSERE PREÇO INICIAL DA COBRANÇA
Console.WriteLine("SEJA BEM VINDO AO SISTEMA DE ESTACIONAMENTO!!!");

decimal precoInicial = -1;
while (precoInicial < 0)
{
    Console.WriteLine("Digite o preço inicial: ");
    precoInicial = decimal.Parse(Console.ReadLine());
    if (precoInicial < 0)
    {
        Console.WriteLine("Preço não pode ser menor que zero!!");
    }
}

//USUÁRIO INSERE PREÇO POR HORA DA COBRANÇA
decimal precoPorHora = -1;
while (precoPorHora < 0)
{
    Console.WriteLine("Agora digite o preço por hora: ");
    precoPorHora = decimal.Parse(Console.ReadLine());
    if (precoPorHora < 0)
    {
        Console.WriteLine("Preço não pode ser menor que zero!!");
    }
}

//CLASSE É ESTANCIADA
Estacionamento e1 = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

//O MENU É INICIADO
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");


    switch (Console.ReadLine())
    {
        case "1":
            e1.AdicionarVeiculo();
            break;

        case "2":
            e1.RemoverVeiculo();
            break;

        case "3":
            e1.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;

    }
    Console.WriteLine("Pressione enter para continuar");
    Console.ReadLine();
}
