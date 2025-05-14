float valor1 = 35.78f;
int valor2 = 28;

valor1 = valor2; //Conversão implicita
System.Console.WriteLine(valor1);

float valor3 = 11.78f;
int valor4 = 10;

valor4 = (int)valor3; //Conversão explicita
System.Console.WriteLine(valor4);

string valor5 = "100";
int valor6 = int.Parse(valor5); //Conversão usando o método Parse

System.Console.WriteLine(valor6);

string valor7 = "200";
int valor8 = Convert.ToInt32(valor7); //Conversão usando a classe Convert

System.Console.WriteLine(valor8);