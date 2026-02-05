using CadastroLivrosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivrosApp.Domain.Interfaces.Services
{
    public class ILivroDomainService : ILivroDomainService
    {
        Livro CriarLivro(Livro livro);
        Livro AtualizarLivro(Livro livro);

        Livro ExcluirLivro(int livroid);

        Livro? ObterLivroPorId(int livroid);

        IEnumerable<Livro> ListarTodosLivros { get; }
    }
}
