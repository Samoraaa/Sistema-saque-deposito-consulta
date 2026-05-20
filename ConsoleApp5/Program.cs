float saldo, depositoInformado, saqueInformado;
int opcao;
saldo = 1000;
while (true)
{
    Console.WriteLine("1 - deseja ver seu saldo?\n2 - deseja depositar?\n3 - deseja realizar saque?\n4 - finalizar sessão?");
    opcao = Convert.ToInt32(Console.ReadLine());
    if (opcao == 1)
    {
        Console.WriteLine("Seu saldo é " + saldo);
    }
    else if (opcao == 2)
    {
        Console.WriteLine("quanto deseja depositar?");
        depositoInformado = Convert.ToSingle(Console.ReadLine());
        saldo += depositoInformado;
    }
    else if (opcao == 3)
    {
        Console.WriteLine("quanto deseja sacar?");
        saqueInformado = Convert.ToSingle(Console.ReadLine());
        if(saqueInformado > saldo)
        {
            Console.WriteLine("Saldo insuficiente!");
        }
        else
        {
            saldo -= saqueInformado;
        }
    }
    else if(opcao==4)
    {
        break;
    }
    else
    {
        Console.WriteLine("Escolha um valor valido");
    }
}