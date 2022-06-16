using System;
 /* E.1.P no qual exiba a exponencial da base e do expoente digitado pelo usuario, exiba o valor de PI e raiz"*/
class Program {
  public static void Main (string[] args) {
   
    double numb, nume, total, raiz; 
    Console.Write ("Digite o valor da base: "); 
    numb = double.Parse(Console.ReadLine());
    Console.Write ("Digite o valor do expoente: ");
    nume = double.Parse(Console.ReadLine());
    total = Math.Pow(numb,nume);
    Console.WriteLine ("O resultado: {0}", total);
    Console.WriteLine ();
    Console.WriteLine ("Você sabe o valor de PI?");
    Console.WriteLine ("PI vale: {0:F2}", Math.PI);
    Console.WriteLine ();
    Console.Write ("Digite o valor da raiz: ");
    raiz = double.Parse(Console.ReadLine());
    total = Math.Sqrt(raiz);
    Console.WriteLine ("O resultado: {0:F2}", total);


  }
}