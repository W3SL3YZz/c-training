using System;
/* Construa um algoritmo que leia o valor de uma conta de luz (CL) e, caso o valor seja maior que R$ 50,00 apresente a mensagem: “Você está gastando muito”. Caso contrário não exiba mensagem nenhuma. */

class Program {
  public static void Main (string[] args) {
    double cl;
    Console.WriteLine ("Digite o valor da sua ultima conta de luz");
    cl = Double.Parse(Console.ReadLine());
    if (cl > 50)
      Console.WriteLine("Você está gastando muito");
      else;
          }
}