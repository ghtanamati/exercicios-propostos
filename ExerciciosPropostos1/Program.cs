using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostos1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 01
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"SOMA: {a + b}");*/

            /*Exercício 02
            Console.WriteLine("Informe o raio do círculo");
            double raioCirculo = Convert.ToDouble(Console.ReadLine());
            double pi = Math.PI;
            double areaCirculo = pi * raioCirculo * raioCirculo;
            Console.WriteLine($"Área: {Math.Round(areaCirculo, 4)}");
            Console.WriteLine($"Área: {areaCirculo.ToString("#.####")}");*/

            /*Exercício 03
            int A = Convert.ToInt16(Console.ReadLine());
            int B = Convert.ToInt16(Console.ReadLine());
            int C = Convert.ToInt16(Console.ReadLine());
            int D = Convert.ToInt16(Console.ReadLine());
            int diferenca = A * B - C * D;
            Console.WriteLine($"Diferença: {diferenca}");*/

            /*Exercício 04*/
            int codFuncionario = Convert.ToInt16(Console.ReadLine());
            int horasTrabalhadas = Convert.ToInt16(Console.ReadLine());
            double valorHora = Convert.ToDouble(Console.ReadLine());
            double salario = valorHora * horasTrabalhadas;
            Console.WriteLine($"\nFuncionário: {codFuncionario}");
            Console.WriteLine($"Salário: U$ {salario.ToString("##,##")}");
        }
    }
}
