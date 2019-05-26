namespace Reports1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoadChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxResp = new System.Windows.Forms.TextBox();
            this.textBoxQuestao = new System.Windows.Forms.TextBox();
            this.textBoxTurma = new System.Windows.Forms.TextBox();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.Hist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Colocacao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chart1.Location = new System.Drawing.Point(486, 293);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Name = "votos";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(423, 257);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            title1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            title1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Quantidade de votos";
            title1.Text = " VOTOS x OPÇÃO";
            this.chart1.Titles.Add(title1);
            // 
            // btnLoadChart
            // 
            this.btnLoadChart.Location = new System.Drawing.Point(380, 556);
            this.btnLoadChart.Name = "btnLoadChart";
            this.btnLoadChart.Size = new System.Drawing.Size(120, 23);
            this.btnLoadChart.TabIndex = 3;
            this.btnLoadChart.Text = "Gerar PDF";
            this.btnLoadChart.UseVisualStyleBackColor = true;
            this.btnLoadChart.Click += new System.EventHandler(this.btnLoadChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "RESPOSTA CORRETA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "DATA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(677, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "TURMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "QUESTÃO";
            // 
            // textBoxResp
            // 
            this.textBoxResp.Location = new System.Drawing.Point(790, 194);
            this.textBoxResp.Name = "textBoxResp";
            this.textBoxResp.Size = new System.Drawing.Size(68, 22);
            this.textBoxResp.TabIndex = 11;
            // 
            // textBoxQuestao
            // 
            this.textBoxQuestao.Location = new System.Drawing.Point(435, 191);
            this.textBoxQuestao.Name = "textBoxQuestao";
            this.textBoxQuestao.Size = new System.Drawing.Size(77, 22);
            this.textBoxQuestao.TabIndex = 12;
            // 
            // textBoxTurma
            // 
            this.textBoxTurma.Location = new System.Drawing.Point(790, 107);
            this.textBoxTurma.Name = "textBoxTurma";
            this.textBoxTurma.Size = new System.Drawing.Size(68, 22);
            this.textBoxTurma.TabIndex = 13;
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Location = new System.Drawing.Point(435, 107);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(235, 22);
            this.textBoxCurso.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "CURSO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 235);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimeBox
            // 
            this.dateTimeBox.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBox.Location = new System.Drawing.Point(435, 147);
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.Size = new System.Drawing.Size(292, 22);
            this.dateTimeBox.TabIndex = 16;
            // 
            // Hist
            // 
            this.Hist.BackColor = System.Drawing.Color.Transparent;
            this.Hist.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea2.Name = "ChartArea1";
            this.Hist.ChartAreas.Add(chartArea2);
            this.Hist.Location = new System.Drawing.Point(63, 293);
            this.Hist.Name = "Hist";
            this.Hist.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.LegendText = "ola mnundo";
            series2.Name = "Tempo";
            this.Hist.Series.Add(series2);
            this.Hist.Size = new System.Drawing.Size(403, 260);
            this.Hist.TabIndex = 17;
            this.Hist.Text = "Histograma";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "HISTOGRAMA";
            this.Hist.Titles.Add(title2);
            // 
            // Colocacao
            // 
            chartArea3.Name = "ChartArea1";
            this.Colocacao.ChartAreas.Add(chartArea3);
            this.Colocacao.Location = new System.Drawing.Point(950, 263);
            this.Colocacao.Name = "Colocacao";
            this.Colocacao.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series3.Name = "Place";
            this.Colocacao.Series.Add(series3);
            this.Colocacao.Size = new System.Drawing.Size(509, 316);
            this.Colocacao.TabIndex = 19;
            this.Colocacao.Text = "TEMPO x COLOCAÇÃO";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1471, 683);
            this.Controls.Add(this.Colocacao);
            this.Controls.Add(this.Hist);
            this.Controls.Add(this.dateTimeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCurso);
            this.Controls.Add(this.textBoxTurma);
            this.Controls.Add(this.textBoxQuestao);
            this.Controls.Add(this.textBoxResp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colocacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn6DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataBaseBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnLoadChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxResp;
        private System.Windows.Forms.TextBox textBoxQuestao;
        private System.Windows.Forms.TextBox textBoxTurma;
        private System.Windows.Forms.TextBox textBoxCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimeBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart Hist;
        private System.Windows.Forms.DataVisualization.Charting.Chart Colocacao;
    }
}

