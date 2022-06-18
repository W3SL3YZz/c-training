using System;
/* Construa um algoritmo que determine quanto será gasto para encher o tanque de um carro (VG), sabendo-se que o preço da gasolina é de R$ 1,80 e o preço do álcool é de R$ 1,00. O
usuário fornecerá os seguintes dados: Tipo de carro (TC) (G – gasolina ou A – álcool) e
Capacidade do tanque (CT), em litros. */

class Program {
  public static void Main (string[] args) {
    string TC;
    double CT,VG;
  Console.WriteLine ("Digite o tipo de combustivel do seu carro: ");
  TC = Console.ReadLine();
    
  Console.WriteLine ("agora me informe a capacidade do tanque: "); 
  CT = Double.Parse(Console.ReadLine()); 
  if (TC == "gasolina")
  {
    VG = CT * 1.80; /* valor da gasolina*/
    Console.WriteLine("A capacidade do seu tanque é de: {0}L ", CT);
    Console.WriteLine("O valor gasto para encher seu tanque é de: R${0:F2}", VG);
  }
  else if (TC == "alcool")
  {
    VG = CT * 1.00; /* valor do alcool*/
    Console.WriteLine("A capacidade do seu tanque é de: {0}L ", CT);
    Console.WriteLine("O valor gasto para encher seu tanque é de: R${0:F2}", VG);
  }
  }
}