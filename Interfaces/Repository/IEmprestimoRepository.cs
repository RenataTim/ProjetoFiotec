using CadastroLivrosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivrosApp.Domain.Interfaces.Repository
{
    public class IEmprestimoRepository : IBaseRepository<Emprestimo>
    {
        public void Add(Emprestimo entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Emprestimo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Emprestimo? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Emprestimo entity)
        {
            throw new NotImplementedException();
        }
    }
}
