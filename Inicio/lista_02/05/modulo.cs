using System;
/* Construa um algoritmo que leia um número inteiro (positivo ou negativo) e apresente o seu
módulo (número sem sinal). */
class Program {
  public static void Main (string[] args) {
    int num;
    Console.WriteLine ("Veja o módulo de um determinado número");
    Console.WriteLine("Digite o número: ");
    num = int.Parse(Console.ReadLine());
    if (num <0)
    {
      num = num * -1;
      Console.WriteLine("O módulo do seu número é: {0}", num);
    }
    else if (num >0)
      {
    num = num * 1; 
    Console.WriteLine("O módulo do seu número é: {0}", num);
  }
  }
}