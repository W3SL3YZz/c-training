using System;
/* Construa um algoritmo que calcule o novo salário (SAL_NOVO) de um funcionário. Considere que o funcionário deverá receber um reajuste de 15% caso seu salário (SAL) seja menor que 500. Se o salário for maior ou igual a 500, mas menor ou igual a 1000, o reajuste deve ser de 10%. Caso o salário seja maior que 1000, o reajuste deve ser de 5%. */
class Program {
  public static void Main (string[] args) {
    double SAL_NOVO, sal;
    Console.WriteLine ("Digite seu salario");
    sal = Double.Parse(Console.ReadLine());

    if (sal <500){
      SAL_NOVO = (sal * 0.15) + sal;
      Console.WriteLine("Seu salário após o aumento de 15% é: R${0:F2}", SAL_NOVO);
    }
    else if (sal >=500 && sal <=1000)
    {
    SAL_NOVO = (sal * 0.10) + sal;
    Console.WriteLine("Seu salário após o aumento de 10% é: R${0:F2}", SAL_NOVO);}
      else if (sal >1000){
        SAL_NOVO = (sal * 0.5) + sal;
        Console.WriteLine("Seu salário após o aumento de 5% é: R${0:F2}", SAL_NOVO);
      }
  }
    }  