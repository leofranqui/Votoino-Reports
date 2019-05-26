using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms.DataVisualization.Charting;

namespace Reports1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<DataBase> ListDataBase = new List<DataBase>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //botao para escolher o arquivo e gerar os graficos

        public void button1_Click(object sender, EventArgs e)
        {
            //Comando para Escolher o arquivo a ser aberto
            OpenFileDialog Arqcsv = new OpenFileDialog();
            Arqcsv.Title = "Open CSV File";
            Arqcsv.Filter = "CSV|*.csv";
            if (Arqcsv.ShowDialog() == DialogResult.OK)
            {

                //Definindo o nome do arquivo CSV que será lido, esse nome foi absorvido pelo OpenFileDialog
                TextReader reader = File.OpenText(Arqcsv.FileName.ToString());

                CsvReader csv = new CsvReader(reader);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;

                //Fazendo a leitura do Documento CSV e Adicionando 
                while (csv.Read())
                {
                    DataBase Record = csv.GetRecord<DataBase>();
                    ListDataBase.Add(Record);

                }


            }


            //---------Grafico VOTOS x OPÇOES---------

            Double qnt1 = 0;
            Double qnt2 = 0;
            Double qnt3 = 0;
            Double qnt4 = 0;
            Double qnt5 = 0;
            Double qnt6 = 0;
            Double qntNull = 0;
            Double total = 0;


            foreach (DataBase dados in ListDataBase)
            {
                total++;
                int resposta;
                int ra = Convert.ToInt16(dados.Btn1);
                int rb = Convert.ToInt16(dados.Btn2);
                int rc = Convert.ToInt16(dados.Btn3);
                int rd = Convert.ToInt16(dados.Btn4);
                int re = Convert.ToInt16(dados.Btn5);
                int rf = Convert.ToInt16(dados.Btn6);


                if (ra == 1)
                {
                    resposta = 1;
                    qnt1++;
                }
                else if (rb == 1)
                {
                    resposta = 2;
                    qnt2++;
                }
                else if (rc == 1)
                {
                    resposta = 3;
                    qnt3++;
                }
                else if (rd == 1)
                {
                    resposta = 4;
                    qnt4++;
                }
                else if (re == 1)
                {
                    resposta = 5;
                    qnt5++;
                }
                else if (rf == 1)
                {
                    resposta = 6;
                    qnt6++;
                }
                else
                {
                    qntNull++;
                }
            }
            Double porcent1 = (qnt1 / total) * 100;
            Double porcent2 = (qnt2 / total) * 100;
            Double porcent3 = (qnt3 / total) * 100;
            Double porcent4 = (qnt4 / total) * 100;
            Double porcent5 = (qnt5 / total) * 100;
            Double porcent6 = (qnt6 / total) * 100;
            Double porcentN = (qntNull / total) * 100;

            //atribuindo valores as colunas do grafico
            this.chart1.Series[0].Label = "#PERCENT";
            this.chart1.Series["votos"].Points.AddXY("A", Math.Round(porcent1, 2));
            this.chart1.Series["votos"].Points.AddXY("B", Math.Round(porcent2, 2));
            this.chart1.Series["votos"].Points.AddXY("C", Math.Round(porcent3, 2));
            this.chart1.Series["votos"].Points.AddXY("D", Math.Round(porcent4, 2));
            this.chart1.Series["votos"].Points.AddXY("E", Math.Round(porcent5, 2));
            this.chart1.Series["votos"].Points.AddXY("F", Math.Round(porcent6, 2));
            this.chart1.Series["votos"].Points.AddXY("NULL", Math.Round(porcentN, 2));// verificaçao de Problema nos controles
                 //removendo linhas de grade
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
         
            //Definindo nome aos eixos
            chart1.ChartAreas[0].AxisX.Title = "Opção";
            chart1.ChartAreas[0].AxisY.Title = "% de Votos";
            // definindo valores exibidos em porcentagem
            this.chart1.Series[0].Label = "#PERCENT";






            //----------HISTOGRAMA--------
            

            DateTime FirstTime = DateTime.MaxValue;
            DateTime LastTime = DateTime.MinValue;
            DateTime tempo = DateTime.MaxValue;

            foreach (DataBase time in ListDataBase)
            {
                tempo = Convert.ToDateTime(time.Timestamp);
                //Defini qual o tempo do primeiro voto.
                if (FirstTime >= tempo)
                {
                    FirstTime = tempo;
                }
                //define qual o Tempo do ultimo voto
                if (LastTime <= tempo)
                {
                    LastTime = tempo;
                }
            }

            int[] conta = new int[10];
            int i;

            //leitura de todos os tempos dos dados 
            foreach (DataBase time in ListDataBase)
            {
                tempo = Convert.ToDateTime(time.Timestamp);
                // implementaçao do histograma, partindo do primeiro voto ate 10 minutos depois, pulando de miuto em minuto
                for (i = 0; i <= 10; i++)
                {

                    if (tempo.Minute == FirstTime.AddMinutes(i).Minute)
                    {
                        conta[i]++;

                    }
                }
            }
            for (i = 0; i < 10; i++)
            {
                this.Hist.Series["Tempo"].Points.AddXY(i, conta[i]);
            }
            //Definindo Nome aos eixos
            Hist.ChartAreas[0].AxisX.Title = "Tempo [min]";
            Hist.ChartAreas[0].AxisY.Title = "Quantidade de votos";
            Hist.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            Hist.Series[0].IsValueShownAsLabel = true;





            // ----------------grafico de relaçao ----------------

            //vetor que define a classificaçao dos dos votos em ordem crescente do tempo
            DateTime[] classificacao = new DateTime[ListDataBase.Count];

            int a = 0;
            DateTime aux;
           

            //leitura de todos os tempos e colocando esses tempos no vetor [valor]
            classificacao[0] = FirstTime;
            foreach (DataBase time in ListDataBase)
            {
                classificacao[a] = DateTime.Parse(time.Timestamp);
                a++;
                
            }
           
            //comando para colocar o vetor de classificaçao na ordem CRESCENTE em relaçao ao tempo
            for (i = 0; i < ListDataBase.Count; i++)
            {
                for (a = i + 1; a <ListDataBase.Count; a++)
                {
                    if (classificacao[i] > classificacao[a])
                    {
                        aux = classificacao[i];
                        classificacao[i] = classificacao[a];
                        classificacao[a] = aux;
                    }
                }
            }


            //criando o grafico
            for (i = 0; i < ListDataBase.Count; i++)
            {
                
                this.Colocacao.Series["Place"].Points.AddXY(i, classificacao[i].Second);
            }

            //Definindo Nome aos eixos,excluindo linha de grade e mostrando valores em cada ponto
            Colocacao.ChartAreas[0].AxisX.Title = "COLOCAÇAO";
            Colocacao.ChartAreas[0].AxisY.Title = "TEMPO[s]";
            Colocacao.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            Colocacao.Series[0].IsValueShownAsLabel = true;










        }

        


        // botao para criar o pdf com os dados e graficos
        private void btnLoadChart_Click(object sender, EventArgs e)
        {



            //Criando o PDF na pasta atual do programa
            Document PDF = new Document(PageSize.A4);
            PDF.SetMargins(3, 2, 3, 2);
            // OpenFileDialog ArqPDF = new OpenFileDialog();
            // String CaminhoPDF = ArqPDF.FileName.ToString();
            // TextReader reader = File.OpenText(Arqcsv.FileName.ToString());
            PdfWriter writer = PdfWriter.GetInstance(PDF, new FileStream(Directory.GetCurrentDirectory() + "\\Votoino-Reports.pdf", FileMode.Create));
            PDF.Open();



            // Inserindo imagem Do IFSP
            var imagemDoTopo = iTextSharp.text.Image.GetInstance(Directory.GetCurrentDirectory() + "\\ifsp.jpg");
            imagemDoTopo.SetAbsolutePosition(40, 730);
            imagemDoTopo.ScalePercent(40f);
            PDF.Add(imagemDoTopo);

            //inserindo Arte Votoino
            var ArteVotoino = iTextSharp.text.Image.GetInstance(Directory.GetCurrentDirectory() + "\\ArteVotoino.png");

            ArteVotoino.SetAbsolutePosition(170, 710);
            ArteVotoino.ScalePercent(35f);
            PDF.Add(ArteVotoino);


            //Textos 

            //Definindo formato do texto


            //formato de textos inseridos pelo usuario
            PdfContentByte type1 = writer.DirectContent;
            BaseFont Fonte_1 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, false, false);
            type1.SetFontAndSize(Fonte_1, 8);
            type1.SetColorFill(new BaseColor(0, 0, 0));


            //formato de textos fixos
            PdfContentByte type2 = writer.DirectContent;
            BaseFont Fonte_2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, false, false);
            type2.SetFontAndSize(Fonte_2, 14);
            type2.SetColorFill(new BaseColor(0, 0, 0));



            //Escrevendo Cabecalho
            type2.BeginText();
            String linhaA = " CURSO :                                                         TURMA : ";
            type2.ShowTextAligned(PdfContentByte.ALIGN_LEFT, linhaA, 125, 670, 0);
            type2.EndText();
            // ---------------
            type2.BeginText();
            String linhaB = " DATA : ";
            type2.ShowTextAligned(PdfContentByte.ALIGN_LEFT, linhaB, 125, 650, 0);
            type2.EndText();
            //------------------
            type2.BeginText();
            String linhaC = " QUESTAO :                                         RESPOSTA CORRETA :  ";
            type2.ShowTextAligned(PdfContentByte.ALIGN_LEFT, linhaC, 125, 630, 0);
            type2.EndText();
            //----------------



            //texto do Curso
            type1.BeginText();
            type1.ShowTextAligned(PdfContentByte.ALIGN_LEFT, textBoxCurso.Text.ToUpper(), 190, 670, 0);
            type1.EndText();



            //texto da Turma
            type1.BeginText();
            type1.ShowTextAligned(PdfContentByte.ALIGN_LEFT, textBoxTurma.Text .ToUpper(), 450, 670, 0);
            type1.EndText();




            // Texto da data    
            type1.BeginText();
            type1.ShowTextAligned(PdfContentByte.ALIGN_LEFT, dateTimeBox.Text.ToUpper(), 180, 650, 0);
            type1.EndText();



            //texto da Questao Estuda
            type1.BeginText();
            type1.ShowTextAligned(PdfContentByte.ALIGN_LEFT, textBoxQuestao.Text.ToUpper(), 210, 630, 0);
            type1.EndText();



            //texto da Resposta correta
            type1.BeginText();
            type1.ShowTextAligned(PdfContentByte.ALIGN_LEFT, textBoxResp.Text.ToUpper(), 500, 630, 0);
            type1.EndText();

            //Plotando Grafico 1 no PDF
            using (MemoryStream memoryStream = new MemoryStream())
            {
                chart1.SaveImage(memoryStream, ChartImageFormat.Png);
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(memoryStream.GetBuffer());
                img.ScalePercent(70f);
                img.SetAbsolutePosition(100, 380);
                PDF.Add(img);
            }

            PDF.Close();

            MessageBox.Show("PDF Gerado com Sucesso!");

            //abrindo PDF gerado
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = Directory.GetCurrentDirectory() + "\\Votoino-Reports.pdf";
            System.Diagnostics.Process.Start(startInfo);
        }


    }
}














