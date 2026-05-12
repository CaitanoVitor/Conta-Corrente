
int id = 1;
decimal saldo = 2200;
decimal limiteDebito = 1000;

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

        decimal limiteSaque = saldo + limiteDebito;

        if (valorSaque > limiteSaque)
        {
            Console.WriteLine("Não é possivel Fazer o saque, SALDO insuficiente! ");
            Console.ReadLine();
            continue;
        }

        saldo -= valorSaque;

        Console.WriteLine($"O saque da R$ {valorSaque} foi efetuada com sucesso! ");
        Console.ReadLine();

    }
    else if (opcaoMenu == "2")
    {

    }
    else if (opcaoMenu == "3")
    {

    }
}