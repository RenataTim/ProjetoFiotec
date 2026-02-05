using CadastroLivrosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivrosApp.Domain.Interfaces.Repository
{
    public class ILivroRepository : IBaseRepository<Livro>
    {
        public void Add(Livro entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> GetAll()
        {
            throw new NotImplementedException();
        }

        public Livro? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Livro entity)
        {
            throw new NotImplementedException();
        }
    }
}
