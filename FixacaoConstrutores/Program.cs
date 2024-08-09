using System;
using System.Numerics;
using System.Threading.Channels;
using System.Globalization;

namespace FixacaoConstrutores 
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int nconta;
            string cnome;
            string verif;
            InfoBanco i;

            Console.Write("Digite o número da conta: ");
            nconta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular: ");
            cnome = Console.ReadLine();
            Console.Write("Haverá um depósito inicial (Sim/Nao)? ");
            verif = Console.ReadLine();
            if (verif == "Sim")
            {
                Console.WriteLine();
                Console.Write("Digite o valor do depósito inicial: ");
                double inidepos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                i = new InfoBanco(nconta, cnome, inidepos);
                Console.WriteLine("Dados da conta: " + i, CultureInfo.InvariantCulture);
            }
            else {
                Console.WriteLine();
                i = new InfoBanco(nconta, cnome);
                Console.WriteLine("Dados da conta: " + i, CultureInfo.InvariantCulture);
            }
            Console.WriteLine();
            Console.Write("Digite um valor para Depósito: ");
            double depos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            i.AdicionarSaldo(depos);            
            Console.WriteLine("Dados da conta atualizados: " + i, CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            i.RetirarSaque(saque);
            Console.WriteLine("Dados da conta atualizados: " + i, CultureInfo.InvariantCulture);
        }
    }
}