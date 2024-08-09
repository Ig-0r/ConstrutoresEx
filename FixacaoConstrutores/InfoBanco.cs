using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FixacaoConstrutores
{
    internal class InfoBanco
    {
        public int IdConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }


        public InfoBanco(int idconta, string nome)
        {
            IdConta = idconta;
            Nome = nome;
            Saldo = 0;
        }

        public InfoBanco(int idconta, string nome, double saldo) : this(idconta, nome)
        {
            Saldo = saldo;
        }
        
        public void AdicionarSaldo(double depos) 
        {
             Saldo += depos;
        }

        public void RetirarSaque(double saque)
        { 
             Saldo -= saque;
            Saldo -= 5.00;
        }

        public override string ToString()
        {
            return "Conta "
            + IdConta
            + ", Titular: "
            + Nome
            + ", Saldo: $"
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
