using System;

class Program
{
    public static void Main(string[] args)
    {
        /*int cont;
          for(cont=0;cont<=10;cont++) //cont++  <==> cont=cont+1
            {
              Console.WriteLine (cont);
            }
        */
        int i, inicio, final, passo, tenta = 3;
        Console.WriteLine("Digite o inicio: ");
        inicio = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o final: ");
        final = int.Parse(Console.ReadLine());

        //Repetição da validação do passo
        do
        {
            Console.WriteLine("Digite o passo: ");
            passo = int.Parse(Console.ReadLine());
            if (passo <= 0 && tenta > 0) //passo negativo e tentativas válidas
            {
                Console.WriteLine("Digite valor maior que zero!");
                tenta--; //tenta=tenta-1 -- retiro um tentativa
                if (tenta > 0) // ainda resta tentativas
                    Console.WriteLine("Possui apenas {0} tentativas", tenta);
                else // acabou as tentativas
                    Console.WriteLine("Acabou as tentativas");
            }
        } while (passo <= 0 && tenta > 0); //validação do passo

        if (passo > 0) //Vai fz a repetição apenas com passo positivo
        {
            for (i = inicio; i <= final; i = i + passo)
            {
                Console.WriteLine(i);
            }
        }
        else
            Console.WriteLine("ERROR de parametros");
    }
}