using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Lista
    {
        private No primeiro; // O primeiro nó da lista

        public Lista()
        {
            this.primeiro = null;
        }

        // Método para adicionar palavra à lista
        public void AdicionarPalavra(string palavra)
        {
            No novoNo = new No(palavra, null);
            novoNo.next = primeiro; // Insere no início da lista
            primeiro = novoNo;
        }

        // Método para verificar se a palavra está na lista
        public bool PalavraNaLista(string palavra)
        {
            No atual = primeiro;
            while (atual != null)
            {
                if (atual.elemento == palavra)
                {
                    return true; // Palavra encontrada na lista
                }
                atual = atual.next;
            }
            return false; // Palavra não encontrada na lista
        }

        // Método para carregar palavras da lista a partir de um arquivo
        public void CarregarLista(string caminhoArquivo)
        {
            if (!File.Exists(caminhoArquivo))
            {
                DialogResult dialogo = MessageBox.Show("O arquivo não foi encontrado!");
            }

            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                string palavra;
                while ((palavra = sr.ReadLine()) != null)
                {
                    AdicionarPalavra(palavra.Trim().ToLower()); // Armazena em minúsculas para consistência
                }
            }
        }

        // Método para salvar palavras da lista em um arquivo
        public void SalvarLista(string caminhoArquivo)
        {
            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                No atual = primeiro;
                while (atual != null)
                {
                    sw.WriteLine(atual.elemento);
                    atual = atual.next;
                }
            }
        }
    }
}

