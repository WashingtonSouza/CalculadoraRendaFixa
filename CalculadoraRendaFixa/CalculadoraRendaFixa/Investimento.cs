using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraRendaFixa
{
    class Investimento
    {
        public double valorInvestimento;
        public int qtdMes;
        public double taxaJuros;
        private double valorTotal;
        private double jurosMensal;
        private double valorComIR;

        public void RendaFixa(Investimento investimento)
        {
            investimento.valorTotal = valorInvestimento;

            for (int i = 1; i <= investimento.qtdMes; i++)
            {
                investimento.jurosMensal = (investimento.valorTotal * investimento.taxaJuros) / 100;

                Console.WriteLine("No mês " + i + " O rendimento é de " + investimento.jurosMensal.ToString("0.##"));

                investimento.valorTotal += Convert.ToDouble(investimento.jurosMensal.ToString("0.##"));
            }
            Console.WriteLine("O investimento Total da aplicação sem IR é: " + investimento.valorTotal);

            this.ImpostoDeRenda(investimento);

            Console.WriteLine("O investimento Total da aplicação com IR é: " + investimento.valorComIR);
        }

        private void ImpostoDeRenda(Investimento invest)
        {
            var imp = invest.valorTotal - invest.valorInvestimento;

            if (invest.qtdMes > 0 && invest.qtdMes <= 12)
            {
                invest.valorComIR = valorTotal - Convert.ToDouble((imp * 0.24).ToString("0.##"));
            }
            else if (invest.qtdMes > 12 && invest.qtdMes <= 24)
            {
                invest.valorComIR = valorTotal - Convert.ToDouble((imp * 0.15).ToString("0.##"));
            }
            else if (invest.qtdMes > 24 && invest.qtdMes <= 36)
            {
                invest.valorComIR = valorTotal - Convert.ToDouble((imp * 0.05).ToString("0.##"));
            }
            else
                invest.valorComIR = valorTotal - Convert.ToDouble((imp * 0.01).ToString("0.##"));
        }
    }
}
