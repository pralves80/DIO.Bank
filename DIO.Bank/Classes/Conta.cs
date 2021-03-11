using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Bank
{
	class Conta
	{		
		private TipoConta TipoConta { get; set; }
		private double Saldo { get; set; }
		private double Credito { get; set; }
		private string Nome { get; set; }

		public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
		{
			TipoConta = tipoConta;
			Saldo = saldo;
			Credito = credito;
			Nome = nome;
		}

		public bool Sacar(double valorSaque)
		{ // Validar saldo da conta
			if (this.Saldo - valorSaque < (this.Credito * -1))
			{
				Console.WriteLine("Saldo Insuficiente");
				return false;
			}
			this.Saldo -= valorSaque;
			Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);

			return true;
		}

		public void Depositar(double valorDeposito)
		{
			this.Saldo += valorDeposito;

			Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
		}

		public void Transferir(double valorTranferencia, Conta contaDestino)
		{
			if (this.Sacar(valorTranferencia))
			{
				contaDestino.Depositar(valorTranferencia);
			}
		}

		public override string ToString()
		{
			string retorno = "";
			retorno += "TipoConta.: " + this.TipoConta + " | ";
			retorno += "Nome.: " + this.Nome + " | ";
			retorno += "Saldo.: R$ " + this.Saldo + " | ";
			retorno += "Credito.: R$ " + this.Credito + " | ";
			return retorno;
		}
	}
}
