using System;
using System.Collections.Generic;
using trilha_net.Models;
using Newtonsoft.Json;
using System.Globalization;

namespace trilha_net
{
    class Program
    {
        static void Main(string[] args)
        {
            var tipoAnonimo = new { Nome = "Walteir", Sobrenome = "Coelho", Altura = 1.80 };

            Console.WriteLine($"Nome: {tipoAnonimo.Nome} " +
                              $"\nSobrenome: {tipoAnonimo.Sobrenome} " +
                              $"\nAltura: {tipoAnonimo.Altura.ToString("F2", CultureInfo.InvariantCulture)}");

            string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

            List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

            foreach (Venda venda in listaVendas)
            {
                Console.WriteLine($"| Id: {venda.Id} | " +
                                  $"Produto: {venda.Produto} | " +
                                  $"Preço: {venda.Preco:C} | " +
                                  $"Venda: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")} | " +
                                  $"{(venda.Desconto.HasValue ? $"Desconto de {venda.Desconto:C} |" : "")}");
            }

            var listaAnonima = listaVendas.Select(x => new { x.Produto, x.Preco });

            foreach (var venda in listaAnonima)
            {
                Console.WriteLine($"Produto: {venda.Produto}");
                Console.WriteLine($"Preço: {venda.Preco:C}");
            }

            /*
            DateTime dataAtual = DateTime.Now; //ISO 8601

            List<Venda> vendas = new List<Venda>();
            vendas.Add(new Venda(1, "Material de escritorio", 25.00M, dataAtual));
            vendas.Add(new Venda(2, "Caneta", 1.99M, dataAtual));
            vendas.Add(new Venda(3, "Mesa de escritório", 199.90M, dataAtual));

            //Venda v1 = new Venda(1, "Computador", 999.90M);

            string serialziado = JsonConvert.SerializeObject(vendas, Formatting.Indented);

            Console.WriteLine(serialziado);

            File.WriteAllText("Arquivos/vendas.json", serialziado);
            */

            /*
            int numero = 15;

            bool ehPar = false;

            //if ternario
            ehPar = numero % 2 == 0;

            Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));
            */
            /*
            Pessoa p1 = new Pessoa("Walteir", "Filho");

            (string nome, string sobrenome) = p1;

            Console.WriteLine($"{nome} {sobrenome}");
            */
            /*
            LeituraArquivo arquivo = new LeituraArquivo();

            var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

            if (sucesso)
            {
                //Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
                foreach (string linha in linhasArquivo)
                {
                    Console.WriteLine(linha);
                }
            }
            else
            {
                Console.WriteLine("Não foi possivel ler o arquivo");
            }

            (int, string, string) tupla = (1, "Walteir", "Coelho");
            Console.WriteLine($"Id: {tupla.Item1}");
            Console.WriteLine($"Nome: {tupla.Item2}");
            Console.WriteLine($"Sobrenome: {tupla.Item3}");

            ValueTuple<int, string, string, decimal> outraTupla = (2, "Heloisa", "Amaral", 1.66M);
            Console.WriteLine(outraTupla);

            var maisUmaTupla = Tuple.Create(3, "Edilaine", "Morais", 1.69M);
            Console.WriteLine(maisUmaTupla);
            */
        }
    }
}