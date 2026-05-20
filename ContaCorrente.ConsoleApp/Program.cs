
using ContaCorrente.ConsoleApp.Entidades;


Conta contaVitor = new Conta();
contaVitor.id = 1;
contaVitor.titular = "Vitor";
contaVitor.saldo = 5000;
contaVitor.limiteDebito = 800;

Conta contaThiago = new Conta();
contaThiago.id = 2;
contaThiago.titular = "Thiago";
contaThiago.saldo = 3100;
contaThiago.limiteDebito = 800;

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"Conta Corrente");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("1 - Saque");
    Console.WriteLine("2 - Depósito");
    Console.WriteLine("3 - Transferencia");
    Console.WriteLine("4 - Consulta de Saldo");
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

        contaVitor.Sacar(valorSaque);
    }
    else if (opcaoMenu == "2")
    {
        Console.WriteLine("Digite o valor do Deposito: R$");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());


        contaVitor.Depositar(valorDeposito);

    }
    else if (opcaoMenu == "3")
    {
        Console.WriteLine("Digite o valor para transferir: R$");
        decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

        contaVitor.Transferir(valorTransferencia, contaThiago);
    }
    else if (opcaoMenu == "4")
    {

        contaVitor.VisualizarSaldo();

    }
}