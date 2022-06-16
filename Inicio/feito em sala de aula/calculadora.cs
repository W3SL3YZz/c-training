using System;

class Program {
  public static void Main (string[] args) {
    char opcao;
    double n1, n2, tt;
    Console.Write("Digite o 1- Valor: ");
    n1=double.Parse(Console.ReadLine());
    Console.WriteLine("╔═══════════════════╗");
    Console.WriteLine("║ + (A)dição        ║");
    Console.WriteLine("║ - (S)ubtração     ║");
    Console.WriteLine("║ * (M)ultiplicação ║");
    Console.WriteLine("║ / (D)ivisão       ║");
    Console.WriteLine("╚═══════════════════╝");
    Console.Write("Digite a opção: ");
    opcao=char.Parse(Console.ReadLine().ToUpper());
    Console.WriteLine("");
    Console.Write("Digite o 2- Valor: ");
    n2=double.Parse(Console.ReadLine());
    
    switch(opcao)
    {
      case '+':
      case 'A':
        tt=n1+n2;
        Console.WriteLine("{0} + {1} = {2}",n1,n2,tt);
      break;
      case '-':
      case 'S':
        tt=n1-n2;
        Console.WriteLine("{0} - {1} = {2}",n1,n2,tt);
      break;
      case '*':
      case 'M':
        tt=n1*n2;
        Console.WriteLine("{0} * {1} = {2}",n1,n2,tt);
      break;
      case '/':
      case 'D':
        if(n2!=0)
        {
          tt=n1/n2;
          Console.WriteLine("{0} / {1} = {2:F2}",n1,n2,tt);
        }
        else
          Console.WriteLine("Divisão por Zero!");
      break;
      default:
        Console.WriteLine("Opção inválida!");
      break;
    }
  }
}