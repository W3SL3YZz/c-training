using System;
/* Construa um algoritmo que receba a leitura do termômetro (T). Caso a temperatura esteja abaixo de 100oC, apresentar a mensagem de que a temperatura está muito baixa. Caso a temperatura esteja entre 100oC e 200oC (inclusive), apresentar a mensagem de que a temperatura está baixa. Caso a temperatura esteja acima de 200oC e inferior a 500oC, apresentar a mensagem de que a temperatura está normal. Caso contrário, apresentar a mensagem de que a temperatura está muito alta. */
class Program {
  public static void Main (string[] args) {
    int T=0;
    Console.WriteLine ("Digite a temperatura em graus Celsius: ");
    T = int.Parse(Console.ReadLine());

    if (T < 100)
      Console.WriteLine("A temperatura está muito baixa");
    else  
      if (T >= 100 && T <= 200)
        Console.WriteLine("A temperatura está baixa");
    else 
      if (T >200 && T < 500)
        Console.WriteLine("A temperatura está normal");
    else
    {
      Console.WriteLine("A temperatura está muito alta");
    }
  }
}