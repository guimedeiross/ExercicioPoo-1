using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo_1
{
    class Compra
    {
        public void Executar()
        {
            float valor, resto, qtde, vpago, tot, troco;
            char resp;
            do
            {
                do
                {
                    Console.Write("Informe o valor do item: ");
                    valor = Convert.ToSingle(Console.ReadLine());
                    if (valor <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Somente valores positivos e maiores que 0!");
                        Console.WriteLine();
                    }
                } while (valor <= 0);
                Console.WriteLine();
                do
                {
                    Console.Write("Informe a quantidade: ");
                    qtde = Convert.ToSingle(Console.ReadLine());
                    if (qtde <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Somente valores positivos e maiores que 0!");
                        Console.WriteLine();
                    }
                } while (qtde <= 0);
                Console.WriteLine();
                do
                {
                    Console.Write("Valor pago pelo cliente: ");
                    vpago = Convert.ToSingle(Console.ReadLine());
                    if (vpago <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Somente valores positivos e maiores que 0!");
                        Console.WriteLine();
                    }
                } while (vpago <= 0);
                Console.WriteLine();
                tot = valor * qtde;
                if (vpago < tot)
                {
                    resto = tot - vpago;
                    Console.WriteLine();
                    Console.WriteLine($"Valor pago inferior ao valor total, resta {resto} R$ para completar o valor.");
                    Console.WriteLine();
                }
                else
                {
                    if (vpago == tot)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Obrigado, volte sempre!");
                        Console.WriteLine();
                    }
                    else
                    {
                        troco = vpago - tot;
                        Console.WriteLine($"Seu troco é de {troco} R$");
                        Console.WriteLine();
                    }
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
