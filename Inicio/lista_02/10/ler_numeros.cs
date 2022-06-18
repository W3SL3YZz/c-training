using System;
/* Construa um algoritmo que leia dois números (A e B). Caso A seja igual a B, apresentar a soma dos dois. Caso um seja maior que o outro, apresentar a diferença entre os dois números (sempre lembrando que a diferença entre dois números é SEMPRE positiva).*/
class Program {
  public static void Main (string[] args) {
    double A, B, total;
    Console.WriteLine ("Digite o primeiro número");
    A = Double.Parse(Console.ReadLine());

    Console.WriteLine ("Digite o segundo número");
    B = Double.Parse(Console.ReadLine());

    if (A == B){
     total = A + B;
      Console.WriteLine("A soma dos números é: {0}", total);
    }
    else if (A < B){
      total = B - A;
      Console.WriteLine("A soma dos números é: {0}", total);
    }
      else 
      {
      total = A - B;
      Console.WriteLine ("A diferença entre os números é de: {0}", total);
    }
  }
}