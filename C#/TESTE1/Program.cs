using System;



namespace TESTE1
{
    class Program
    {
        static void Main(string[] args)
        {               

			Banco conta;
			
			Console.WriteLine("Bem vindo ao gerenciador de contas bancárias");

			Console.WriteLine("Digite o número da conta: ");
			int numeroConta = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite o nome do titular da conta: ");
			string titular = Console.ReadLine();

			Console.WriteLine("Haverá depósito inicial (s/n)? ");

			if(Console.ReadLine() == "s" || Console.ReadLine() == "S"){
				Console.WriteLine("Digite o valor do depósito inicial: ");
				double saldo = double.Parse(Console.ReadLine());
				 conta = new Banco(numeroConta, titular, saldo);
			}else{
				 conta = new Banco(numeroConta, titular);
			}

			Console.WriteLine("Dados da conta: ");
			Console.WriteLine(conta);

        }
    }
}
