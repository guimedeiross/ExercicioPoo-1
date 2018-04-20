using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo_1
{
    class Triangulo
    {
        public void Executar()
        {
            float l1, l2, l3;
            char resp;
            do
            {
                do
                {
                    Console.Write("Informe o primeiro lado: ");
                    l1 = Convert.ToSingle(Console.ReadLine());
                    if (l1 <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Somente numeros positivos e maiores que ZERO!");
                        Console.WriteLine();
                    }
                } while (l1 <= 0);
                Console.WriteLine();
                do
                {
                    Console.Write("Informe o segundo lado: ");
                    l2 = Convert.ToSingle(Console.ReadLine());
                    if (l2 <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Somente numeros positivos e maiores que ZERO!");
                        Console.WriteLine();
                    }
                } while (l2 <= 0);
                Console.WriteLine();
                do
                {
                    Console.Write("Informe o terceiro lado: ");
                    l3 = Convert.ToSingle(Console.ReadLine());
                    if (l3 <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Somente numeros positivos e maiores que ZERO!");
                        Console.WriteLine();
                    }
                } while (l3 <= 0);
                Console.WriteLine();
                if (l1 < l2 + l3 && l2 < l1 + l3 && l3 < l2 + l1)
                {
                    Console.WriteLine("É um triângulo!!");
                    Console.WriteLine();
                    if (l1 == l2 && l2 == l3)
                    {
                        Console.WriteLine("É um triângulo equilátero");
                        Console.WriteLine();
                    }
                    else
                    {
                        if (l1 != l2 && l2 != l3 && l1 != l3)
                        {
                            Console.WriteLine("É um triângulo escaleno");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("É um triângulo isósceles");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Não é um triângulo!!");
                    Console.WriteLine();
                }
                do
                {
                    Console.Write("Gostaria de efetuar o processo de novo? (S - Sim / N - Não): ");
                    resp = Convert.ToChar(Console.ReadLine());
                    resp = Char.ToUpper(resp);
                    if (resp != 'S' && resp != 'N')
                    {
                        Console.WriteLine();
                        Console.WriteLine("Opção Inválida (S para Sim ou N para Não): ");
                        Console.WriteLine();
                    }
                } while (resp != 'S' && resp != 'N');
                Console.Clear();
            } while (resp == 'S');
        }
    }
}
