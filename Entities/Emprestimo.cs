using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivrosApp.Domain.Entities
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int LivroId { get; set; }
        public string NomeUsuario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Livro Livro { get; set; }

    }
}
