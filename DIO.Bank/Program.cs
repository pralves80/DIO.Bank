using System;

namespace DIO.Bank
{
	class Program
	{
		static void Main(string[] args)
		{
			string opcaoUsuario = ObterOpcaoUsuario();

			//Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Pietro Alves");
			//Console.WriteLine(minhaConta.ToString());			
		}

		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Bank ao seu dispor!");
			Console.WriteLine("Informe a Opção desejada:");

			Console.WriteLine("1 - Listar Conta(s)");
			Console.WriteLine("2 - Inserir Nova Conta");
			Console.WriteLine("3 - Transferir");
			Console.WriteLine("4 - Sacar");
			Console.WriteLine("5 - Depositar");
			Console.WriteLine("C - Limpar Tela");
			Console.WriteLine("X - Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
}
