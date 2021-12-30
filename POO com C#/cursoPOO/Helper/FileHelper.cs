using System.Collections.Generic;
using System.IO;

namespace cursoPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho){
            var retornoCaminho = Directory.GetDirectories(caminho,"*",SearchOption.AllDirectories);

            foreach(var retorno in retornoCaminho){
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho){
            var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            foreach(var retorno in retornoArquivos){
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho){
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void apagarDiretorio(string caminho, bool ApagarArquivos){
            Directory.Delete(caminho, ApagarArquivos);
        }

        public void CriarArquivotxt(string caminho, string conteudo){
            if(!File.Exists(caminho)){
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void criarArquivotxtStream(string caminho, List<string> conteudo){
            using(var stream = File.CreateText(caminho)){
                    foreach(var linha in conteudo){
                    stream.WriteLine(linha);
                }
            }    
        }

        public void adicionarTexto (string caminho, string conteudo){
            File.AppendAllText(caminho, conteudo);
        }

        public void adicionartxtStream(string caminho, List<string> conteudo){
            using(var stream = File.AppendText(caminho)){
                    foreach(var linha in conteudo){
                    stream.WriteLine(linha);
                }
            }    
        }

        public void lerArquivo(string caminho){
            var conteudo = File.ReadAllLines(caminho); 

            foreach(var linha in conteudo){
                System.Console.WriteLine(linha);
            }
        }

        public void LerArquivoStream(string caminho){
            string linha = string.Empty;

            using(var stream = File.OpenText(caminho)){
                while((linha = stream.ReadLine()) != null){
                    System.Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever){
            File.Move(caminho,novoCaminho, sobrescrever);
        }

        public void copiarArquivo(string caminho, string novoCaminho, bool sobrescrever){
            File.Copy(caminho,novoCaminho, sobrescrever);
        }

        public void deletarArquivo(string caminho){
            File.Delete(caminho);
        }
    }
}