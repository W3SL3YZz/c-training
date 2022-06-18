using System;
/* Construa um algoritmo que leia o preço de um produto (P) e apresente a mensagem: “Em
promoção”, caso o preço seja maior ou igual a R$ 50,00 e menor ou igual a R$ 100,00.
Caso contrário, deve apresentar a mensagem: “Preço Normal”. */
class Program {
  public static void Main (string[] args) {
    double P;
    Console.WriteLine("Informe o número do produto");
    P = Double.Parse(Console.ReadLine());
    
    if (P >= 50.00 && P <=100.00)
    {
      Console.WriteLine("Em promoção");
    }
    else 
    {
      Console.WriteLine("Preço normal");
     }
  }
}