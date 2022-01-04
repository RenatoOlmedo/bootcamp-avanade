using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesLista opLista = new OperacoesLista();

            string[] estadosArray = new string[2]{"SC", "MT"};
            List<string> estados = new List<string>();
            estados.Add("SP");
            estados.Add("MG");
            estados.Add("BA");

            System.Console.WriteLine($"Quantidade de elementos da lista {estados.Count}");

            //opLista.imprimirListaString(estados);

            estados.AddRange(estadosArray);
            estados.Insert(1, "RJ");
           
            opLista.imprimirListaString(estados);

            // System.Console.WriteLine("Removendo o elemento MG");
            // estados.Remove("MG");

            // opLista.imprimirListaString(estados);

            

            // int[] arrayCopia = new int[10];

            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5]{7,3,90,5,11};

            // string[] arrayString = op.ConverterParaArrayString(array);


            // System.Console.WriteLine($"capacidade atual do array {array.Length}");

            // op.redimensionarArray(ref array, array.Length * 2);
            
            // System.Console.WriteLine($"nova capacidade do array {array.Length}");


            // int valorProcurado = 5;

            // int indice = op.obterIndice(array, valorProcurado);

            // if(indice!= -1){
            //     System.Console.WriteLine("O indice do elemento {0} é igual a: {1} ",valorProcurado, indice);
            // }
            // else{System.Console.WriteLine("valor não encontrado");}

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if (valorAchado>0){
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else{
            //     System.Console.WriteLine("Não encontrei o valor");
            // }


            // bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if (TodosMaiorQue){
            //     System.Console.WriteLine("todos os valores são maior que "+valorProcurado);
            // }
            // else{
            //     System.Console.WriteLine("existem valores menores que "+ valorProcurado);
            // }

            // bool existe = op.Existe(array, valorProcurado);

            // if (existe){
            //     System.Console.WriteLine("Encontrei o valor no array");
            // }
            // else{
            //     System.Console.WriteLine("Não encontrei o valor");
            // }

            // System.Console.WriteLine("Array original");
            // op.ImprimirArray(array);

            // //op.OrdenarBubbleSort(ref array);
            // //op.Ordenar(ref array);

            // System.Console.WriteLine("Array ordenado");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da copia:");
            // op.ImprimirArray(arrayCopia);

            // op.copiar(ref array, ref arrayCopia);

            // System.Console.WriteLine("Array após a copia:");
            // op.ImprimirArray(arrayCopia);

            // int[,] matriz = new int[4,2]{
            //     {8,8}, 
            //     {10,20}, 
            //     {50,100}, 
            //     {90,200}
            // };
            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i,j]);
            //     }
            // }



            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 9;
            // arrayInteiros[1] = 18;
            // arrayInteiros[2] = 27;

            // System.Console.WriteLine("Percorrendo o Array pelo for");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //    System.Console.WriteLine(arrayInteiros[i]); 
            // }

            // System.Console.WriteLine("Percorrendo o Array pelo foreach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}
