using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo_1
{
    public class Despesa
    {
        public string Descricao { get; set; }
        public float Valor { get; set; }
    }
    public class Receita
    {
        public string Descricao { get; set; }
        public float Valor { get; set; }
    }
    class GanhoEGasto
    {
        List<Despesa> despesas = new List<Despesa>();
        List<Receita> receitas = new List<Receita>();

        float mediareceit = 0, mediadesp = 0, somadesp = 0, somareceit = 0;

        private void CadastroDespesas()
        {
            Despesa novadespesa = new Despesa();
            Console.Write("Informe o valor: ");
            novadespesa.Valor = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe uma descrição:");
            novadespesa.Descricao = Console.ReadLine();
            despesas.Add(novadespesa);
            somadesp = despesas.Sum(x => x.Valor);
        }

        private void CadastroReceitas()
        {
            Receita novareceita = new Receita();
            Console.Write("Informe o valor: ");
            novareceita.Valor = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Informe uma descrição:");
            novareceita.Descricao = Console.ReadLine();
            receitas.Add(novareceita);
            somareceit = receitas.Sum(x => x.Valor);
        }

        private void MostrarDespesas()
        {
            Console.WriteLine("------Despesas Informadas------");
            Console.WriteLine();
            foreach (Despesa desp in despesas)
            {
                Console.WriteLine($"Descrição: {desp.Descricao}");
                Console.WriteLine($"Valor: {desp.Valor:0.00} R$");
            }
            Console.WriteLine($"O total de despesas foi de: {somadesp:0.00} R$");
            Console.ReadLine();
        }

        private void MostrarReceitas()
        {
            Console.WriteLine("------Receitas Informadas------");
            Console.WriteLine();
            foreach (Receita rec in receitas)
            {
                Console.WriteLine($"Descrição: {rec.Descricao}");
                Console.WriteLine($"Valor: {rec.Valor:0.00} R$");
            }
            Console.WriteLine($"O total de receitas foi de: {somareceit:0.00} R$");
            Console.ReadLine();
        }

        private void MediaReceitaseDespesas()
        {
            /* ----TOTAL / QTDE DE VALORES INFORMADOS----*/
            mediadesp = somadesp / despesas.Count;
            mediareceit = somareceit / receitas.Count;
            Console.WriteLine($"A média das despesas foi de: {mediadesp:0.00} R$");
            Console.WriteLine();
            Console.WriteLine($"A média das receitas foi de: {mediareceit:0.00} R$");
            Console.WriteLine();
            Console.ReadLine();
        }

        private void SaldoTotal()
        {
            float saldo;
            saldo = somareceit - somadesp;
            Console.WriteLine($"O seu saldo é de: {saldo:0.00} R$");
            Console.ReadLine();
        }

        public void Executar()
        {
            Int32 opcao = 0;
            do
            {
                Console.WriteLine("1 - Adicionar Despesas");
                Console.WriteLine("2 - Mostrar Despesas e Total de Despesas");
                Console.WriteLine("3 - Adicionar Receitas");
                Console.WriteLine("4 - Mostrar Receitas e Total de Receitas");
                Console.WriteLine("5 - Média das Receitas e Despesas");
                Console.WriteLine("6 - Saldo Total");
                Console.WriteLine("0 - Sair\n");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();
                switch (opcao)
                {
                    case 0:
                        break;

                    case 1:
                        CadastroDespesas();
                        break;
                    case 2:
                        MostrarDespesas();
                        break;
                    case 3:
                        CadastroReceitas();
                        break;
                    case 4:
                        MostrarReceitas();
                        break;
                    case 5:
                        MediaReceitaseDespesas();
                        break;
                    case 6:
                        SaldoTotal();
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
