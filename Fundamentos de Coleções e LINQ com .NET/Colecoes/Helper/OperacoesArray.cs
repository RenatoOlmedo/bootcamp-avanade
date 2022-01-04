using System;

namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public void ImprimirArray(int[] array){
            var linha = string.Join(" - ", array);
            System.Console.WriteLine(linha);
        }

        public void OrdenarBubbleSort(ref int[] array){
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length -1; j++)
                {
                    if (array[j] > array[j+1]){
                        temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
        }

        public void Ordenar(ref int[] array){
            Array.Sort(array);
        }

        public void copiar(ref int[] array, ref int[] arrayCopia){
            Array.Copy(array, arrayCopia,array.Length);
        }

        public bool Existe(int[] array, int valor){
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor){
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int ObterValor(int[] array, int valor){
            return Array.Find(array, elemento => elemento == valor);
        }

        public int obterIndice(int[] array, int valor){
            return Array.IndexOf(array, valor);
        }

        public void redimensionarArray(ref int[] array, int novoTamanho){
            Array.Resize(ref array, novoTamanho);
        }

        public string[] ConverterParaArrayString(int[] array){
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }

        
    }
}