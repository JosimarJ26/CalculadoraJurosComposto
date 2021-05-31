using Calculadora.Model;
using Calculadora.Persistente;
using System;
using System.Windows.Forms;

namespace Calculadora.Controler
{
    class ControllerCalcular
    {
        public Investimento Transportar(Investimento inv)
        {
            //realiza a chamada para a persistente realizar calculo e retornar valores para a tela
            Calculo calc = new Calculo();
            Investimento invest = new Investimento();

            try
            {
                invest = calc.Calcular(inv);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return invest;
        }
    }
}
