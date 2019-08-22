namespace SORTEOUAZAR
{
    partial class Sort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sort));
            this.btnLerArquivo = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rchTxtBxScrambled = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.rchTxtBxUnscrambled = new System.Windows.Forms.RichTextBox();
            this.lblDadosEmb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnShellSort = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusSort = new System.Windows.Forms.Label();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.lblMoves = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCompara = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLerArquivo
            // 
            this.btnLerArquivo.Location = new System.Drawing.Point(12, 22);
            this.btnLerArquivo.Name = "btnLerArquivo";
            this.btnLerArquivo.Size = new System.Drawing.Size(94, 38);
            this.btnLerArquivo.TabIndex = 0;
            this.btnLerArquivo.Text = "Ler arquivo";
            this.btnLerArquivo.UseVisualStyleBackColor = true;
            this.btnLerArquivo.Click += new System.EventHandler(this.btnLerArquivo_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "Carregardados";
            // 
            // rchTxtBxScrambled
            // 
            this.rchTxtBxScrambled.Location = new System.Drawing.Point(0, 231);
            this.rchTxtBxScrambled.Name = "rchTxtBxScrambled";
            this.rchTxtBxScrambled.Size = new System.Drawing.Size(367, 446);
            this.rchTxtBxScrambled.TabIndex = 1;
            this.rchTxtBxScrambled.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(12, 66);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 33);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rchTxtBxUnscrambled
            // 
            this.rchTxtBxUnscrambled.Location = new System.Drawing.Point(373, 231);
            this.rchTxtBxUnscrambled.Name = "rchTxtBxUnscrambled";
            this.rchTxtBxUnscrambled.Size = new System.Drawing.Size(374, 446);
            this.rchTxtBxUnscrambled.TabIndex = 3;
            this.rchTxtBxUnscrambled.Text = "";
            // 
            // lblDadosEmb
            // 
            this.lblDadosEmb.AutoSize = true;
            this.lblDadosEmb.Location = new System.Drawing.Point(3, 212);
            this.lblDadosEmb.Name = "lblDadosEmb";
            this.lblDadosEmb.Size = new System.Drawing.Size(108, 13);
            this.lblDadosEmb.TabIndex = 4;
            this.lblDadosEmb.Text = "Dados Embaralhados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dados Desembaralhados";
            // 
            // btnBubble
            // 
            this.btnBubble.Location = new System.Drawing.Point(242, 22);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(94, 38);
            this.btnBubble.TabIndex = 6;
            this.btnBubble.Text = "Bubble";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.Location = new System.Drawing.Point(342, 22);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(94, 38);
            this.btnInsertion.TabIndex = 7;
            this.btnInsertion.Text = "Insertion";
            this.btnInsertion.UseVisualStyleBackColor = true;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(442, 22);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(94, 38);
            this.btnQuickSort.TabIndex = 8;
            this.btnQuickSort.Text = "QuickSort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(542, 22);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(94, 38);
            this.btnSelection.TabIndex = 9;
            this.btnSelection.Text = "Selection";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnShellSort
            // 
            this.btnShellSort.Location = new System.Drawing.Point(642, 22);
            this.btnShellSort.Name = "btnShellSort";
            this.btnShellSort.Size = new System.Drawing.Size(94, 38);
            this.btnShellSort.TabIndex = 10;
            this.btnShellSort.Text = "ShellSort";
            this.btnShellSort.UseVisualStyleBackColor = true;
            this.btnShellSort.Click += new System.EventHandler(this.btnShellSort_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(642, 192);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 33);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Exportar";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStatus.Location = new System.Drawing.Point(117, 212);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 12;
            // 
            // lblStatusSort
            // 
            this.lblStatusSort.AutoSize = true;
            this.lblStatusSort.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStatusSort.Location = new System.Drawing.Point(502, 212);
            this.lblStatusSort.Name = "lblStatusSort";
            this.lblStatusSort.Size = new System.Drawing.Size(0, 13);
            this.lblStatusSort.TabIndex = 13;
            // 
            // timerStatus
            // 
            this.timerStatus.Enabled = true;
            this.timerStatus.Interval = 10;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.lblMoves);
            this.groupBoxStatus.Controls.Add(this.label7);
            this.groupBoxStatus.Controls.Add(this.lblCompara);
            this.groupBoxStatus.Controls.Add(this.label5);
            this.groupBoxStatus.Controls.Add(this.lblTime);
            this.groupBoxStatus.Controls.Add(this.lblMethod);
            this.groupBoxStatus.Controls.Add(this.label3);
            this.groupBoxStatus.Controls.Add(this.label1);
            this.groupBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxStatus.Location = new System.Drawing.Point(342, 83);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(394, 88);
            this.groupBoxStatus.TabIndex = 14;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Location = new System.Drawing.Point(278, 29);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(13, 13);
            this.lblMoves.TabIndex = 9;
            this.lblMoves.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Movimentações:";
            // 
            // lblCompara
            // 
            this.lblCompara.AutoSize = true;
            this.lblCompara.Location = new System.Drawing.Point(278, 56);
            this.lblCompara.Name = "lblCompara";
            this.lblCompara.Size = new System.Drawing.Size(13, 13);
            this.lblCompara.TabIndex = 7;
            this.lblCompara.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Comparações:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(68, 56);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "0";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(68, 29);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(10, 13);
            this.lblMethod.TabIndex = 2;
            this.lblMethod.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Método:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo:";
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 686);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.lblStatusSort);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnShellSort);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDadosEmb);
            this.Controls.Add(this.rchTxtBxUnscrambled);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rchTxtBxScrambled);
            this.Controls.Add(this.btnLerArquivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sort";
            this.Text = "Sort ";
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLerArquivo;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rchTxtBxScrambled;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rchTxtBxUnscrambled;
        private System.Windows.Forms.Label lblDadosEmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnShellSort;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusSort;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCompara;
        private System.Windows.Forms.Label label5;
    }
}

