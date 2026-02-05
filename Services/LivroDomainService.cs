using CadastroLivrosApp.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivrosApp.Domain.Services
{
    public class LivroDomainService: ILivroDomainService
    {
        private readonly ILivroDomainService _livroRepository;

        public LivroDomainService(ILivroDomainService livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public Livro CriarLivro(Livro livro)
        {
            if (livro == null)
                throw new ArgumentNullException(nameof(livro));

            if (string.IsNullOrWhiteSpace(livro.Titulo))
                throw new ArgumentException("Titulo é obrigatório.");

            if (string.IsNullOrWhiteSpace(livro.Autor))
                throw new ArgumentException("Autor é obrigatório.");

            if (string.IsNullOrWhiteSpace(livro.Autor))
                throw new ArgumentException("Autor é obrigatório.");


            if (string.IsNullOrWhiteSpace(livro.AnoPublicacao))
                throw new ArgumentException("Autor é obrigatório.");

            if (string.IsNullOrWhiteSpace(livro.TotalLivros))
                throw new ArgumentException("Autor é obrigatório.");

            if (string.IsNullOrWhiteSpace(livro.QuantidadeDisponivel))
                throw new ArgumentException("Autor é obrigatório.");

            _livroRepository.Add(livro);

            return livro;
        }

    }
}
