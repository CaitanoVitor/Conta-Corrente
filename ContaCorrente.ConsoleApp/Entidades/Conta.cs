using System;

namespace ContaCorrente.ConsoleApp.Entidades;

public static class Conta
{


public static int id = 1;
public static decimal saldo = 2200;
public static decimal limiteDebito = 1000;

public static void Sacar(decimal valorSaque)
    {
            decimal limiteSaque = saldo + limiteDebito;

        if (valorSaque > limiteSaque)
        {
            Console.WriteLine("Não é possivel Fazer o saque, SALDO insuficiente! ");
            Console.ReadLine();
            return;
        }

        saldo -= valorSaque;

        Console.WriteLine($"O saque da R$ {valorSaque} foi efetuada com sucesso! ");
        Console.ReadLine();

    }

    public static void Depositar(decimal valorDeposito)
    {
         saldo += valorDeposito;

        Console.WriteLine($"O Deposito de R$ {valorDeposito} foi efetuado com sucesso! ");
        Console.ReadLine();
    }
  public static void VisualizarSaldo()
    {
        
        Console.WriteLine($"O saldo da conta é: R$ {saldo}");
        Console.ReadLine();
    }


}
