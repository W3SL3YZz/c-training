using System;
using System.Threading; // precisa da biblioteca para usar o Sleep

class Program {
  public static void Main (string[] args) {
    char op;
    int t, h, m, s, hd,md,sd, mf,sf;
    Console.Clear();
    do{
      Console.WriteLine("╔══════════════════════════════════════╗");
      Console.WriteLine("║ CRONOMETRO REGRESSIVO OU PROGRESSIVO ║");
      Console.WriteLine("╚══════════════════════════════════════╝");
      Console.WriteLine("");
      Console.WriteLine("Escolha a opção desejada:");
      Console.WriteLine("");
      Console.WriteLine("1 - Cronometro \x1B[4mP\x1B[0mrogressivo");
      Console.WriteLine("2 - Cronometro \x1B[4mR\x1B[0megressivo");
      Console.WriteLine("");
      Console.Write("Digite a opção: ");
      op=char.Parse(Console.ReadLine().ToUpper());
      if(op!='P' && op!='R' && op!='1' && op!='2')
      { //validação das opções para emissão de mensagem
        t=5;
        do{
          Console.Clear();
          Console.WriteLine ("Opção Inválida - Aguarde {0} segundo(s)",t);
          Thread.Sleep(1000);
          t--;
        }while(t>0); // repetição para temporizador
        Console.Clear();
      }
    }while(op!='P' && op!='R' && op!='1' && op!='2');
    if(op=='P' || op=='1')
    {
      Console.Clear();
      Console.WriteLine("╔════════════════════════╗");
      Console.WriteLine("║ CRONOMETRO PROGRESSIVO ║");
      Console.WriteLine("╚════════════════════════╝");
      Console.WriteLine("");
      Console.Write("Digite a hora limite: ");
      hd=int.Parse(Console.ReadLine());
      Console.Write("Digite o minuto limite: ");
      md=int.Parse(Console.ReadLine());
      Console.Write("Digite o segundo limite: ");
      sd=int.Parse(Console.ReadLine());
      Console.WriteLine("");
      for(h=0;h<=hd;h++)
      {
        if(h<hd)
          mf=59;
        else
          mf=md;
        for(m=0;m<=mf;m++)
        {
          if(h<hd)
            sf=59;
          else
            if(m<md)
              sf=59;
            else
              sf=sd;
          for(s=0;s<=sf;s++)
          {
            Console.Clear();
            Console.WriteLine ("{0:D2}:{1:D2}:{2:D2}",h,m,s);
            Thread.Sleep(1000); //Aguarda 1000 milisegundos = 1 segundo
          }
        }
      }
    }
    if(op=='R' || op=='2')
    {
      Console.Clear();
      Console.WriteLine("╔═══════════════════════╗");
      Console.WriteLine("║ CRONOMETRO REGRESSIVO ║");
      Console.WriteLine("╚═══════════════════════╝");
      Console.WriteLine("");
      Console.Write("Digite a Hora: ");
      hd=int.Parse(Console.ReadLine());
      Console.Write("Digite o minuto: ");
      md=int.Parse(Console.ReadLine());
      Console.Write("Digite o segundo: ");
      sd=int.Parse(Console.ReadLine());
      for(h=hd;h>=0;h--)
      {
        for(m=md;m>=0;m--)
        {
          for(s=sd;s>=0;s--)
          {
            Console.Clear();
            Console.WriteLine ("{0:D2}:{1:D2}:{2:D2}",h,m,s);
            Thread.Sleep(1000); //Aguarda 1000 milisegundos = 1 segundo
          }
          if(m>=0)
            sd=59;
        }
        if(h>=0)
          md=59;
      }
    }
  }
}