using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo_1
{
    class Disciplina
    {
        List<String> disciplinas = new List<string>();

        private void AdicionarDisciplina()
        {
            Console.WriteLine("Informe o nome da disciplina:");
            string dado = Console.ReadLine();
            disciplinas.Add(dado);
        }

        private void ListarDisciplinasCadastradas()
        {
            Console.WriteLine("Disciplinas informadas");
            foreach (String disciplina in disciplinas)
            {
                Console.WriteLine();
                Console.WriteLine(disciplina);
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void Executar()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Cadastro de disciplinas\n");
                Console.WriteLine("1 - Cadastrar disciplina");
                Console.WriteLine("2 - Listar disciplinas");
                Console.WriteLine("0 - Sair");
                Console.WriteLine();
                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (opcao)
                    {
                        case 0: break;

                        case 1:
                            AdicionarDisciplina();
                            break;

                        case 2:
                            ListarDisciplinasCadastradas();
                            break;

                        default:
                            Console.WriteLine("Opção inválida");
                            Console.ReadLine();
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.ReadLine();
                }
            } while (opcao != 0);
        }
    }
}
