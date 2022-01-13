namespace AppCrudSeries
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }   
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int Id, Genero genero,string titulo, string descricao, int ano){
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: "+this.Genero;
            retorno += "\nTítulo: "+this.Titulo;
            retorno += "\nDescrição: "+this.Descricao;
            retorno += "\nAno de início: "+this.Ano;
            return retorno;
        }

        public string retornaTitulo(){
            return this.Titulo;
        }

        public int retornaId(){
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}

