using System;

class Program
{
    static int CalcularDano(int ataque, int defesa)
    {
        //TODO: Implemente a função calcular dano
        int danoBruto = ataque - defesa;
        int dano = Math.Max(0, danoBruto);
        return dano;
    }

    static void Main(string[] args)
    {
        int ataque = int.Parse(Console.ReadLine());

        int defesa = int.Parse(Console.ReadLine());

        int danoCausado = CalcularDano(ataque, defesa);
        Console.WriteLine("O dano causado pelo ataque foi: " + danoCausado);
    }
}
