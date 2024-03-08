
// Dividir a entrada em partes usando espaço como delimitador
string[] valores = Console.ReadLine().Split(' ');

// Converter os valores para os tipos desejados (por exemplo, int)
int valor1 = int.Parse(valores[0]);
int valor2 = int.Parse(valores[1]);
int valor3 = int.Parse(valores[2]);
int valor4 = int.Parse(valores[3]);

int R = valor1 + valor2 + valor3 + valor4 - 3;

Console.WriteLine(R);
