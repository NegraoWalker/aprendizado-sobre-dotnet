Console.WriteLine("IF: ");
int idade1 = 20;
if (idade1 >= 18) {
    
    Console.WriteLine("Você é maior de idade.");
}


Console.WriteLine("IF-ELSE: ");
int idade2 = 16;
if (idade2 >= 18) {
    Console.WriteLine("Você pode entrar na festa.");
} else {
    Console.WriteLine("Você não pode entrar na festa.");
}

Console.WriteLine("IF - ELSE IF E ELSE: ");
int nota = 85;
if (nota >= 90) {
    Console.WriteLine("Nota A");
} else if (nota >= 80) {
    Console.WriteLine("Nota B");
} else if (nota >= 70)
{
    Console.WriteLine("Nota C");
} else {
    Console.WriteLine("Reprovado");
}

Console.WriteLine("SWITCH: ");
string diaSemana = "Terça";
switch (diaSemana) {
    case "Segunda":
        Console.WriteLine("Começo da semana");
        break;
    case "Terça":
        Console.WriteLine("Segundo dia útil");
        break;
    case "Sábado":
    case "Domingo":
        Console.WriteLine("Fim de semana");
        break;
    default:
        Console.WriteLine("Dia inválido");
        break;
}

Console.WriteLine("OPERADOR TERNÁRIO: ");
int idade3 = 20;
string status = idade3 >= 18 ? "Adulto" : "Menor";
Console.WriteLine(status); // Adulto

