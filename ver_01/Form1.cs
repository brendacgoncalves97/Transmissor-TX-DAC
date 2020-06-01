using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;

namespace ver_01
{
    public partial class Form1 : Form
    {
        #region Variaveis
        private SerialPort serialPort;

        private bool _isConnected = false;
        private bool _isCommunicaticating = false;
        private bool _verificaErro = false;
        private bool _Desliga = false;
        private bool _isAutomatic = true;
        private bool _isBotao = false;
        private bool _isAtualizaPortas = false;
        private bool isLeituraPura = false;

        private int numeroComando;
        private int numeroBt;
        private int numeroRepeticoes = 0;
        private int numeroErros = 0;
        private int leituraPura = 0;
        private int delaySend = 1000;

        private List<string> listaComandosHex;
        private List<int> listaComandosInt;
        private List<int> listaComandosNumeroEsperado;
        private List<int> listaComandosAtivacao;
        #endregion

        #region Suporte

        public Form1()
        {
            InitializeComponent();
            ListaComandos();
            Thread t = new Thread(AtualizaListaPortas);
            t.Start();
        }

        public void AtualizaListaPortas()
        {
            Thread.Sleep(500);
            Invoke((Action)delegate 
            {
                bool _isDiferente = false;
                var portas = SerialPort.GetPortNames().OrderBy(x => x).ToList();
                if (comboBoxPortas.Items.Count == 0)
                {
                    foreach (var porta in portas)
                    {
                        comboBoxPortas.Items.Add(porta);
                    }
                    if (comboBoxPortas.Items.Count != 0)
                    {
                        comboBoxPortas.SelectedIndex = 0;
                        _isDiferente = true;
                    }
                }
                else
                {
                    if (portas.Count == 0)
                        _isDiferente = true;
                    if (portas.Count != 0)
                    {
                        if (portas.Count != comboBoxPortas.Items.Count)
                            _isDiferente = true;
                        else
                        {
                            for (int i = 0; i < comboBoxPortas.Items.Count; i++)
                            {
                                if (comboBoxPortas.Items[i].ToString() != portas[i])
                                    _isDiferente = true;
                            }
                        }
                    }
                }
                if (_isDiferente == true)
                {
                    comboBoxPortas.Items.Clear();
                    foreach (var porta in portas)
                    {
                        comboBoxPortas.Items.Add(porta);
                    }
                    if (comboBoxPortas.Items.Count != 0)
                        comboBoxPortas.SelectedIndex = 0;
                    else
                        comboBoxPortas.Text = "";
                }
                if (_isAtualizaPortas)
                {
                    if (_isDiferente)
                        MessageBox.Show("Portas atualizadas com sucesso!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!_isDiferente)
                        MessageBox.Show("Não há nenhuma outra porta conectada!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    _isAtualizaPortas = false;
                }
                if (comboBoxPortas.Items.Count == 1 && _isDiferente)
                {
                    btConnect.PerformClick();
                }
            });            
        }

        public void ListaComandos()
        {
            var comands = new List<string>();
            var comandsInt = new List<int>();
            var answer = new List<int>();

            comands.Add("80"); comandsInt.Add(128); answer.Add(4);
            comands.Add("81"); comandsInt.Add(129); answer.Add(4);
            //comands.Add("82"); comandsInt.Add(130); answer.Add(3);
            comands.Add("83"); comandsInt.Add(131); answer.Add(1);
            comands.Add("84"); comandsInt.Add(54); answer.Add(1);
            comands.Add("85"); comandsInt.Add(55); answer.Add(1);
            comands.Add("86"); comandsInt.Add(56); answer.Add(1);
            comands.Add("87"); comandsInt.Add(57); answer.Add(1);
            comands.Add("88"); comandsInt.Add(58); answer.Add(4);

            listaComandosHex = comands;
            listaComandosInt = comandsInt;
            listaComandosNumeroEsperado = answer;

            listaComandosAtivacao = new List<int>();
            listaComandosAtivacao.Add(170);
        }

        public void AtualizaGeral()
        {
            Invoke((Action)delegate
            {
                if (_isConnected && !_isCommunicaticating)
                {
                    btConnect.Text = "Desconectar";
                    labelConexao.Text = "Esperando comunicação com a máquina";
                    btAtualizarPortas.Enabled = false;
                    comboBoxPortas.Enabled = false;
                    panel1.Enabled = true;
                }
                if (_isConnected && _isCommunicaticating)
                {
                    labelConexao.Text = "Pronto para o uso";
                    panel1.Enabled = true;                    
                }
                if (_Desliga)
                {
                    _isConnected = false;
                    _isCommunicaticating = false;
                    _Desliga = false;
                    _verificaErro = false;
                    _isAutomatic = true;

                    numeroRepeticoes = 0;
                    numeroErros = 0;
                    leituraPura = 0;

                    btConnect.Text = "Conectar";
                    btLeituraCorrigida.Text = "Leituras \n Parar";
                    labelConexao.Text = "Máquina não conectada";
                    labelNumeroErros.Text = "0";
                    labelNumeroMedicoes.Text = "0";

                    panel1.Enabled = false;
                    comboBoxPortas.Enabled = true;
                    btAtualizarPortas.Enabled = true;
                }
            });            
        } 

        public void verificandoErro(List<byte> lista)
        {
            _verificaErro = false;

            bool primeiroItem = false;
            bool numeroItems = false;
            if (listaComandosInt[numeroComando] == lista[0])
            {
                primeiroItem = true;
                if (lista.Count == listaComandosNumeroEsperado[numeroComando])
                    numeroItems = true;
            }
            if (!primeiroItem || !numeroItems)
            {
                numeroErros++;
                Invoke((Action)delegate { labelNumeroErros.Text = numeroErros.ToString(); });
            }
            if(numeroErros > 3)
            {
                Invoke((Action)delegate { btConnect.PerformClick(); });
                MessageBox.Show("Numero de erros passou do valor muito elevado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskedTextBoxPadrao_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                maskedTextBoxPadrao.Select(0, 5);
            });
        }

        private void btAtualizarPortas_Click(object sender, EventArgs e)
        {
            _isAtualizaPortas = true;
            AtualizaListaPortas();
        }

        private void btLimparJanelas_Click(object sender, EventArgs e)
        {
            txtLeituraCorrigida.Text = "";
            txtLeituraPura.Text = "";
            txtOffSet.Text = "";
            LeituraMax.Text = "";
            LeituraMin.Text = "";
            Set4Ma.Text = "";
            Set20mA.Text = "";
            SaidaPWM.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isConnected == true)
            {
                btConnect.PerformClick();
                Thread.Sleep(500);
            }
        }

        #endregion

        #region Serial

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (_isConnected == true)
            {
                serialPort.Close();
                _Desliga = true;
                AtualizaGeral();
                Thread.Sleep(500);
                return;
            }
            else
            {
                try
                {
                    serialPort = new SerialPort(comboBoxPortas.Items[comboBoxPortas.SelectedIndex].ToString(), 19200, Parity.None, 8);
                    serialPort.DtrEnable = true;
                    serialPort.RtsEnable = false;
                    serialPort.ReadBufferSize = 50000;
                    serialPort.WriteBufferSize = 50000;
                    serialPort.Open();
                    _isConnected = true;
                }
                catch
                {
                    MessageBox.Show("Não foi Possível abrir a Porta Informada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_isConnected == true)
                {
                    AtualizaGeral();
                    Thread t = new Thread(new ThreadStart(readSerial));
                    t.Start();
                }
            }
        }

        private void readSerial()
        {
            List<int> listaResposta = new List<int>();
            List<byte> listaRetorno = new List<byte>();
            while (_isConnected)
            {
                listaResposta.Clear();
                listaRetorno.Clear();

                Thread.Sleep(delaySend);
                if (_isCommunicaticating)
                {
                    if (_isBotao || _isAutomatic)
                        writeSerial();
                }

                try
                {
                    if (serialPort.BytesToRead == 0 && _verificaErro)
                    {
                        this.Invoke((Action)delegate { btConnect.PerformClick(); });
                        MessageBox.Show("Não foi recebido nenhuma resposta da Máquina!" + "\n" + "Verifique a Conexão!",
                            "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    else
                    {
                        while (serialPort.BytesToRead > 0)
                        {
                            var read = serialPort.BytesToRead;
                            var buff = new byte[read];
                            serialPort.Read(buff, 0, read);
                            listaRetorno.AddRange(buff.ToList());
                        }
                    }
                }
                catch { }

                int i = 0;
                int soma = 0;

                foreach (var item in listaRetorno)
                {
                    if (i == 0)
                    {
                        if (item != listaComandosInt[numeroComando] && _isCommunicaticating)
                        {
                            this.Invoke((Action)delegate { btConnect.PerformClick(); });
                            MessageBox.Show("Erro: 1º byte não corresponde ao valor esperado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (item == listaComandosAtivacao[0] && _isCommunicaticating)
                            _isCommunicaticating = false;
                        if (item == listaComandosAtivacao[0] && !_isCommunicaticating)
                        {
                            try
                            {
                                serialPort.Write(new[] { Convert.ToByte(listaComandosAtivacao[0]) }, 0, 1);
                                _isCommunicaticating = true;
                                AtualizaGeral();
                                Thread.Sleep(500);
                                continue;
                            }
                            catch
                            {
                                MessageBox.Show("Erro ao iniciar a comunicação com a máquina!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (_isCommunicaticating)
                    {
                        if (i == 1)
                            soma = item * 256;
                        if (i == 2)
                        {
                            soma += item;
                            listaResposta.Add(soma);
                            i = 0;
                            soma = 0;
                        }                        
                    }
                    i++;
                }
                if (_verificaErro)
                {
                    verificandoErro(listaRetorno);
                    escreveResposta(listaResposta, listaRetorno);
                }
                Thread.Sleep(500);
            }
        }

        private void writeSerial()
        {
            if(_isCommunicaticating)
            {
                if(_isBotao)
                {
                    if(numeroBt != 3)
                    {
                        numeroComando = numeroBt;
                        byte[] b = new byte[] { Convert.ToByte(listaComandosInt[numeroComando]) };
                        serialPort.Write(b, 0, b.Length);

                        if (_isBotao) _isBotao = false;
                    }
                    else
                    {                        
                        if(isLeituraPura)
                        {
                            numeroComando = numeroBt;
                            string padrao = maskedTextBoxPadrao.Text.Remove(2, 1);
                            int valorAjustado = Convert.ToInt32(padrao) - leituraPura;

                            byte[] buffer = new byte[2];
                            buffer[1] = (byte)valorAjustado;
                            buffer[0] = (byte)(valorAjustado >> 8);

                            byte[] b = new byte[3];
                            b[0] = Convert.ToByte(listaComandosInt[numeroComando]);
                            b[1] = buffer[0];
                            b[2] = buffer[1];

                            serialPort.Write(b, 0, b.Length);

                            isLeituraPura = false;
                            _isBotao = false;
                            Invoke((Action)delegate { panel1.Enabled = true; });
                            delaySend = 1000;
                        }
                        else
                        {
                            numeroComando = 1;
                            byte[] b = new byte[] { Convert.ToByte(listaComandosInt[numeroComando]) };
                            serialPort.Write(b, 0, b.Length);

                            isLeituraPura = true;
                            delaySend = 0;
                        }
                    }
                }
                else if(_isAutomatic)
                {
                    numeroComando = 0;
                    byte[] b = new byte[] { Convert.ToByte(listaComandosInt[numeroComando]) };
                    serialPort.Write(b, 0, 1);
                }
                _verificaErro = true;
                numeroRepeticoes++;                                
                Invoke((Action)delegate { labelNumeroMedicoes.Text = numeroRepeticoes.ToString(); });
            }
            Thread.Sleep(500);
        }

        private void escreveResposta(List<int> listaResposta, List<byte> listaRetorno)
        {
            Invoke((Action)delegate
            {
                if(listaResposta.Count > 0)
                {
                    if (listaResposta[0] == 0)
                    {
                        numeroRepeticoes--;
                        return;
                    }
                }
                if (numeroComando == 0)
                {
                    string s = listaResposta[0].ToString();
                    s = s.PadLeft(4, '0');
                    s = s.Insert((s.Length - 2), ",");
                    txtLeituraCorrigida.Text = s;
                }
                if (numeroComando == 1)
                {
                    string s = listaResposta[0].ToString();
                    s = s.PadLeft(4, '0');
                    s = s.Insert((s.Length - 2), ",");
                    txtLeituraPura.Text = s;
                    leituraPura = listaResposta[0];
                }
                if (numeroComando == 2)
                {
                    byte B1 = listaRetorno[1];
                    byte B2 = listaRetorno[2];
                    short answer = (short)((B1 << 8) | B2);
           
                    string result = "";
                    if (answer < 0)
                    {
                        result = (answer * -1).ToString().PadLeft(4, '0');
                        result = result.PadLeft(5, '-');
                    }
                    else
                        result = answer.ToString().PadLeft(4, '0');
                    result = result.Insert((result.Length - 2), ",");
                    txtOffSet.Value = Convert.ToInt32(result);
                }
                if (numeroComando == 3)
                {
                    string padrao = maskedTextBoxPadrao.Text.Remove(2, 1);
                    int valorAjustado = Convert.ToInt32(padrao) - leituraPura;
                    string resultado = "";
                    if(valorAjustado < 0)
                    {
                        resultado = (valorAjustado * -1).ToString().PadLeft(4, '0');
                        resultado = resultado.PadLeft(5, '-');
                    }
                    else
                    {
                        resultado = valorAjustado.ToString().PadLeft(4, '0');
                    }
                    resultado = resultado.Insert((resultado.Length - 2), ",");

                    txtOffSet.Value = Convert.ToInt32(resultado);
                }
                if (numeroComando == 4)
                {
                    string s = listaResposta[0].ToString();
                    s = s.PadLeft(3, '0');
                    LeituraMin.Text = s;
                }
                if (numeroComando == 5)
                {

                }
            });            
        } 

        #endregion

        #region Botoes
        private void btLeituraCorrigida_Click(object sender, EventArgs e)
        {            
            _isAutomatic = !_isAutomatic;
            if (_isAutomatic)
                btLeituraCorrigida.Text = "Leituras \n Parar";
            if (!_isAutomatic)
                btLeituraCorrigida.Text = "Leituras \n Continuar";
        }

        private void btLeituraPura_Click(object sender, EventArgs e)
        {
            numeroBt = 1;
            _isBotao = true;
        }

        private void btOffSet_Click(object sender, EventArgs e)
        {
            numeroBt = 2;
            _isBotao = true;
        }

        private void btAjusteOffSet_Click(object sender, EventArgs e)
        {
            bool isPadrao = Regex.IsMatch(maskedTextBoxPadrao.Text, @"\d{2}.\d{2}") && maskedTextBoxPadrao.Text != "00.00";
            if(!isPadrao)
                MessageBox.Show("Formato do Valor Padrão não é válido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!isLeituraPura)
            {
                numeroBt = 3;
                _isBotao = true;
                panel1.Enabled = false;
            }
        }
        #endregion

        private void btnMin_Click(object sender, EventArgs e)
        {
            numeroBt = 4;
            _isBotao = true;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            numeroBt = 5;
            _isBotao = true;
        }
    }
}
