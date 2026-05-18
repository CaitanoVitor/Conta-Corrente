
using ContaCorrente.ConsoleApp.Entidades;

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"Conta Corrente");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("1 - Saque");
    Console.WriteLine("2 - Depósito");
    Console.WriteLine("3 - Consulta de Saldo");
    Console.WriteLine("S - Sair");
    Console.WriteLine("---------------------------------------------");
    Console.Write("> ");
    string? opcaoMenu = Console.ReadLine();

    if (opcaoMenu?.ToUpper() == "S")
        break;

    if (opcaoMenu == "1")
    {
        Console.WriteLine("Digite o valor do Saque: R$");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        Conta.Sacar(valorSaque);
    }
    else if (opcaoMenu == "2")
    {
        Console.WriteLine("Digite o valor do Deposito: R$");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());


        Conta.Depositar(valorDeposito);

    }
    else if (opcaoMenu == "3")
    {

        Conta.VisualizarSaldo();

    }
}