using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SORTEOUAZAR
{
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
            buttonsSort[0] = btnBubble;
            buttonsSort[1] = btnInsertion;
            buttonsSort[2] = btnQuickSort;
            buttonsSort[3] = btnSelection;
            buttonsSort[4] = btnShellSort;
        }

        int[] arrayinteiro;
        int[] newArray;
        private Thread threadRead, threadSort;
        private Button[] buttonsSort = new Button[5];
        private bool sorting = false;
        Stopwatch seconds = new Stopwatch();

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                rchTxtBxScrambled.Clear();
                rchTxtBxUnscrambled.Clear();

                threadRead = new Thread(() => ReadFileThread(rchTxtBxScrambled, lblStatus, OpenFile.FileName));
                threadRead.Start();

                lblStatus.Text = "Carregando...";
                lblStatus.ForeColor = Color.DodgerBlue;

                Application.DoEvents();

            }
        }

        //Thread para ler os arquivos
        private void ReadFileThread(RichTextBox richText, Label lblStatus, string fileName)
        {
            string[] linhas = File.ReadAllLines(fileName);
            SetControlPropertyValue(rchTxtBxScrambled, "Lines", linhas);
            arrayinteiro = linhas.Select(int.Parse).ToArray();
            SetControlPropertyValue(lblStatus, "Text", "Finalizado!");
            SetControlPropertyValue(lblStatus, "ForeColor", Color.Green);
            threadRead.Abort();
        }

        //Thread para processar os dados
        private void SortThread(RichTextBox richText, Label lblStatus, Label lblMethod, string method, Button[] buttons)
        {
            SetControlPropertyValue(lblMethod, "Text", method);
            SetControlPropertyValue(lblStatus, "Text", "Processando...");
            SetControlPropertyValue(lblStatus, "ForeColor", Color.DodgerBlue);

            newArray = new int[arrayinteiro.Length];
            Array.Copy(arrayinteiro, newArray, arrayinteiro.Length);

            sorting = true;
            switch (method)
            {
                case "Bubble Sort":
                    Bubble.bubbleSort(ref newArray);
                    SetControlPropertyValue(lblMoves, "Text", Bubble.movimentos.ToString());
                    SetControlPropertyValue(lblCompara, "Text", Bubble.comparacoes.ToString());
                    break;
                case "Insertion":
                    Insertion.sort(ref newArray);
                    SetControlPropertyValue(lblMoves, "Text", Insertion.movimentos.ToString());
                    SetControlPropertyValue(lblCompara, "Text", Insertion.comparacoes.ToString());
                    break;
                case "Quick Sort":
                    QuickSort.quickSort(newArray);
                    SetControlPropertyValue(lblMoves, "Text", QuickSort.movimentos.ToString());
                    SetControlPropertyValue(lblCompara, "Text", QuickSort.comparacoes.ToString());
                    break;
                case "Selection":
                    Selection.selectionSort(newArray);
                    SetControlPropertyValue(lblMoves, "Text", Selection.movimentos.ToString());
                    SetControlPropertyValue(lblCompara, "Text", Selection.comparacoes.ToString());
                    break;
                case "Shell Sort":
                    ShellSort.shell(newArray);
                    SetControlPropertyValue(lblMoves, "Text", ShellSort.movimentos.ToString());
                    SetControlPropertyValue(lblCompara, "Text", ShellSort.comparacoes.ToString());
                    break;
                default:
                    MessageBox.Show("Erro!, tente selecionar outro metodo de sort", "Erro");
                    break;
            }
            sorting = false;
            SetControlPropertyValue(lblStatus, "Text", "Exibindo Dados...");
            SetControlPropertyValue(lblStatus, "ForeColor", Color.SlateBlue);
            showResult(richText);
            SetControlPropertyValue(lblStatus, "Text", "Finalizado!");
            SetControlPropertyValue(lblStatus, "ForeColor", Color.Green);
            for (int i = 0; i < buttons.Length; i++)
                SetControlPropertyValue(buttons[i], "Enabled", true);

            threadSort.Abort();
        }

        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);

        private void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);

            if (oControl.InvokeRequired) oControl.Invoke(d, new object[] { oControl, propName, propValue });
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();

                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                        break;
                    }
                }
            }
        }

        //Exibe os dados desembaralhados
        private void showResult(RichTextBox richText)
        {
            string[] resultLines = Array.ConvertAll(newArray, x => x.ToString());
            SetControlPropertyValue(richText, "Lines", resultLines);
        }

        //Limpa o RichText
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            rchTxtBxUnscrambled.Clear();
            lblStatusSort.Text = "";
            lblCompara.Text = "0";
            lblMethod.Text = "-";
            lblTime.Text = "0";
            lblMoves.Text = "0";
            seconds.Reset();
        }

        //Sort com Bubble
        private void btnBubble_Click(object sender, EventArgs e)
        {
            Clear();
            for (int i = 0; i < buttonsSort.Length; i++)
                buttonsSort[i].Enabled = false;

            threadSort = new Thread(() => SortThread(rchTxtBxUnscrambled, lblStatusSort, lblMethod, "Bubble Sort", buttonsSort));
            threadSort.Start();
        }

        //Sort com Insertion
        private void btnInsertion_Click(object sender, EventArgs e)
        {
            Clear();
            for (int i = 0; i < buttonsSort.Length; i++)
                buttonsSort[i].Enabled = false;

            threadSort = new Thread(() => SortThread(rchTxtBxUnscrambled, lblStatusSort, lblMethod, "Insertion", buttonsSort));
            threadSort.Start();
        }

        //Sort com Quick Sort
        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            Clear();
            for (int i = 0; i < buttonsSort.Length; i++)
                buttonsSort[i].Enabled = false;

            threadSort = new Thread(() => SortThread(rchTxtBxUnscrambled, lblStatusSort, lblMethod, "Quick Sort", buttonsSort));
            threadSort.Start();
        }

        //Sort com Selection
        private void btnSelection_Click(object sender, EventArgs e)
        {
            Clear();
            for (int i = 0; i < buttonsSort.Length; i++)
                buttonsSort[i].Enabled = false;

            threadSort = new Thread(() => SortThread(rchTxtBxUnscrambled, lblStatusSort, lblMethod, "Selection", buttonsSort));
            threadSort.Start();
        }

        //Sort com Shell Sort
        private void btnShellSort_Click(object sender, EventArgs e)
        {
            Clear();
            for (int i = 0; i < buttonsSort.Length; i++)
                buttonsSort[i].Enabled = false;

            threadSort = new Thread(() => SortThread(rchTxtBxUnscrambled, lblStatusSort, lblMethod, "Shell Sort", buttonsSort));
            threadSort.Start();
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            Refresh();
            if(sorting)
            {            
                seconds.Start();
                if (!sorting)
                {
                    seconds.Stop();
                }
                lblTime.Text = seconds.Elapsed.ToString();
               
            }
       
        }

        //Exporta os dados desembaralhados para um txt
        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*txt)|*.txt";
            saveFileDialog1.FileName = "Dados Sort";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = File.AppendText(saveFileDialog1.FileName);
                writer.Write("Método: " + lblMethod.Text + Environment.NewLine);
                writer.Write("Tempo: " + lblTime.Text + Environment.NewLine);
                writer.Write("Movimentos: " + lblMoves.Text + Environment.NewLine);
                writer.Write("Comparações: " + lblCompara.Text + Environment.NewLine);
                writer.Close();

                MessageBox.Show("Arquivo Salvo com sucesso!", "  ", MessageBoxButtons.OK);
            }
        }
    }
}
