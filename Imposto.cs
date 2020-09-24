using System;
using System.Globalization;

class Imposto
{
  private double valorImposto;
  private double nvalorProduto;
  private int ClassMaterial;

  public void retornaDados(int cm)
  {   
    ClassMaterial = cm;
  }

  public void CalculaImposto(double preco)
  {
    if (ClassMaterial == 1)
    {
      valorImposto = (72.18 / 100) * preco;
      nvalorProduto = preco - valorImposto;
    }
  }

  public void ImprimeCalculoImposto()
  {
    Console.WriteLine("Os impostos pagos sobre 'x' são {0}\nO valor do produto seria {1}", valorImposto, nvalorProduto);
  }


  


}