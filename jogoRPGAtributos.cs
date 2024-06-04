using System;

class Program
{
    static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtributo)
    {
        //TODO: Implemente a função VerificarAtributo
        bool dentroDoIntervalo = valorAtributo >= valorMinimo && valorAtributo <= valorMaximo;

        if (dentroDoIntervalo)
        {
            Console.WriteLine("O valor do atributo está dentro do intervalo especificado");
        }
        else
        {
            Console.WriteLine("O valor do atributo está fora do intervalo especificado");
        }

        return dentroDoIntervalo;
    }

    static void Main(string[] args)
    {
        string atributo = Console.ReadLine();

        int valorMinimo = int.Parse(Console.ReadLine());

        int valorMaximo = int.Parse(Console.ReadLine());

        int valorAtributo = int.Parse(Console.ReadLine());

        VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtributo);
    }
}
