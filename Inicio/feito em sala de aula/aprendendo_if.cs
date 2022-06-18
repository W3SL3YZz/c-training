using System;
/* faça um programa que realize uma multiplicação, porém, o usuário coloca o primeiro número (A) que será multiplicado, e o segundo número que será por quanto o primeiro número é multiplicado.
Se o resultado  formaior que 150, ele apresenta a mensagem " eu consegui " caso contrário, apresentara a mensagem " eu consegui fazer " */
class Program {
  public static void Main (string[] args) {
    int A, B;
    Console.WriteLine ("Digite o primeiro numero");
    A = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite por quanto o número acima será multiplicado");
    B = int.Parse(Console.ReadLine());

    if (B >= 150){
      A = A * B;
      Console.WriteLine("Eu consegui");
    }
      else if (B < 150){
        A = A * B;
        Console.WriteLine("Eu consegui fazer");
      }
    }
  }
