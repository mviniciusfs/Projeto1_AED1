using System;
using System.Globalization;

class Produto
{
  public string Nome
  {  get; set; }
  public string Marca
  {  get; set; }
  public double Preco
  {  get; set; }

  public void dadosProduto(string n, string m, double p)
  {
    Nome = n;
    Marca = m;
    Preco = p;
  }

  public void listaTipoMaterial()
  {
    Console.WriteLine();
    Console.WriteLine("Videogames       = 1 \nRelógios         = 2 \nGeladeiras       = 3  \nTelevisores      = 4 \nMáquina de lavar = 5 \nCelulares        = 6 \nNotebooks        = 7    \nAutomóveis       = 8 \nRoupas           = 9 \nPerfumes         = 10 \nMedicamentos     = 11 \nEnergia Resid.   = 12 \nÁgua Resid.      = 13");
    Console.WriteLine();
  }

  public void imprimeProd()
  {
    Console.WriteLine();
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    Console.WriteLine("Dados: {0} // {1} // R${2},00", Nome, Marca, Preco);
  }
}