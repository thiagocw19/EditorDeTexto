using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private bool blnSalvar;
        private bool blnAbertoSalvo;
        private string strCaminho;
        private bool blnInserir;
        private Lista lista;
        private string caminhoArquivoLista;

        public Form1()
        {
            InitializeComponent();
            blnSalvar = false;
            blnAbertoSalvo = false;
            strCaminho = string.Empty;
            blnInserir = false;
            lista = new Lista();
            caminhoArquivoLista = "lista_palavras.txt";
            if (File.Exists(caminhoArquivoLista))
            {
                lista.CarregarLista(caminhoArquivoLista);
            }
        }

        private void tsbNovoDocumento_Click(object sender, EventArgs e)
        {
            if (blnSalvar == true)
            {
                DialogResult result = MessageBox.Show("Deseja Salvar o Documento Atual?", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                if (result == DialogResult.Yes)
                {
                    tsbSalvarDocumento_Click(this, new EventArgs());
                    rtbTexto.ResetText();
                    rtbTexto.Clear();
                    blnAbertoSalvo = false;
                    blnSalvar = false;
                    tsbSalvarDocumento.Enabled = false;
                }
                if (result == DialogResult.No)
                {
                    rtbTexto.ResetText();
                    rtbTexto.Clear();
                    blnAbertoSalvo = false;
                    blnSalvar = false;
                    tsbSalvarDocumento.Enabled = false;
                }

            }
            else
            {
                rtbTexto.ResetText();
                rtbTexto.Clear();
                blnAbertoSalvo = false;
                blnSalvar = false;
                tsbSalvarDocumento.Enabled = false;
            }
        }

        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {
            // Salva a posição do cursor
            int posicaoCursor = rtbTexto.SelectionStart;

            tsbSalvarDocumento.Enabled = true;
            blnSalvar = true;

            // Salva a cor original do texto no RichTextBox
            Color corOriginal = rtbTexto.ForeColor;

            // Itera sobre todas as palavras no RichTextBox
            foreach (string palavra in rtbTexto.Text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries))
            {
                bool palavraNaLista = lista.PalavraNaLista(palavra);

                // rastreia a posição da palavra no texto
                int inicioPalavra = 0;
                while (inicioPalavra < rtbTexto.Text.Length)
                {
                    // Isso encontra a próxima ocorrência da palavra no texto, começando na posição atual (inicioPalavra).
                    inicioPalavra = rtbTexto.Text.IndexOf(palavra, inicioPalavra);
                    // se a palavra não for encontrada ele irá parar
                    if (inicioPalavra == -1)
                        break;

                    // Seleciona a palavra no RichTextBox para aplicar formatação
                    rtbTexto.Select(inicioPalavra, palavra.Length);
                    // Se a palavra estiver na lista, a cor original é usada, caso contrário, a cor vermelha é aplicada.
                    rtbTexto.SelectionColor = palavraNaLista ? corOriginal : Color.Red;

                    inicioPalavra += palavra.Length;
                }
            }

            // Retorna a posição do cursor
            rtbTexto.Select(posicaoCursor, 0);
        }

        private void tsbAbrirDocumento_Click(object sender, EventArgs e)
        {
            ofdAbrirDocumento.Title = "Abrir Documento";
            ofdAbrirDocumento.Filter = "Documento rtf|*.rtf";
            if (ofdAbrirDocumento.ShowDialog() == DialogResult.OK)
            {
                rtbTexto.LoadFile(ofdAbrirDocumento.FileName);
                strCaminho = ofdAbrirDocumento.FileName;
                blnAbertoSalvo = true;
            }
        }

        private void tsbSalvarDocumento_Click(object sender, EventArgs e)
        {
            if (blnSalvar == true)
            {
                if (blnAbertoSalvo == false)
                {
                    sfdSalvarDocumento.Title = "Salvar Documento";
                    sfdSalvarDocumento.Filter = "Documento rtf|*.rtf";
                    sfdSalvarDocumento.FileName = "";
                    if (sfdSalvarDocumento.ShowDialog() == DialogResult.OK)
                    {
                        rtbTexto.SaveFile(sfdSalvarDocumento.FileName);
                        strCaminho = sfdSalvarDocumento.FileName;
                        blnAbertoSalvo = true;
                    }
                }
                else
                {
                    rtbTexto.SaveFile(strCaminho);
                }
            }
        }

        private void rtbTexto_SelectionChanged(object sender, EventArgs e)
        {
            if (rtbTexto.SelectedText.Count() > 0)
            {
                tsbInserir.Enabled = true;
            }
            else
            {
                tsbInserir.Enabled = false;
            }
        }

        private void tsbInserir_Click(object sender, EventArgs e)
        {
            DialogResult resultLista = MessageBox.Show("Quer inserir esta palavra na lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultLista == DialogResult.Yes)
            {
                string palavraSelecionada = rtbTexto.SelectedText.Trim();
                lista.AdicionarPalavra(palavraSelecionada.ToLower());
                string caminhoArquivoLista = "lista_palavras.txt";
                lista.SalvarLista(caminhoArquivoLista);
            }
        }
    }
}
