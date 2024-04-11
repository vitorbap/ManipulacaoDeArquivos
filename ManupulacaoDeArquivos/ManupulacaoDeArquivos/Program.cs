using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ManupulacaoDeArquivos
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            //ESCREVER DENTRO DO ARQUIVO
            //Toda vez em que roda o código ele acrescenta uma linha
            //no arquivo .txt conforme escrito no código abaixo

            StreamWriter escritor = File.AppendText("teste.txt");
            escritor.WriteLine("Vitor");
            escritor.WriteLine("Hugo");
            escritor.WriteLine("Curso de C#");
            escritor.Close();
            */

            //--------------------------------
            /*
            //LER OS DADOS DENTRO DO ARQUIVO
            StreamReader leitor = new StreamReader("teste.txt");
            //string conteudo = leitor.ReadToEnd();

            List<string> linhas = new List<string>();
            string linha = "";

            while (linha != null)
            {
                linha = leitor.ReadLine();
                if (linha != null)
                {
                    Console.WriteLine(linha);
                }
            }

            Console.WriteLine(linhas[4]); //Exibe o conteudo da linha de 4
            leitor.Close();
            */
            /*
            //Exibe o texto que foi anotado no .txt
            foreach (string nome in linhas)
            {
                Console.WriteLine(nome);
            }
            */
            
            StreamReader leitor = new StreamReader("teste.txt");
            //string conteudo = leitor.ReadToEnd(); //Salva todo o conteudo em uma única variavel (string)
            //Console.WriteLine(leitor.ReadLine()); //Executa linha por linha do arquivo

            
            List<string> linhas = new List<string>(); //Salvar cada linha dentro da lista linhas
            string linha = "";

            while(linha != null)//Ler linha por linha utilizando uma estrutura de repetição
            {
                linha = leitor.ReadLine();
                if (linha != null)
                {
                    linhas.Add(linha);
                }
                Console.WriteLine(linha);
            }

            Console.WriteLine(linhas[4]);

            /*
            foreach (string nome in linhas)//Foreach = Para cada elemento
            {
                Console.WriteLine(nome);
            }
            */

            Console.WriteLine("Arquivo gerado.");
            Console.ReadLine();


        }
    }
}
