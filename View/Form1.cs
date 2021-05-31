using Calculadora.Controler;
using Calculadora.Model;
using System;
using System.Windows.Forms;


namespace Calculadora
{
    public partial class frm_calculadora : Form
    {
        public frm_calculadora()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            try
            {
                //Limpar os campos
                txt_capInicial.Clear();
                txt_aporte.Clear();
                txt_periodo.Clear();
                txt_taxa.Clear();
                txt_capFuturo.Clear();
                txt_totalJuros.Clear();
                txt_totalAporte.Clear();

                //Limpar o grafico
                Cht_grafico.Series[0].Points.Clear();
                Cht_grafico.Series[1].Points.Clear();
                Cht_grafico.Series[2].Points.Clear();
                Cht_grafico.Update();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Investimento inv = new Investimento();

            try
            {
                //Copiar os valores da tela e enviar para a classe Model
                inv.cap_inicial = Double.Parse(txt_capInicial.Text);
                inv.aporte = Double.Parse(txt_aporte.Text);
                inv.taxa_juros = Double.Parse(txt_taxa.Text);
                inv.tempo = int.Parse(txt_periodo.Text);


                //Chamar a classe Controller e retornar valores da classe Persistente
                ControllerCalcular controlar = new ControllerCalcular();
                inv = controlar.Transportar(inv);

                txt_capInicial.Text = String.Format("{0,20:f2}", inv.cap_inicial);
                txt_aporte.Text = String.Format("{0,20:f2}", inv.aporte);
                txt_taxa.Text = String.Format("{0,20:f2}", inv.taxa_juros);
                txt_periodo.Text = Convert.ToString(inv.tempo);
                txt_capFuturo.Text = String.Format("{0,20:f2}", inv.cap_futuro);
                txt_totalJuros.Text = String.Format("{0,20:f2}", inv.totalJuros);
                txt_totalAporte.Text = String.Format("{0,20:f2}", inv.totalAporte);

                //Passar valores para grafico
                timer1_Tick(inv);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void timer1_Tick(Investimento inv)
        {
            try
            {
                //Verifica se o grafico possui mais de 5 analises e elimina a primeira
                if (Cht_grafico.Series[0].Points.Count > 2)
                {
                    Cht_grafico.Series[0].Points.RemoveAt(0);
                    Cht_grafico.Series[1].Points.RemoveAt(0);
                    Cht_grafico.Series[2].Points.RemoveAt(0);
                    Cht_grafico.Update();
                }

                //Preenche o ponto Y do gráfico com valor calculado
                Cht_grafico.Series[0].Points.AddY(inv.totalJuros);
                Cht_grafico.Series[1].Points.AddY(inv.totalAporte);
                Cht_grafico.Series[2].Points.AddY(inv.cap_futuro);
            }
            catch (Exception exept)
            {
                MessageBox.Show(exept.Message);
            }
        }
    }
}
