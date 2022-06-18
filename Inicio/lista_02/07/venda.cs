using System;
/* Construa um algoritmo que, recebendo os valores de vendas do mês de determinado
vendedor (VM) e o nome do mesmo (NOME), apresente o nome, quando o valor da venda
estiver entre R$ 10000,00 e R$ 50000,00 (inclusive). */
class Program {
  public static void Main (string[] args) {
    string NOME;
    double VM;
    Console.WriteLine ("Digite o nome do vendedor: ");
    NOME = Console.ReadLine();
    Console.WriteLine ("Digite o valor vendido pelo vendedor");
    VM = Double.Parse(Console.ReadLine());

    if (VM >= 10000.00 && VM <= 50000.00)
    {
      Console.Write("O vendedor {0}", NOME); 
      Console.WriteLine(" vendeu um valor de R${0:F2}",VM);
    }
  }
}