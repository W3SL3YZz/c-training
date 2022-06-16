using System;
/* Converter graus Celsius em Fahrenheit */
class Program {
  public static void Main (string[] args) {
    Double F,C;
    Console.WriteLine ("Digite a temperatura em Celsius: ");
    C = Double.Parse(Console.ReadLine());
    F = (9 * C + 160) / 5;
    Console.WriteLine ("A temperatura digitada convertida em Fahrenheit é: {0}", F);
  }
}