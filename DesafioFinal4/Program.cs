using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Desafio
{

    public static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');

        Array.Sort(s);
        Array.Reverse(s);

        double A = double.Parse(s[0]);

        double B = double.Parse(s[1]);

        double C = double.Parse(s[2]);

        
        //continue a solucao
        if (A >= B + C)
            Console.WriteLine("NAO FORMA TRIANGULO");
        else if (A * A == (B * B) + (C * C))
            Console.WriteLine("TRIANGULO RETANGULO");
        else if (A * A > (B * B) + (C * C))
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        else if (A * A < (B * B) + (C * C))
            Console.WriteLine("TRIANGULO ACUTANGULO");
        if (A == B && A == C)
            Console.WriteLine("TRIANGULO EQUILATERO");
        if ((A == B && A != C) || (A == C && A != B) || (B == C && B != A))
            Console.WriteLine("TRIANGULO ISOSCELES");
    }
}