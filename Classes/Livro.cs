using System;
namespace biblioteca
{
    public class Livro : EntidadeBase
    {

        private String titulo { get; set; }
        private String autor { get; set; }
        private Genero genero { get; set; }
        private String editora { get; set; }
        private int ano { get; set; }


        public Livro(int id, String titulo, String autor, Genero genero, String editora, int ano) 
        {
                this.id = id;
                this.titulo = titulo;
                this.autor = autor;
                this.genero = genero;
                this.editora = editora;
                this.ano = ano;
               
        }

         public override string ToString()
		{
            string retorno = "";
             retorno += "Id: " + this.id + Environment.NewLine;
             retorno += "Autor: " + this.autor + Environment.NewLine;
            retorno += "Gênero: " + this.genero + Environment.NewLine;
            retorno += "Titulo: " + this.titulo + Environment.NewLine;
            retorno += "editora: " + this.editora + Environment.NewLine;
            retorno += "Ano de lançamento: " + this.ano;
			return retorno;
		}

          public int retornaId()
		{
			return this.id;
		}
          public string retornaTitulo()
		{
			return this.titulo;
		}

            public string retornaAutor()
		{
			return this.autor;
		}
        
            public Genero retornaGenero()
		{
			return this.genero;
		}

            public string retornaEditora()
		{
			return this.editora;
		}

            public int retornaAno()
		{
			return this.ano;
		}

    }
}