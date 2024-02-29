using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_poo2_20240229
{
    internal class AgendaTelefonica
    {
        public string proprietario { get; set; }

        public Dictionary<string, Contato> dicionario { get; set }

        public AgendaTelefonica(string proprietario)
        {
            dicionario = new Dictionary<string, Contato>;
            this.proprietario = proprietario;
        }

        public void Inserir (string nome, string telefone)
        {
            //Contato c = new Contato(nome, telefone);
            dicionario.Add(nome, new Contato(nome, telefone));
        }

        public Contato Buscar (string nome)
        {
            return dicionario[nome];
        }

        public void Remover(string nome)
        {
            Contato c = Buscar(nome);
            if (dicionario.Remove(c))
            {
                Console.WriteLine("Removido");
            }
            else
            {
                Console.WriteLine("Não existe este contato");
            }
        }

        public int Tamanho()
        {
            return dicionario.Count;
        }
    }
}
