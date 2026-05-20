using System;

namespace ContaCorrente.ConsoleApp.Entidades;

public class Conta
{


    public int id;
    public string titular;
    public decimal saldo;
    public decimal limiteDebito;

    public void Sacar(decimal valorSaque)
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

    public void Depositar(decimal valorDeposito)
    {
        saldo += valorDeposito;

        Console.WriteLine($"O Deposito de R$ {valorDeposito} foi efetuado com sucesso! ");
        Console.ReadLine();
    }

    public void Transferir(decimal valorTransferencia, Conta contaDestino)
    {

        decimal limiteSaque = saldo + limiteDebito;

        if (valorTransferencia > limiteSaque)
        {
            Console.WriteLine("Não é possivel Fazer o Transferencia, SALDO insuficiente! ");
            Console.ReadLine();
            return;
        }

        this.Sacar(valorTransferencia);
        contaDestino.Depositar(valorTransferencia);

    }

    public void VisualizarSaldo()
    {

        Console.WriteLine($"O saldo da conta do {titular} é: R$ {saldo}");
        Console.ReadLine();
    }


}
