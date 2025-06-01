static void MeuMetodo()
{
    Console.WriteLine("Método funcionando!");
}

static string RetornaNome(string nome, string sobrenome)
{
    return $"Meu nome é: {nome}";
}

MeuMetodo();
Console.WriteLine(RetornaNome("Lucas","Silva"));