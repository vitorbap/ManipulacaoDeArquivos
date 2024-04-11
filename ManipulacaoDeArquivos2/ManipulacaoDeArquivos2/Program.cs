using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Entrada e saida
using System.Runtime.Serialization.Formatters.Binary; //Dados binarios


namespace ManipulacaoDeArquivos2
{
    class Program
    {
        [System.Serializable] //Converte os dados para binario
        struct Produto
        {
            public string nome;
            public string preco;

        }

        static void Main(string[] args)
        {
            //Escrever dentro de um arquivo
            int a = 120;
            string nome = "Vitor";
            float b = 12.2f;

            List<string> langs = new List<string>();
            langs.Add("C#");
            langs.Add("Javascript");
            langs.Add("PHP");

            Produto banana = new Produto();
            banana.nome = "Banana";
            banana.preco = "10";

            FileStream stream = new FileStream("meuarquivo.vitor", FileMode.OpenOrCreate); //FileStream = Escreve e lê dados dentro do arquivo
            BinaryFormatter encoder = new BinaryFormatter();//Transforma os dados em binario

            /*
            encoder.Serialize(stream, langs);
            encoder.Serialize(stream, banana);
            */

            //Ler o que esta em binario dentro do arquivo
            List<string> listaDoArquivo = (List<String>)encoder.Deserialize(stream);
            Produto prod = (Produto)encoder.Deserialize(stream);

            Console.WriteLine(listaDoArquivo[0]);
            Console.WriteLine(prod.nome);

            stream.Close();

            Console.ReadLine();

        }
    }
}
