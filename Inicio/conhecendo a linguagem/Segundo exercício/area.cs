using System;
/* Faça o algoritmo (diagrama de blocos e português estruturado) para calcular a área (AREA) de uma sala, sendo que os comprimentos das paredes (L e C) são fornecidos pelo usuário. Apresente a área depois de calculada. */
class Program {
  public static void Main (string[] args) {
   double AREA, L, C;
    Console.Write ("Digite o Valor do comprimento: ");
    L = Double.Parse(Console.ReadLine());
    Console.Write ("Digite o valor da largura: ");
    C = Double.Parse(Console.ReadLine());

    AREA = L * C;
    Console.WriteLine ("O valor da Area é: {0}", AREA);   
  }
}
