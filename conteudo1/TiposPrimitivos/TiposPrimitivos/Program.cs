byte idade = 25;
sbyte temperatura = -10;
short saldo = -1500;
ushort portas = 8080;
int quantidade = 100000;
long distanciaEstrelas = 922337203685477580;
ulong numeroMega = 18446744073709551615;
float altura = 1.75f; // precisa do 'f'
double pi = 3.14159265359;
decimal preco = 199.99m; // precisa do 'm'
char letra = 'A';
bool isOnline = true;




Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Temperatura: {temperatura}°C");
Console.WriteLine($"Saldo: {saldo}");
Console.WriteLine($"Porta usada: {portas}");
Console.WriteLine($"Quantidade: {quantidade}");
Console.WriteLine($"Distância (exemplo): {distanciaEstrelas}");
Console.WriteLine($"Maior valor ulong: {numeroMega}");
Console.WriteLine($"Altura: {altura}m");
Console.WriteLine($"Valor de Pi: {pi}");
Console.WriteLine($"Preço: R${preco}");
Console.WriteLine($"Está online? {isOnline}");
Console.WriteLine($"Letra: {letra}");
