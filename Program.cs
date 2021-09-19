using System;

namespace biblioteca
{
    class Program
    {
        static BibliotecaRepositorio repositorio = new BibliotecaRepositorio();
        static void Main(string[] args)
        {
             string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarLivros();
						break;
					case "2":
						InserirLivro();
						break;
					case "3":
						AtualizarLivro();
						break;
					case "4":
						ExcluirLivro();
						break;
					case "5":
						VisualizarLivro();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();


        }
         private static void ExcluirLivro()
		{
			Console.Write("Digite o id do livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			
			repositorio.Excluir(indiceLivro);
		}


           private static void VisualizarLivro()
		{
			Console.Write("Digite o id do livro: ");

			int indiceLivro = int.Parse(Console.ReadLine());

			var livro = repositorio.RetornaPorId(indiceLivro);

			Console.WriteLine(livro);

		}


        private static void AtualizarLivro()
		{
			Console.Write("Digite o id do livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do livro: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de lançamento do livro: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite o nome do autor do livro: ");
			string entradaAutor = Console.ReadLine();

            Console.Write("Digite o nome da editora do livro: ");
			string entradaEditora = Console.ReadLine();

			Livro atualizaLivro = new Livro(id: indiceLivro,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										autor: entradaAutor,
                                        editora: entradaEditora);

			repositorio.Atualizar(indiceLivro, atualizaLivro);
		}

        private static void ListarLivros()
		{
			Console.WriteLine("Listar livros");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum livro encontrado.");
				return;
			}

			foreach (var livro in lista)
			{
                if(livro == null){

                }else{
                    Console.WriteLine("#ID {0}: - Titulo: {1} ", livro.retornaId(), livro.retornaTitulo());
                }
                
			}
		}

        private static void InserirLivro()
		{
			Console.WriteLine("Inserir novo livro");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do livro: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de lançamento do livro: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite o nome do autor do livro: ");
			string entradaAutor = Console.ReadLine();

            Console.Write("Digite o nome da editora do livro: ");
			string entradaEditora = Console.ReadLine();

			Livro novoLivro = new Livro(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										autor: entradaAutor,
                                        editora: entradaEditora);

			repositorio.Inserir(novoLivro);
		}

           private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Entre com a operação desejada");
            Console.WriteLine("1 - Listar todos os livros.");
            Console.WriteLine("2 - Inserir livro.");
            Console.WriteLine("3 - Atualizar livro.");
            Console.WriteLine("4 - Excluir livro.");
            Console.WriteLine("5 - vizualizar livro.");
            Console.WriteLine("C - Cancelar\n.");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}

        }
    }

