using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Imposto i = new Imposto();
    Produto p = new Produto();
    Dadosadic da = new Dadosadic();
    
    da.Titulo();
    p.listaTipoMaterial();    

    Console.Write("Digite o código respectivo ao TIPO DE PRODUTO desejado: ");
    i.ClassMaterial = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Abaixo, preencha os dados do Produto");

    Console.Write("Nome: ");
    p.Nome = Console.ReadLine();
    Console.Write("Marca: ");
    p.Marca = Console.ReadLine();
    Console.Write("Preço: R$");
    p.Preco = double.Parse(Console.ReadLine());
    
    p.imprimeProd();
    i.CalculaImposto(p.Preco);
    i.ImprimeCalculoImposto();

    da.Infofinal();
  }
}