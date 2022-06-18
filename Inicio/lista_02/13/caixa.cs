using System;
/* Construa um algoritmo que leia a quantidade de dinheiro existente no caixa de uma empresa (CAIXA), a quantidade de produtos a ser comprada (QTD) e o preço de cada unidade (PR). Caso o valor total da compra seja superior a 80% do valor em caixa, a compra deve ser feita a prazo (3x), com juros de 10% sobre o valor total. Caso contrário, a compra deverá ser realizada a vista, onde a empresa receberá 5% de desconto. Apresentar a forma de pagamento escolhida e o valor a ser pago (total a vista ou total a prazo), dependendo da escolha realizada pelo programa. */
class Program {
  public static void Main (string[] args) {
    double caixa, qtd, pr, ttcomp, vend;
    Console.WriteLine ("Informe o valor em caixa: ");
    caixa = double.Parse(Console.ReadLine());
    Console.WriteLine("Quantos produtos serão comprados? ");
    qtd = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o preço da unidade: ");
    pr = double.Parse(Console.ReadLine());
    ttcomp = qtd * pr;
    vend = caixa * 0.8;
      
    if (ttcomp > vend) {
      vend = ttcomp + (ttcomp * 0.10);
      Console.WriteLine("O valor do pagamento será de R${0:F2}, a forma de pagamento será em 3x:", vend);
    }
    else{
      vend = ttcomp - (ttcomp * 0.05);
      Console.WriteLine("O valor do pagamento será de R${0:F2}, a forma de pagamento será avista", vend);
    }        
      }
    }