using System;
using System.Collections.Generic;
using System.IO;
using cursoPOO.Helper;
using cursoPOO.Interfaces;
using cursoPOO.Models;

namespace cursoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "c:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo.teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo.teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo.teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta teste 2", "arquivo.teste-stream.txt");
            var listaString = new List<string> {"linha 1", "linha 2", "linha 3"};
            var listaStringcontinuacao = new List<string> {"linha 4", "linha 5", "linha 6"};

            FileHelper h = new FileHelper();
            // h.ListarDiretorios(caminho);
            // h.ListarArquivosDiretorios(caminho);

            // h.CriarDiretorio(caminhoPathCombine);

            // h.apagarDiretorio(caminhoPathCombine, true);

            // h.CriarArquivotxt(caminhoArquivo,"Olá! teste de escrita de arquivo");

            // h.criarArquivotxtStream(caminhoArquivo, listaString);
            // h.adicionartxtStream(caminhoArquivo, listaStringcontinuacao);

            // h.LerArquivoStream(caminhoArquivo);

            // h.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);

            // h.copiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);

            h.deletarArquivo(caminhoArquivoTesteCopia);

            //  Icalculadora c = new Calculadora();
            //  System.Console.WriteLine(c.Somar(2,4));

            // Computador c = new Computador();
            // System.Console.WriteLine(c.ToString());

            // Corrente co = new Corrente();
            // co.Creditar(120);
            // co.ExibirSaldo();


            // Calculadora c = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: "+ c.somar(2,2));
            // System.Console.WriteLine("Resultado da segunda soma: "+ c.somar(2,2,2));

            // Aluno a1 = new Aluno();
            // a1.nome = "Joao";
            // a1.idade = 19;
            // a1.nota = 8;
            // a1.Apresentar();

            // Professor p2 = new Professor();
            // p2.nome = "Jairo";
            // p2.idade = 49;
            // p2.Salario = 1500;
            // p2.Apresentar();
            // p2.documento = "229583013";



            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(20,40);
            

            // Console.WriteLine($"Área: {r.obterArea()}");

            // Pessoa p1 = new Pessoa();
            
            // p1.nome = "Renato";
            // p1.idade = 19;
            // p1.Apresentar();
        }
    }
}
