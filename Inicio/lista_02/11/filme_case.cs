using System;
/* Construa um algoritmo que leia o código de um livro (CL) e apresente a categoria do livro,
conforme a tabela abaixo:
Código do Livro (CL) Categoria
A Ficção
B Não-Ficção
Qualquer outro código Inválido*/
class Program {
  public static void Main (string[] args) {
    char codigo;
    Console.WriteLine ("Digite o código do seu livro");
    codigo = char.Parse(Console.ReadLine().ToUpper());
    Console.WriteLine("╔═══════════════════╗");
    Console.WriteLine("║ A        Ficção   ║");
    Console.WriteLine("║ B      Não-Ficção ║");
    Console.WriteLine("║                   ║");
    Console.WriteLine("╚═══════════════════╝");
  switch(codigo)
  {
  case 'a':
  Console.WriteLine("o livro está na categoria Ficção");
  break;
    case 'B':
    case 'b':
  Console.WriteLine ("o livro está na categoria Não-Ficção");
  break;
  }
    default:
        Console.WriteLine("Opção inválida!");
      break;
  }
}
}