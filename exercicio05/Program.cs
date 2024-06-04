using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a primeira nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7)
        {
            Console.WriteLine("O aluno esta aprovado com média" + media.ToString("0.00")+ ".");
        }
        else if (media >=5)
        {
            Console.WriteLine("O aluno esta em recuperação com média" + media.ToString("0.00")+ ".");
        }
        else
        {
            Console.WriteLine("O aluno esta reprovado com média" + media.ToString("0.00")+ ".");
        }

    }
}