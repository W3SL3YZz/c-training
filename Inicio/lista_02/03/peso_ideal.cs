using System;
/* Construa um algoritmo que, tendo como dados de entrada a altura (H) e o sexo (S) de
uma pessoa calcule e apresente seu peso ideal utilizando as seguintes fórmulas:
Para homens: Peso ideal (P) = (72,7 * H) – 58
Para mulheres: Peso ideal (P) = (62,1 * H) – 44,7 */
class Program {
  public static void Main (string[] args) {
    string S;
    double H,P;
    
    Console.WriteLine ("Digite a sua altura: ");
    H = Double.Parse(Console.ReadLine());
    
    Console.WriteLine ("Informe o sexo, sendo M para masculino ou F para feminino: ");
    S = Console.ReadLine(); 
    
    if (S == "M")
    {
    P = (62.1 * H) - 44;
    Console.WriteLine("O seu peso ideal é: {0}", P);
    }
    else if (S == "F")
    {
      P = (62.1 * H) - 44.7;
      Console.WriteLine("O seu peso ideal é: {0}", P);
    }
  }
}