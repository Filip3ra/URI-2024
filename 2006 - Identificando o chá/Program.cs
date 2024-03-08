string s = Console.ReadLine();

string valores = Console.ReadLine();

int cont = 0;

for (int i = 0; i < valores.Length; i++)
{
  if (valores[i] == s[0])
    cont++;
}

Console.WriteLine(cont);


