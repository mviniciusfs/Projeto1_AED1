using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Imposto p = new Imposto();

    p.retornaDados(1);

    p.CalculaImposto(75);

    p.ImprimeCalculoImposto();
  }
}