using System;
/* Construa um algoritmo que apresente o nome e o salário dos funcionários, de acordo com
os seguintes critérios:
 Salários que sejam maiores ou iguais a R$ 1000,00 e menores ou iguais a R$ 1500,00
 Funcionários pertencentes aos departamentos de produção ou engenharia.
Obs: Os departamentos são reconhecidos pelas letras (P) Produção e (E) Engenharia São fornecidos o nome do funcionário (NF), o seu salário (SAL) e o departamento onde trabalha (DEP). */
class Program {
  public static void Main (string[] args) {
    string NF, DEP, p = "produção";
    double SAL;
    Console.WriteLine ("Informe seu nome: ");
    NF = Console.ReadLine();
    Console.WriteLine ("Informe seu salario atual: ");
    SAL = Double.Parse(Console.ReadLine());
    Console.WriteLine ("Informe seu departamento, sendo P para produção e E para engenharia: ");
    DEP = Console.ReadLine();
    p = Console.ReadLine();
    if (SAL >= 1000.00 || SAL <= 1500.00){
      if (DEP ==  "p" ||  DEP == "e"){
    {
        Console.Write("O funcionário {0} ", NF);
        Console.WriteLine("recebe um salário de: R${0:F2} ", SAL);
        Console.Write ("e trabalha no departamento {0}", DEP); 
    }
    }   
  }
}
}


