Console.WriteLine("FOR:");
for (int i = 1; i <= 5; i++) {
    Console.WriteLine("Valor de i: " + i);
}

Console.WriteLine("WHILE:");
int contador = 1;
while (contador <= 10)
{
    Console.WriteLine("Contador: " + contador);
    contador++;
}

Console.WriteLine("DO-WHILE:");
int numero = 0;
do {
    Console.WriteLine("Número: " + numero);
    numero++;
} while (numero < 3);

Console.WriteLine("FOREACH:");
string[] nomes = { "Ana", "Bruno", "Carlos" };

foreach (string nome in nomes) {
    Console.WriteLine("Nome: " + nome);
}
