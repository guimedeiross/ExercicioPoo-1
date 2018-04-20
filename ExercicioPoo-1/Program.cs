using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 opcao;
            do
            {
                Console.WriteLine("Selecione o exercício:");
                Console.WriteLine();
                Console.WriteLine("1 - Compras");
                Console.WriteLine("2 - Triângulos");
                Console.WriteLine("3 - Cadastro de Disciplinas");
                Console.WriteLine("4 - Ganhos e Gastos");
                Console.WriteLine("0 - Sair");
                Console.WriteLine();
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();
                switch (opcao)
                {
                    case 0:
                        break;

                    case 1:
                        Compra compra = new Compra();
                        compra.Executar();
                        break;

                    case 2:
                        Triangulo triangulo = new Triangulo();
                        triangulo.Executar();
                        break;

                    case 3:
                        Disciplina disciplina = new Disciplina();
                        disciplina.Executar();
                        break;

                    case 4:
                        GanhoEGasto ganhoEGasto = new GanhoEGasto();
                        ganhoEGasto.Executar();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opção Inválida!!");
                        Console.WriteLine();
                        break;
                }
            } while (opcao != 0);
        }
    }
}
