using System;
using System.Globalization;
/*
PRODUTOS	       COD           IPI	        TOTAL
Videogames     	 = 1           30%	        72,18%
Relógios	       = 2           25%	        56,14%
Geladeiras	     = 3           15%	        46,21%
Televisores	     = 4           15%	        44,94%
Máquina de lavar = 5            5%	        42,56%
Celulares	       = 6           15%	        39,80%
Notebooks	       = 7           15%	        38,62%
Automóveis	     = 8                        54,00%
Roupas	         = 9                        34,00%
Perfumes 	       = 10                       75,00%
Medicamentos	   = 11                       33,00%
Energia Resid.   = 12           	          48,00%
Água Residencial = 13         	            24,00%
*/

class Imposto
{
  private double valorImposto;
  private double nvalorProduto;
  private double porcentImposto;
  public int ClassMaterial;

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
      porcentImposto = (valorImposto / preco) * 100;
    }

    if (ClassMaterial == 2)
    {
      valorImposto = (56.14 / 100) * preco;
      nvalorProduto = preco - valorImposto;
      porcentImposto = (valorImposto / preco) * 100;
    }

    if (ClassMaterial == 3)
    {
      valorImposto = (46.21 / 100) * preco;
      nvalorProduto = preco - valorImposto;
      porcentImposto = (valorImposto / preco) * 100;
    }

    if (ClassMaterial == 4)
    {
      valorImposto = (44.94 / 100) * preco;
      nvalorProduto = preco - valorImposto;
      porcentImposto = (valorImposto / preco) * 100;
    }

    if (ClassMaterial == 5)
    {
      valorImposto = (42.56 / 100) * preco;
      nvalorProduto = preco - valorImposto;
      porcentImposto = (valorImposto / preco) * 100;
    }

    if (ClassMaterial == 6)
    {
      valorImposto = (39.80 / 100) * preco;
      nvalorProduto = preco - valorImposto;
      porcentImposto = (valorImposto / preco) * 100;
    }

    if (ClassMaterial == 7)
    {
      valorImposto = (38.62 / 100) * preco;
      nvalorProduto = preco - valorImposto;
      porcentImposto = (valorImposto / preco) * 100;
    }

    if (ClassMaterial == 8)
    {
      valorImposto = (54.00 / 100) * preco;
      nvalorProduto = preco - valorImposto;
      porcentImposto = (valorImposto / preco) * 100;
    }

    if (ClassMaterial == 9)
    {
      valorImposto = (34.00 / 100) * preco;
      nvalorProduto = preco - valorImposto;
      porcentImposto = (valorImposto / preco) * 100;
    }

    if (ClassMaterial == 10)
    {
      valorImposto = (75.00 / 100) * preco;
      nvalorProduto = preco - valorImposto;
      porcentImposto = (valorImposto / preco) * 100;
    }

    if (ClassMaterial == 11)
    {
      valorImposto = (33.00 / 100) * preco;
      nvalorProduto = preco - valorImposto;
      porcentImposto = (valorImposto / preco) * 100;
    }

    if (ClassMaterial == 12)
    {
      valorImposto = (48.00 / 100) * preco;
      nvalorProduto = preco - valorImposto;
      porcentImposto = (valorImposto / preco) * 100;
    }

    if (ClassMaterial == 13)
    {
      valorImposto = (24.00 / 100) * preco;
      nvalorProduto = preco - valorImposto;
      porcentImposto = (valorImposto / preco) * 100;
    }    
  }

  public void ImprimeCalculoImposto()
  {
    Console.WriteLine();


    Console.WriteLine("Valor dos impostos R${0}\nValor do produto sem impostos R${1}\nPorcentagem Total de impostos {2}%", valorImposto.ToString("F2", CultureInfo.InvariantCulture), nvalorProduto.ToString("F2", CultureInfo.InvariantCulture), porcentImposto);

    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
  }
}