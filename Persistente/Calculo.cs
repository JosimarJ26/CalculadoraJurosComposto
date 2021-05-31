using Calculadora.Model;
using System;
using System.Windows.Forms;

namespace Calculadora.Persistente
{
    class Calculo
    {

        public Investimento Calcular(Investimento inv)
        {
            //Metodo para calcular os valores
            //Fórmula de calculo M = C.((1+i)^n)  M= montante, C= Capital, i= taxa juros, n= tempo

            double cap_inicial = inv.cap_inicial;
            double taxa = inv.taxa_juros / 100;
            double aporte = 0;
            int tempo = inv.tempo;
            double totalAporte = 0;
            double capfuturo = 0;
            double totalJuros = 0;
            double juros = 0;

            try
            {
                totalAporte += cap_inicial;

                for (int i = 0; i < tempo; i++)
                {
                    aporte = inv.aporte;
                    int tx = 1;

                    if (i == 0)
                        aporte = 0.00;

                    cap_inicial += (juros + aporte);

                    capfuturo = cap_inicial * Math.Pow(1 + taxa, tx);

                    juros = (capfuturo - cap_inicial);
                    totalJuros += juros;
                    totalAporte += aporte;

                }

                inv.totalAporte = totalAporte;
                inv.totalJuros = totalJuros;
                inv.cap_futuro = capfuturo;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return inv;
        }
    }
}
