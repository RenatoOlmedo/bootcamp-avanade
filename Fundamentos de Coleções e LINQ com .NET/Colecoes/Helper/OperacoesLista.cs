using System.Collections.Generic;

namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void imprimirListaString(List<string> lista){
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Indice: {i} valor: {lista[i]}");
            }
        }
    }
}