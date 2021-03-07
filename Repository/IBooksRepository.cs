using IntegraçãoBD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegraçãoBD.Repository
{
    public interface IBooksRepository
    {
        Books Create(Books books);
        Books FindByID(long id);
        List<Books> FindAll();
        Books Update(Books books);
        void Delete(long id);
        bool Exists(long id);
    }
}
