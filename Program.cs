using System;

namespace pedir_nota_de_1_a_10_18_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obs:De 0 a 10.");
            Console.Write("Digite a nota: ");
            int nota = int.Parse(Console.ReadLine());

            while(nota > 10){
                Console.WriteLine("A nota não é válida");
                Console.Write("Digite o valor novamente: ");
                nota = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nota cadastrada!");
        }
    }
}
