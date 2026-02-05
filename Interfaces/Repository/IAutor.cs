using CadastroLivrosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroLivrosApp.Domain.Interfaces.Repository
{
    public class IAutor : IBaseRepository<Autor>
    {
        public void Add(Autor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Autor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Autor? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Autor entity)
        {
            throw new NotImplementedException();
        }
    }
}
