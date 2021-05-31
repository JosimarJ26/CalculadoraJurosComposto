namespace Calculadora
{
    partial class frm_calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_Cap_Futuro = new System.Windows.Forms.Label();
            this.lbl_taxa = new System.Windows.Forms.Label();
            this.lbl_Aporte_Financeiro = new System.Windows.Forms.Label();
            this.lbl_Cap_Inicial = new System.Windows.Forms.Label();
            this.txt_capInicial = new System.Windows.Forms.TextBox();
            this.txt_capFuturo = new System.Windows.Forms.TextBox();
            this.txt_taxa = new System.Windows.Forms.TextBox();
            this.txt_aporte = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_periodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_totalJuros = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lbl_totalJuros = new System.Windows.Forms.Label();
            this.txt_totalAporte = new System.Windows.Forms.TextBox();
            this.lbl_totalAporte = new System.Windows.Forms.Label();
            this.tmr_grafico = new System.Windows.Forms.Timer(this.components);
            this.Cht_grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Cht_grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(118, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(367, 25);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "CALCULADORA JUROS COMPOSTO";
            // 
            // lbl_Cap_Futuro
            // 
            this.lbl_Cap_Futuro.AutoSize = true;
            this.lbl_Cap_Futuro.Location = new System.Drawing.Point(58, 257);
            this.lbl_Cap_Futuro.Name = "lbl_Cap_Futuro";
            this.lbl_Cap_Futuro.Size = new System.Drawing.Size(72, 13);
            this.lbl_Cap_Futuro.TabIndex = 1;
            this.lbl_Cap_Futuro.Text = "Capital Futuro";
            // 
            // lbl_taxa
            // 
            this.lbl_taxa.AutoSize = true;
            this.lbl_taxa.Location = new System.Drawing.Point(56, 206);
            this.lbl_taxa.Name = "lbl_taxa";
            this.lbl_taxa.Size = new System.Drawing.Size(74, 26);
            this.lbl_taxa.TabIndex = 2;
            this.lbl_taxa.Text = "Taxa de Juros\r\n    (mensal)";
            // 
            // lbl_Aporte_Financeiro
            // 
            this.lbl_Aporte_Financeiro.AutoSize = true;
            this.lbl_Aporte_Financeiro.Location = new System.Drawing.Point(40, 163);
            this.lbl_Aporte_Financeiro.Name = "lbl_Aporte_Financeiro";
            this.lbl_Aporte_Financeiro.Size = new System.Drawing.Size(90, 26);
            this.lbl_Aporte_Financeiro.TabIndex = 3;
            this.lbl_Aporte_Financeiro.Text = "Aporte Financeiro\r\n        (mensal)";
            // 
            // lbl_Cap_Inicial
            // 
            this.lbl_Cap_Inicial.AutoSize = true;
            this.lbl_Cap_Inicial.Location = new System.Drawing.Point(61, 82);
            this.lbl_Cap_Inicial.Name = "lbl_Cap_Inicial";
            this.lbl_Cap_Inicial.Size = new System.Drawing.Size(69, 13);
            this.lbl_Cap_Inicial.TabIndex = 4;
            this.lbl_Cap_Inicial.Text = "Capital Inicial";
            // 
            // txt_capInicial
            // 
            this.txt_capInicial.Location = new System.Drawing.Point(136, 79);
            this.txt_capInicial.Name = "txt_capInicial";
            this.txt_capInicial.Size = new System.Drawing.Size(143, 20);
            this.txt_capInicial.TabIndex = 1;
            this.txt_capInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_capFuturo
            // 
            this.txt_capFuturo.Location = new System.Drawing.Point(136, 254);
            this.txt_capFuturo.Name = "txt_capFuturo";
            this.txt_capFuturo.Size = new System.Drawing.Size(143, 20);
            this.txt_capFuturo.TabIndex = 5;
            this.txt_capFuturo.TabStop = false;
            this.txt_capFuturo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_taxa
            // 
            this.txt_taxa.Location = new System.Drawing.Point(136, 212);
            this.txt_taxa.Name = "txt_taxa";
            this.txt_taxa.Size = new System.Drawing.Size(143, 20);
            this.txt_taxa.TabIndex = 4;
            this.txt_taxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_aporte
            // 
            this.txt_aporte.Location = new System.Drawing.Point(136, 169);
            this.txt_aporte.Name = "txt_aporte";
            this.txt_aporte.Size = new System.Drawing.Size(143, 20);
            this.txt_aporte.TabIndex = 3;
            this.txt_aporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_sair
            // 
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(369, 380);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(77, 32);
            this.btn_sair.TabIndex = 10;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Calcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Calcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(546, 369);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(88, 43);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_periodo
            // 
            this.txt_periodo.Location = new System.Drawing.Point(136, 123);
            this.txt_periodo.Name = "txt_periodo";
            this.txt_periodo.Size = new System.Drawing.Size(143, 20);
            this.txt_periodo.TabIndex = 2;
            this.txt_periodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tempo  \r\n  (mês)";
            // 
            // txt_totalJuros
            // 
            this.txt_totalJuros.Location = new System.Drawing.Point(136, 297);
            this.txt_totalJuros.Name = "txt_totalJuros";
            this.txt_totalJuros.Size = new System.Drawing.Size(143, 20);
            this.txt_totalJuros.TabIndex = 6;
            this.txt_totalJuros.TabStop = false;
            this.txt_totalJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_limpar
            // 
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(452, 369);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(88, 43);
            this.btn_limpar.TabIndex = 9;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // lbl_totalJuros
            // 
            this.lbl_totalJuros.AutoSize = true;
            this.lbl_totalJuros.Location = new System.Drawing.Point(74, 300);
            this.lbl_totalJuros.Name = "lbl_totalJuros";
            this.lbl_totalJuros.Size = new System.Drawing.Size(56, 13);
            this.lbl_totalJuros.TabIndex = 14;
            this.lbl_totalJuros.Text = "Total juros";
            // 
            // txt_totalAporte
            // 
            this.txt_totalAporte.Location = new System.Drawing.Point(136, 335);
            this.txt_totalAporte.Name = "txt_totalAporte";
            this.txt_totalAporte.Size = new System.Drawing.Size(143, 20);
            this.txt_totalAporte.TabIndex = 7;
            this.txt_totalAporte.TabStop = false;
            this.txt_totalAporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_totalAporte
            // 
            this.lbl_totalAporte.AutoSize = true;
            this.lbl_totalAporte.Location = new System.Drawing.Point(62, 329);
            this.lbl_totalAporte.Name = "lbl_totalAporte";
            this.lbl_totalAporte.Size = new System.Drawing.Size(68, 26);
            this.lbl_totalAporte.TabIndex = 18;
            this.lbl_totalAporte.Text = "Total Aporte \r\n  Financeiro";
            // 
            // tmr_grafico
            // 
            this.tmr_grafico.Interval = 1000;
            // 
            // Cht_grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.Cht_grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Cht_grafico.Legends.Add(legend1);
            this.Cht_grafico.Location = new System.Drawing.Point(302, 63);
            this.Cht_grafico.Name = "Cht_grafico";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.LabelForeColor = System.Drawing.Color.Bisque;
            series1.Legend = "Legend1";
            series1.LegendText = "Juros";
            series1.Name = "1Juros";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.LegendText = "Aporte";
            series2.Name = "2Aporte";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series3.Legend = "Legend1";
            series3.LegendText = "CapitalFuturo";
            series3.Name = "3CapitalFuturo";
            this.Cht_grafico.Series.Add(series1);
            this.Cht_grafico.Series.Add(series2);
            this.Cht_grafico.Series.Add(series3);
            this.Cht_grafico.Size = new System.Drawing.Size(332, 300);
            this.Cht_grafico.TabIndex = 20;
            this.Cht_grafico.Text = "Evolução";
            this.Cht_grafico.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            title1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            title1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "tl_Evo";
            title1.Text = "Evolução";
            this.Cht_grafico.Titles.Add(title1);
            // 
            // frm_calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 424);
            this.Controls.Add(this.Cht_grafico);
            this.Controls.Add(this.txt_totalAporte);
            this.Controls.Add(this.lbl_totalAporte);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txt_totalJuros);
            this.Controls.Add(this.lbl_totalJuros);
            this.Controls.Add(this.txt_periodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txt_aporte);
            this.Controls.Add(this.txt_taxa);
            this.Controls.Add(this.txt_capFuturo);
            this.Controls.Add(this.txt_capInicial);
            this.Controls.Add(this.lbl_Cap_Inicial);
            this.Controls.Add(this.lbl_Aporte_Financeiro);
            this.Controls.Add(this.lbl_taxa);
            this.Controls.Add(this.lbl_Cap_Futuro);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.Cht_grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_Cap_Futuro;
        private System.Windows.Forms.Label lbl_taxa;
        private System.Windows.Forms.Label lbl_Aporte_Financeiro;
        private System.Windows.Forms.Label lbl_Cap_Inicial;
        private System.Windows.Forms.TextBox txt_capInicial;
        private System.Windows.Forms.TextBox txt_capFuturo;
        private System.Windows.Forms.TextBox txt_taxa;
        private System.Windows.Forms.TextBox txt_aporte;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_periodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_totalJuros;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lbl_totalJuros;
        private System.Windows.Forms.TextBox txt_totalAporte;
        private System.Windows.Forms.Label lbl_totalAporte;
        private System.Windows.Forms.Timer tmr_grafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart Cht_grafico;
    }
}

