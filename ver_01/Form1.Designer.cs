namespace ver_01
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
            this.btConnect = new System.Windows.Forms.Button();
            this.comboBoxPortas = new System.Windows.Forms.ComboBox();
            this.btLeituraCorrigida = new System.Windows.Forms.Button();
            this.btLeituraPura = new System.Windows.Forms.Button();
            this.btOffSet = new System.Windows.Forms.Button();
            this.btAjusteOffSet = new System.Windows.Forms.Button();
            this.txtLeituraCorrigida = new System.Windows.Forms.NumericUpDown();
            this.txtLeituraPura = new System.Windows.Forms.NumericUpDown();
            this.txtOffSet = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBoxPadrao = new System.Windows.Forms.MaskedTextBox();
            this.labelConexao = new System.Windows.Forms.Label();
            this.labelMedicoes = new System.Windows.Forms.Label();
            this.labelErros = new System.Windows.Forms.Label();
            this.labelNumeroMedicoes = new System.Windows.Forms.Label();
            this.labelNumeroErros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btAtualizarPortas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaidaPwm = new System.Windows.Forms.Button();
            this.SaidaPWM = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSet20mA = new System.Windows.Forms.Button();
            this.Set20mA = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btn4mA = new System.Windows.Forms.Button();
            this.Set4Ma = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMax = new System.Windows.Forms.Button();
            this.LeituraMax = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.LeituraMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btLimparJanelas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeituraCorrigida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeituraPura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaidaPWM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Set20mA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Set4Ma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeituraMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeituraMin)).BeginInit();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(24, 34);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(86, 37);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Conectar";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // comboBoxPortas
            // 
            this.comboBoxPortas.FormattingEnabled = true;
            this.comboBoxPortas.Location = new System.Drawing.Point(120, 43);
            this.comboBoxPortas.Name = "comboBoxPortas";
            this.comboBoxPortas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPortas.TabIndex = 1;
            // 
            // btLeituraCorrigida
            // 
            this.btLeituraCorrigida.Location = new System.Drawing.Point(12, 32);
            this.btLeituraCorrigida.Name = "btLeituraCorrigida";
            this.btLeituraCorrigida.Size = new System.Drawing.Size(86, 37);
            this.btLeituraCorrigida.TabIndex = 2;
            this.btLeituraCorrigida.Text = "Leituras\r\nParar";
            this.btLeituraCorrigida.UseVisualStyleBackColor = true;
            this.btLeituraCorrigida.Click += new System.EventHandler(this.btLeituraCorrigida_Click);
            // 
            // btLeituraPura
            // 
            this.btLeituraPura.Location = new System.Drawing.Point(339, 33);
            this.btLeituraPura.Name = "btLeituraPura";
            this.btLeituraPura.Size = new System.Drawing.Size(86, 37);
            this.btLeituraPura.TabIndex = 3;
            this.btLeituraPura.Text = "Leitura\r\nPura";
            this.btLeituraPura.UseVisualStyleBackColor = true;
            this.btLeituraPura.Click += new System.EventHandler(this.btLeituraPura_Click);
            // 
            // btOffSet
            // 
            this.btOffSet.Location = new System.Drawing.Point(12, 115);
            this.btOffSet.Name = "btOffSet";
            this.btOffSet.Size = new System.Drawing.Size(86, 37);
            this.btOffSet.TabIndex = 4;
            this.btOffSet.Text = "Off Set";
            this.btOffSet.UseVisualStyleBackColor = true;
            this.btOffSet.Click += new System.EventHandler(this.btOffSet_Click);
            // 
            // btAjusteOffSet
            // 
            this.btAjusteOffSet.Location = new System.Drawing.Point(339, 114);
            this.btAjusteOffSet.Name = "btAjusteOffSet";
            this.btAjusteOffSet.Size = new System.Drawing.Size(86, 37);
            this.btAjusteOffSet.TabIndex = 5;
            this.btAjusteOffSet.Text = "Ajuste\r\nOff Set";
            this.btAjusteOffSet.UseVisualStyleBackColor = true;
            this.btAjusteOffSet.Click += new System.EventHandler(this.btAjusteOffSet_Click);
            // 
            // txtLeituraCorrigida
            // 
            this.txtLeituraCorrigida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeituraCorrigida.Location = new System.Drawing.Point(108, 33);
            this.txtLeituraCorrigida.Name = "txtLeituraCorrigida";
            this.txtLeituraCorrigida.Size = new System.Drawing.Size(121, 36);
            this.txtLeituraCorrigida.TabIndex = 8;
            this.txtLeituraCorrigida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLeituraPura
            // 
            this.txtLeituraPura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeituraPura.Location = new System.Drawing.Point(432, 33);
            this.txtLeituraPura.Name = "txtLeituraPura";
            this.txtLeituraPura.Size = new System.Drawing.Size(121, 36);
            this.txtLeituraPura.TabIndex = 9;
            this.txtLeituraPura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOffSet
            // 
            this.txtOffSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffSet.Location = new System.Drawing.Point(108, 115);
            this.txtOffSet.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtOffSet.Name = "txtOffSet";
            this.txtOffSet.Size = new System.Drawing.Size(121, 36);
            this.txtOffSet.TabIndex = 10;
            this.txtOffSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxPadrao
            // 
            this.maskedTextBoxPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPadrao.Location = new System.Drawing.Point(432, 115);
            this.maskedTextBoxPadrao.Mask = "00,00";
            this.maskedTextBoxPadrao.Name = "maskedTextBoxPadrao";
            this.maskedTextBoxPadrao.Size = new System.Drawing.Size(121, 36);
            this.maskedTextBoxPadrao.TabIndex = 16;
            this.maskedTextBoxPadrao.Text = "0000";
            this.maskedTextBoxPadrao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxPadrao.Enter += new System.EventHandler(this.maskedTextBoxPadrao_Enter);
            // 
            // labelConexao
            // 
            this.labelConexao.AutoSize = true;
            this.labelConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConexao.Location = new System.Drawing.Point(21, 18);
            this.labelConexao.Name = "labelConexao";
            this.labelConexao.Size = new System.Drawing.Size(153, 16);
            this.labelConexao.TabIndex = 17;
            this.labelConexao.Text = "Máquina não conectada";
            // 
            // labelMedicoes
            // 
            this.labelMedicoes.AutoSize = true;
            this.labelMedicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicoes.Location = new System.Drawing.Point(296, 48);
            this.labelMedicoes.Name = "labelMedicoes";
            this.labelMedicoes.Size = new System.Drawing.Size(141, 16);
            this.labelMedicoes.TabIndex = 18;
            this.labelMedicoes.Text = "Numero de medições:";
            // 
            // labelErros
            // 
            this.labelErros.AutoSize = true;
            this.labelErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErros.Location = new System.Drawing.Point(296, 70);
            this.labelErros.Name = "labelErros";
            this.labelErros.Size = new System.Drawing.Size(112, 16);
            this.labelErros.TabIndex = 19;
            this.labelErros.Text = "Numero de erros:";
            // 
            // labelNumeroMedicoes
            // 
            this.labelNumeroMedicoes.AutoSize = true;
            this.labelNumeroMedicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroMedicoes.Location = new System.Drawing.Point(441, 48);
            this.labelNumeroMedicoes.Name = "labelNumeroMedicoes";
            this.labelNumeroMedicoes.Size = new System.Drawing.Size(15, 16);
            this.labelNumeroMedicoes.TabIndex = 20;
            this.labelNumeroMedicoes.Text = "0";
            // 
            // labelNumeroErros
            // 
            this.labelNumeroErros.AutoSize = true;
            this.labelNumeroErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroErros.Location = new System.Drawing.Point(441, 70);
            this.labelNumeroErros.Name = "labelNumeroErros";
            this.labelNumeroErros.Size = new System.Drawing.Size(15, 16);
            this.labelNumeroErros.TabIndex = 21;
            this.labelNumeroErros.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Padrão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Resultado";
            // 
            // btAtualizarPortas
            // 
            this.btAtualizarPortas.Location = new System.Drawing.Point(24, 77);
            this.btAtualizarPortas.Name = "btAtualizarPortas";
            this.btAtualizarPortas.Size = new System.Drawing.Size(86, 37);
            this.btAtualizarPortas.TabIndex = 30;
            this.btAtualizarPortas.Text = "Atualizar Portas";
            this.btAtualizarPortas.UseVisualStyleBackColor = true;
            this.btAtualizarPortas.Click += new System.EventHandler(this.btAtualizarPortas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaidaPwm);
            this.panel1.Controls.Add(this.SaidaPWM);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnSet20mA);
            this.panel1.Controls.Add(this.Set20mA);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn4mA);
            this.panel1.Controls.Add(this.Set4Ma);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.LeituraMax);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.LeituraMin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btLeituraCorrigida);
            this.panel1.Controls.Add(this.btLeituraPura);
            this.panel1.Controls.Add(this.btOffSet);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btAjusteOffSet);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLeituraCorrigida);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLeituraPura);
            this.panel1.Controls.Add(this.txtOffSet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.maskedTextBoxPadrao);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 412);
            this.panel1.TabIndex = 31;
            // 
            // btnSaidaPwm
            // 
            this.btnSaidaPwm.Location = new System.Drawing.Point(12, 346);
            this.btnSaidaPwm.Name = "btnSaidaPwm";
            this.btnSaidaPwm.Size = new System.Drawing.Size(86, 36);
            this.btnSaidaPwm.TabIndex = 42;
            this.btnSaidaPwm.Text = "Saída PWM";
            this.btnSaidaPwm.UseVisualStyleBackColor = true;
            this.btnSaidaPwm.Click += new System.EventHandler(this.btnSaidaPwm_Click);
            // 
            // SaidaPWM
            // 
            this.SaidaPWM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold);
            this.SaidaPWM.Location = new System.Drawing.Point(108, 346);
            this.SaidaPWM.Name = "SaidaPWM";
            this.SaidaPWM.Size = new System.Drawing.Size(120, 36);
            this.SaidaPWM.TabIndex = 41;
            this.SaidaPWM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(105, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Resultado";
            // 
            // btnSet20mA
            // 
            this.btnSet20mA.Location = new System.Drawing.Point(334, 277);
            this.btnSet20mA.Name = "btnSet20mA";
            this.btnSet20mA.Size = new System.Drawing.Size(89, 34);
            this.btnSet20mA.TabIndex = 39;
            this.btnSet20mA.Text = "Set 20mA";
            this.btnSet20mA.UseVisualStyleBackColor = true;
            this.btnSet20mA.Click += new System.EventHandler(this.btnSet20mA_Click);
            // 
            // Set20mA
            // 
            this.Set20mA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold);
            this.Set20mA.Location = new System.Drawing.Point(432, 277);
            this.Set20mA.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Set20mA.Name = "Set20mA";
            this.Set20mA.Size = new System.Drawing.Size(120, 36);
            this.Set20mA.TabIndex = 38;
            this.Set20mA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(429, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Resultado";
            // 
            // btn4mA
            // 
            this.btn4mA.Location = new System.Drawing.Point(12, 275);
            this.btn4mA.Name = "btn4mA";
            this.btn4mA.Size = new System.Drawing.Size(86, 36);
            this.btn4mA.TabIndex = 36;
            this.btn4mA.Text = "Set 4mA";
            this.btn4mA.UseVisualStyleBackColor = true;
            this.btn4mA.Click += new System.EventHandler(this.btn4mA_Click);
            // 
            // Set4Ma
            // 
            this.Set4Ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold);
            this.Set4Ma.Location = new System.Drawing.Point(108, 275);
            this.Set4Ma.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Set4Ma.Name = "Set4Ma";
            this.Set4Ma.Size = new System.Drawing.Size(120, 36);
            this.Set4Ma.TabIndex = 35;
            this.Set4Ma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(105, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Resultado";
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(334, 197);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(89, 36);
            this.btnMax.TabIndex = 33;
            this.btnMax.Text = "Leitura Máxima";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // LeituraMax
            // 
            this.LeituraMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold);
            this.LeituraMax.Location = new System.Drawing.Point(432, 197);
            this.LeituraMax.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.LeituraMax.Name = "LeituraMax";
            this.LeituraMax.Size = new System.Drawing.Size(120, 36);
            this.LeituraMax.TabIndex = 32;
            this.LeituraMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(429, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Resultado";
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(12, 197);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(86, 35);
            this.btnMin.TabIndex = 30;
            this.btnMin.Text = "Leitura Mínima";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // LeituraMin
            // 
            this.LeituraMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold);
            this.LeituraMin.Location = new System.Drawing.Point(108, 196);
            this.LeituraMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LeituraMin.Name = "LeituraMin";
            this.LeituraMin.Size = new System.Drawing.Size(120, 36);
            this.LeituraMin.TabIndex = 29;
            this.LeituraMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(105, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Resultado";
            // 
            // btLimparJanelas
            // 
            this.btLimparJanelas.Location = new System.Drawing.Point(120, 77);
            this.btLimparJanelas.Name = "btLimparJanelas";
            this.btLimparJanelas.Size = new System.Drawing.Size(86, 37);
            this.btLimparJanelas.TabIndex = 32;
            this.btLimparJanelas.Text = "Limpar\r\nJanelas";
            this.btLimparJanelas.UseVisualStyleBackColor = true;
            this.btLimparJanelas.Click += new System.EventHandler(this.btLimparJanelas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(622, 559);
            this.Controls.Add(this.btLimparJanelas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btAtualizarPortas);
            this.Controls.Add(this.labelNumeroErros);
            this.Controls.Add(this.labelNumeroMedicoes);
            this.Controls.Add(this.labelErros);
            this.Controls.Add(this.labelMedicoes);
            this.Controls.Add(this.labelConexao);
            this.Controls.Add(this.comboBoxPortas);
            this.Controls.Add(this.btConnect);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transmissor TXDAC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtLeituraCorrigida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeituraPura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaidaPWM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Set20mA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Set4Ma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeituraMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeituraMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ComboBox comboBoxPortas;
        private System.Windows.Forms.Button btLeituraCorrigida;
        private System.Windows.Forms.Button btLeituraPura;
        private System.Windows.Forms.Button btOffSet;
        private System.Windows.Forms.Button btAjusteOffSet;
        private System.Windows.Forms.NumericUpDown txtLeituraCorrigida;
        private System.Windows.Forms.NumericUpDown txtLeituraPura;
        private System.Windows.Forms.NumericUpDown txtOffSet;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPadrao;
        private System.Windows.Forms.Label labelConexao;
        private System.Windows.Forms.Label labelMedicoes;
        private System.Windows.Forms.Label labelErros;
        private System.Windows.Forms.Label labelNumeroMedicoes;
        private System.Windows.Forms.Label labelNumeroErros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAtualizarPortas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btLimparJanelas;
        private System.Windows.Forms.Button btn4mA;
        private System.Windows.Forms.NumericUpDown Set4Ma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.NumericUpDown LeituraMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.NumericUpDown LeituraMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaidaPwm;
        private System.Windows.Forms.NumericUpDown SaidaPWM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSet20mA;
        private System.Windows.Forms.NumericUpDown Set20mA;
        private System.Windows.Forms.Label label8;
    }
}

