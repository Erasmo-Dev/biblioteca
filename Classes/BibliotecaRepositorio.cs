using System;
using System.Collections.Generic;
using biblioteca.Interfaces;

namespace biblioteca
{
	public class BibliotecaRepositorio : IRepositorio<Livro>
	{
        private List<Livro> listaLivro = new List<Livro>();
		public void Atualizar(int id, Livro objeto)
		{
			listaLivro[id] = objeto;
		}

		public void Excluir(int id)
		{
			listaLivro[id] = null;
		}

		public void Inserir(Livro objeto)
		{
			listaLivro.Add(objeto);
		}

		public List<Livro> Lista()
		{
			return listaLivro;
		}

		public int ProximoId()
		{
			return listaLivro.Count;
		}

		public Livro RetornaPorId(int id)
		{
			return listaLivro[id];
		}
	}
}