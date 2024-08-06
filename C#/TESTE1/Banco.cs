using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TESTE1
{
	public class Banco
	{

		public string Titular { get; set; }

		public double Saldo { get; private set; }

		public int NumeroConta { get; private set; }

		public Banco(int numeroConta, string titular)
		{
			NumeroConta = numeroConta;
			Titular = titular;
		}

		public Banco(int numeroConta, string titular, double Saldo) : this(numeroConta, titular)
		{
			this.Saldo = Saldo;
		}
		//MÉTODO PARA RENDERIZAR NOSSO OBJETO DE FORMA MAIS SIMPLES
        public override string ToString()
        {
            return "Titular da Conta: " + Titular + "\n"
                    +"Numero da Conta: " + NumeroConta + "\n"
                    +"Saldo da Conta: "+ Saldo + "R$";
                    
        }

	}


}