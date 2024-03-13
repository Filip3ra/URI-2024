
using System;

class URI
{

  static void Main(string[] args)
  {

    // nao aceita o tratamento de caractere nulos, "?"
    string s = Console.ReadLine();
    int x;
    int.TryParse(s, out x);
    for (int i = 0; i < x; i++)
    {
      s = Console.ReadLine();
    }
    Console.WriteLine("Ciencia da Computacao");

  }

}