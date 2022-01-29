using System;
using System.Collections.Generic;
using UltimoDesafioModulo.Entidades;

namespace UltimoDesafioModulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxaPagamento> tp = new List<TaxaPagamento>();

            Console.WriteLine("Digite a quantidade de pagadores: ");
            int qtdePagadores = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtdePagadores; i++)
            {
                Console.WriteLine("O individuo é Juridica ou Fisica (J/F)? ");
                string selecionar = Console.ReadLine();

                Console.WriteLine("Digite nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite sua renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());

                if(selecionar == "J")
                {
                    Console.WriteLine("Quantidade de funcionario: ");
                    int qtdeFuncionario = int.Parse(Console.ReadLine());

                    tp.Add(new PessoaJuridica(nome, rendaAnual, qtdeFuncionario));
                
                }else if (selecionar == "F")
                {
                    Console.WriteLine("Gasto com saude: ");
                    double gastouSaude = double.Parse(Console.ReadLine());

                    tp.Add(new PessoaFisica(gastouSaude, nome, rendaAnual));
                }

               

            }
            Console.WriteLine("--------------------");
            Console.WriteLine();

            double somar = 0;
            Console.WriteLine("Taxas a pagar: ");
            foreach(TaxaPagamento t in tp)
            {
                Console.WriteLine(t.nome + " R$" + t.taxa());
                somar += t.taxa();
            }
            Console.WriteLine();
            Console.WriteLine("Total de taxas a pagar: " + somar);

        }
    }
}
