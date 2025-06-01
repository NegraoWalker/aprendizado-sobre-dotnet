int a = 10, b = 3;
Console.WriteLine("Operadores Aritméticos:");
Console.WriteLine($"Soma: {a + b}");            // 13
Console.WriteLine($"Subtração: {a - b}");       // 7
Console.WriteLine($"Multiplicação: {a * b}");   // 30
Console.WriteLine($"Divisão: {a / b}");         // 3
Console.WriteLine($"Módulo: {a % b}");          // 1

int x = 5;
Console.WriteLine("\nOperadores de Atribuição:");
x += 3; // x = x + 3 => 8
Console.WriteLine($"x += 3 -> {x}");
x -= 2; // x = x - 2 => 6
Console.WriteLine($"x -= 2 -> {x}");
x *= 4; // x = x * 4 => 24
Console.WriteLine($"x *= 4 -> {x}");
x /= 6; // x = x / 6 => 4
Console.WriteLine($"x /= 6 -> {x}");
x %= 3; // x = x % 3 => 1
Console.WriteLine($"x %= 3 -> {x}");

int y = 10;
Console.WriteLine("\nOperadores de Comparação:");
Console.WriteLine($"y == 10 -> {y == 10}");  // true
Console.WriteLine($"y != 5 -> {y != 5}");    // true
Console.WriteLine($"y > 5 -> {y > 5}");      // true
Console.WriteLine($"y < 20 -> {y < 20}");    // true
Console.WriteLine($"y >= 10 -> {y >= 10}");  // true
Console.WriteLine($"y <= 15 -> {y <= 15}");  // true

int idade = 20;
bool temCarteira = true;

Console.WriteLine("\nOperadores Lógicos:");
Console.WriteLine($"Pode dirigir: {idade >= 18 && temCarteira}"); // true
Console.WriteLine($"Menor de idade ou tem carteira: {idade < 18 || temCarteira}"); // true
Console.WriteLine($"Não pode dirigir: {!temCarteira}"); // false

Console.WriteLine("\nOperador Ternário:");
string status = (idade >= 18) ? "Adulto" : "Menor";
Console.WriteLine($"Status: {status}"); // Adulto