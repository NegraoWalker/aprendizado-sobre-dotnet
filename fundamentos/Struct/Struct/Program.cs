using System;

struct Ponto
{
    public int X { get; set; }
    public int Y { get; set; }

    public Ponto(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"Ponto(X: {X}, Y: {Y})";
    }
}

class Program
{
    static void Main()
    {
        Ponto pontoA = new(10, 20); 
        Console.WriteLine(pontoA);  
    }
}
